﻿
using System;

namespace PuertsStaticWrap
{
    public static class UnityEngine_AndroidJavaObject_Wrap
    {

        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen >= 1)
                
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false) && argHelper1.IsMatch(Puerts.JsValueType.Any, typeof(System.Object), false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var Arg1 = argHelper1.GetParams<System.Object>(info, 1, paramLen);
                    
                        var result = new UnityEngine.AndroidJavaObject(Arg0, Arg1);
                
                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.AndroidJavaObject), result);
                    
                    }
                
                }
            
                if (paramLen == 1)
                
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var result = new UnityEngine.AndroidJavaObject(Arg0);
                
                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.AndroidJavaObject), result);
                    
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to UnityEngine.AndroidJavaObject constructor");
    
    
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Dispose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AndroidJavaObject;
        
                {
            
                    {
                
                        obj.Dispose();
                
                        
                        
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Call(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AndroidJavaObject;
        
                if (paramLen >= 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false) && argHelper1.IsMatchParams(Puerts.JsValueType.Any, typeof(System.Object), 1, paramLen))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var Arg1 = argHelper1.GetParams<System.Object>(info, 1, paramLen);
                    
                        obj.Call(Arg0, Arg1);
                
                        
                        
                        return;
                    }
                
                }
            
                if (paramLen == 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        obj.Call(Arg0);
                
                        
                        
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Call");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_CallStatic(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AndroidJavaObject;
        
                if (paramLen >= 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false) && argHelper1.IsMatchParams(Puerts.JsValueType.Any, typeof(System.Object), 1, paramLen))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        var Arg1 = argHelper1.GetParams<System.Object>(info, 1, paramLen);
                    
                        obj.CallStatic(Arg0, Arg1);
                
                        
                        
                        return;
                    }
                
                }
            
                if (paramLen == 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.GetString(false);
                    
                        obj.CallStatic(Arg0);
                
                        
                        
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CallStatic");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_GetRawObject(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AndroidJavaObject;
        
                {
            
                    {
                
                        var result = obj.GetRawObject();
                
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_GetRawClass(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AndroidJavaObject;
        
                {
            
                    {
                
                        var result = obj.GetRawClass();
                
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        
                        
                    }
                
                }
            
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
                    { new Puerts.MethodKey { Name = "Dispose", IsStatic = false}, M_Dispose },
                    { new Puerts.MethodKey { Name = "Call", IsStatic = false}, M_Call },
                    { new Puerts.MethodKey { Name = "CallStatic", IsStatic = false}, M_CallStatic },
                    { new Puerts.MethodKey { Name = "GetRawObject", IsStatic = false}, M_GetRawObject },
                    { new Puerts.MethodKey { Name = "GetRawClass", IsStatic = false}, M_GetRawClass }
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
