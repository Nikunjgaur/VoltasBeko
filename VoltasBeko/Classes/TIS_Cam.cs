using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIS;
using TIS.Imaging;

namespace VoltasBeko
{
    public class TIS_Cam
    {
        public TIS_Cam()
        {

        }
        public TIS_Cam(string deviceId)
        {
            OpenCamera(deviceId);
        }


        public BindingList<Pose> Poses = new BindingList<Pose>();

        // camera control variables
        public ICImagingControl IC = new ICImagingControl();
        public VCDSwitchProperty TriggerMode;
        public VCDButtonProperty SoftwareTrigger;
        public event EventHandler<Bitmap> ImageRecieved;

        public int Exposure {
            get
            {
                return GetExposureValue();
            }
            set 
            {
                SetExposureValue(value);
            }
        }
        public int Focus
        {
            get
            {
                return GetFocusValue();
            }
            set
            {
                SetFocusValueValue(value);
            }
        }
        public int Zoom
        {
            get
            {
                return GetZoomValue();
            }
            set
            {
                SetZoomValue(value);
            }
        }
       
        public void OpenCamera(string deviceName = "DFK 39GX548-Z20")
        {
            IC.Device = deviceName;
            
            IC.VideoFormat = "RGB32 (640x480)";
            // Set a frame rate. 
            IC.DeviceFrameRate = 30.0f;

            // Enable the trigger
            IC.DeviceTrigger = true;

            IC.LiveCaptureContinuous = true; //Call ImageAvailable event for new images.
            IC.LiveCaptureLastImage = false; // Do not save an image on live stop.

            // Add the ImageAvailable handler to the IC Imaging Control object.
            IC.ImageAvailable += new EventHandler<ICImagingControl.ImageAvailableEventArgs>(OnImageAvailable);

            //IC.ShowDeviceSettingsDialog(); // Select a video capture device
            //if (!IC.DeviceValid)
            //    return;
            Console.WriteLine($"Focus Range: {GetFocusValueRange()}\nZoom Range: {GetZoomValueRange()}");
          
            // Query the trigger mode property for enabling the trigger mode    
            TriggerMode = (VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(VCDIDs.VCDID_TriggerMode, VCDIDs.VCDElement_Value, VCDIDs.VCDInterface_Switch);
            if (TriggerMode == null)
                return;

            // If trigger mode is available, query the software trigger property
            SoftwareTrigger = (VCDButtonProperty)IC.VCDPropertyItems.FindInterface(VCDIDs.VCDID_TriggerMode, VCDIDs.VCDElement_SoftwareTrigger, VCDIDs.VCDInterface_Button);
            if (SoftwareTrigger == null)
                return;

            SetAutoWhiteBalanceValue(false);
            SetAutoExposureValue(false);
            SetAutoGainValue(false);
            SetAutoBrightnessValue(false);
            TriggerMode.Switch = false; // Enable trigger mode,

            IC.LiveStart();
            // start the camera. No images are streamed, because trigger mode is enabled
            //System.Threading.Thread.Sleep(1000);
            //SoftwareTrigger.Push(); // Do a software trigger.
            //System.Threading.Thread.Sleep(1000);
            //SoftwareTrigger.Push(); // Do another software trigger.
            //System.Threading.Thread.Sleep(1000);

            //IC.LiveStop(); // Stop live video.
        }
        private (int Max, int Min) GetFocusValueRange()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Focus, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    return (Property.RangeMax, Property.RangeMin);
                }
            }
            return (0, 0);
        }
        private int GetFocusValue()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Focus, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    return Property.Value;
                }
            }

            return 0;
        }

        private void SetFocusValueValue(int Value)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Focus, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    Property.Value = Value;
                }
            }
        }

        public bool AutoFocusLive()
        {
            if (IC.DeviceValid)
            {
                TIS.Imaging.VCDSwitchProperty SwitchItf;
                SwitchItf = (TIS.Imaging.VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Focus,
                                                            "{07D2DD39-3F10-4E0F-8EE5-3EED067A53C6}",
                                                            TIS.Imaging.VCDIDs.VCDInterface_Switch);
                if (SwitchItf != null)
                {
                    return SwitchItf.Switch;
                }
            }
            return false;
        }

        public void AutoFocus()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDButtonProperty Property;
                Property = (TIS.Imaging.VCDButtonProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Focus, TIS.Imaging.VCDIDs.VCDElement_OnePush, TIS.Imaging.VCDIDs.VCDInterface_Button);
                if (Property != null)
                {
                    Property.Push();
                }
            }
        }

        private (int Max, int Min) GetZoomValueRange()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Zoom, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    return (Property.RangeMax, Property.RangeMin);
                }
            }

            return (0,0);
        }

        private int GetZoomValue()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Zoom, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    return Property.Value;
                }
            }

            return 0;
        }

        private void SetZoomValue(int Value)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Zoom, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    Property.Value = Value;
                }
            }
        }

        private void SetExposureValue(int Value)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Exposure, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    Property.Value = Value;
                }
            }
        }

        private int GetExposureValue()
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDRangeProperty Property;
                Property = (TIS.Imaging.VCDRangeProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Exposure, TIS.Imaging.VCDIDs.VCDElement_Value, TIS.Imaging.VCDIDs.VCDInterface_Range);
                if (Property != null)
                {
                    return Property.Value;
                }
            }

            return 0;
        }
        public bool SetAutoExposureValue(bool value = false)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDSwitchProperty Property;

                Property = (TIS.Imaging.VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Exposure, TIS.Imaging.VCDIDs.VCDElement_Auto, TIS.Imaging.VCDIDs.VCDInterface_Switch);
                if (Property != null)
                {

                    Property.Switch = value;
                    Console.WriteLine($"SetAutoExposureValue {Property.Switch}");
                    return true;
                }
            }

            return false;
        }
        public bool SetAutoBrightnessValue(bool value = false)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDSwitchProperty Property;

                Property = (TIS.Imaging.VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Brightness, TIS.Imaging.VCDIDs.VCDElement_Auto, TIS.Imaging.VCDIDs.VCDInterface_Switch);
                if (Property != null)
                {

                    Property.Switch = value;
                    Console.WriteLine($"SetAutoExposureValue {Property.Switch}");
                    return true;
                }
            }

            return false;
        }
        public bool SetAutoGainValue(bool value = false)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDSwitchProperty Property;

                Property = (TIS.Imaging.VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_Gain, TIS.Imaging.VCDIDs.VCDElement_Auto, TIS.Imaging.VCDIDs.VCDInterface_Switch);
                if (Property != null)
                {

                    Property.Switch = value;
                    Console.WriteLine($"SetAutoGainValue {Property.Switch}");
                    return true;
                }
            }

            return false;
        }

        public bool SetAutoWhiteBalanceValue(bool value = false)
        {
            if (IC.DeviceValid == true)
            {
                TIS.Imaging.VCDSwitchProperty Property;
                Property = (TIS.Imaging.VCDSwitchProperty)IC.VCDPropertyItems.FindInterface(TIS.Imaging.VCDIDs.VCDID_WhiteBalance, TIS.Imaging.VCDIDs.VCDElement_Auto, TIS.Imaging.VCDIDs.VCDInterface_Switch);
                if (Property != null)
                {
                    Property.Switch = value;
                    Console.WriteLine($"SetAutoWhiteBalanceValue {Property.Switch}");

                    return Property.Switch;
                }
            }

            return false;
        }

        public void OnImageAvailable(object sender, TIS.Imaging.ICImagingControl.ImageAvailableEventArgs e)
        {
            ImageRecieved?.Invoke(this, e.ImageBuffer.CreateBitmapWrap());
        }

    }


    public class Pose
    {
        public Pose()
        {

        }
        public Pose(Pose pose)
        {
            location = pose.location;
            zoom = pose.zoom;
            focus = pose.focus;
            exposure = pose.exposure;
        }
        public Point location = new Point(100, 100);
        public int zoom = 0;
        public int focus = 0;
        public int exposure = 0;

        public void ActivatePose()
        {

        }
    }
}
