
using System;

namespace PuertsStaticWrap
{
    public static class UnityEngine_ScreenCapture_Wrap
    {

        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

    
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_CaptureScreenshot(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                
        
                if (paramLen == 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        UnityEngine.ScreenCapture.CaptureScreenshot(Arg0);
                
                        
                        
                        return;
                    }
                
                }
            
                if (paramLen == 2)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false) && argHelper1.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var Arg1 = argHelper1.GetInt32(false);
                    
                        UnityEngine.ScreenCapture.CaptureScreenshot(Arg0, Arg1);
                
                        
                        
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false) && argHelper1.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var Arg1 = (UnityEngine.ScreenCapture.StereoScreenCaptureMode)argHelper1.GetInt32(false);
                    
                        UnityEngine.ScreenCapture.CaptureScreenshot(Arg0, Arg1);
                
                        
                        
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CaptureScreenshot");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_CaptureScreenshotAsTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                
        
                if (paramLen == 0)
            
                {
            
                    {
                
                        var result = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture();
                
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        
                        return;
                    }
                
                }
            
                if (paramLen == 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetInt32(false);
                    
                        var result = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture(Arg0);
                
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = (UnityEngine.ScreenCapture.StereoScreenCaptureMode)argHelper0.GetInt32(false);
                    
                        var result = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture(Arg0);
                
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CaptureScreenshotAsTexture");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
            
        public static Puerts.TypeRegisterInfo GetRegisterInfo()
        {
            return new Puerts.TypeRegisterInfo()
            {
                BlittableCopy = false,
                Constructor = Constructor,
                Methods = new System.Collections.Generic.Dictionary<Puerts.MethodKey, Puerts.V8FunctionCallback>()
                {   
                    { new Puerts.MethodKey { Name = "CaptureScreenshot", IsStatic = true}, F_CaptureScreenshot },
                    { new Puerts.MethodKey { Name = "CaptureScreenshotAsTexture", IsStatic = true}, F_CaptureScreenshotAsTexture }
                },
                Properties = new System.Collections.Generic.Dictionary<string, Puerts.PropertyRegisterInfo>()
                {
                    
                },
                LazyMembers = new System.Collections.Generic.List<Puerts.LazyMemberRegisterInfo>()
                {   
                }
            };
        }
    
    }
}
