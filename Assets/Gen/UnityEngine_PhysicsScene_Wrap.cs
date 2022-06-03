
using System;

namespace PuertsStaticWrap
{
    public static class UnityEngine_PhysicsScene_Wrap
    {

        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {
            
                    {
                
                        var result = new UnityEngine.PhysicsScene();
                
                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.PhysicsScene), result);
                    
                    }
                
                }
            
    
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_ToString(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
            
                {
            
                    {
                
                        var result = obj.ToString();
                
                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ToString");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_GetHashCode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
            
                {
            
                    {
                
                        var result = obj.GetHashCode();
                
                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetHashCode");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Equals(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.Any, typeof(System.Object), false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<System.Object>(false);
                    
                        var result = obj.Equals(Arg0);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.PhysicsScene), false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.PhysicsScene>(false);
                    
                        var result = obj.Equals(Arg0);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Equals");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_IsValid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {
                
                        var result = obj.IsValid();
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_IsEmpty(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {
                
                        var result = obj.IsEmpty();
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Simulate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    {
                
                        var Arg0 = argHelper0.GetFloat(false);
                    
                        obj.Simulate(Arg0);
                
                        
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Raycast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 5)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    var argHelper2 = new Puerts.ArgumentHelper((int)data, isolate, info, 2);
                
                    var argHelper3 = new Puerts.ArgumentHelper((int)data, isolate, info, 3);
                
                    var argHelper4 = new Puerts.ArgumentHelper((int)data, isolate, info, 4);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper4.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.GetFloat(false);
                    
                        var Arg3 = argHelper3.GetInt32(false);
                    
                        var Arg4 = (UnityEngine.QueryTriggerInteraction)argHelper4.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2, Arg3, Arg4);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit), true, true) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper4.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit>(true);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var Arg4 = argHelper4.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, out Arg2, Arg3, Arg4);
                
                        argHelper2.SetByRefValue(Arg2);
                        
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit[]), false, false) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper4.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit[]>(false);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var Arg4 = argHelper4.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2, Arg3, Arg4);
                
                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                if (paramLen == 4)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    var argHelper2 = new Puerts.ArgumentHelper((int)data, isolate, info, 2);
                
                    var argHelper3 = new Puerts.ArgumentHelper((int)data, isolate, info, 3);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.GetFloat(false);
                    
                        var Arg3 = argHelper3.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2, Arg3);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit), true, true) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit>(true);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, out Arg2, Arg3);
                
                        argHelper2.SetByRefValue(Arg2);
                        
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit[]), false, false) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit[]>(false);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2, Arg3);
                
                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                if (paramLen == 3)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    var argHelper2 = new Puerts.ArgumentHelper((int)data, isolate, info, 2);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.GetFloat(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit), true, true))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit>(true);
                    
                        var result = obj.Raycast(Arg0, Arg1, out Arg2);
                
                        argHelper2.SetByRefValue(Arg2);
                        
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit[]), false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit[]>(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2);
                
                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                if (paramLen == 2)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var result = obj.Raycast(Arg0, Arg1);
                
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                if (paramLen == 6)
            
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    var argHelper2 = new Puerts.ArgumentHelper((int)data, isolate, info, 2);
                
                    var argHelper3 = new Puerts.ArgumentHelper((int)data, isolate, info, 3);
                
                    var argHelper4 = new Puerts.ArgumentHelper((int)data, isolate, info, 4);
                
                    var argHelper5 = new Puerts.ArgumentHelper((int)data, isolate, info, 5);
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit), true, true) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper4.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper5.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit>(true);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var Arg4 = argHelper4.GetInt32(false);
                    
                        var Arg5 = (UnityEngine.QueryTriggerInteraction)argHelper5.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, out Arg2, Arg3, Arg4, Arg5);
                
                        argHelper2.SetByRefValue(Arg2);
                        
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                    if (argHelper0.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper1.IsMatch(Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false) && argHelper2.IsMatch(Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit[]), false, false) && argHelper3.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper4.IsMatch(Puerts.JsValueType.Number, null, false, false) && argHelper5.IsMatch(Puerts.JsValueType.Number, null, false, false))
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Vector3>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.Vector3>(false);
                    
                        var Arg2 = argHelper2.Get<UnityEngine.RaycastHit[]>(false);
                    
                        var Arg3 = argHelper3.GetFloat(false);
                    
                        var Arg4 = argHelper4.GetInt32(false);
                    
                        var Arg5 = (UnityEngine.QueryTriggerInteraction)argHelper5.GetInt32(false);
                    
                        var result = obj.Raycast(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5);
                
                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                
                }
            
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Raycast");
        
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void O_op_Equality(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    {
                 
                        var arg0 = argHelper0.Get<UnityEngine.PhysicsScene>(false);
                     
                        var arg1 = argHelper1.Get<UnityEngine.PhysicsScene>(false);
                    
                        var result = arg0 == arg1;
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void O_op_Inequality(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    {
                 
                        var arg0 = argHelper0.Get<UnityEngine.PhysicsScene>(false);
                     
                        var arg1 = argHelper1.Get<UnityEngine.PhysicsScene>(false);
                    
                        var result = arg0 != arg1;
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        
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
                    { new Puerts.MethodKey { Name = "ToString", IsStatic = false}, M_ToString },
                    { new Puerts.MethodKey { Name = "GetHashCode", IsStatic = false}, M_GetHashCode },
                    { new Puerts.MethodKey { Name = "Equals", IsStatic = false}, M_Equals },
                    { new Puerts.MethodKey { Name = "IsValid", IsStatic = false}, M_IsValid },
                    { new Puerts.MethodKey { Name = "IsEmpty", IsStatic = false}, M_IsEmpty },
                    { new Puerts.MethodKey { Name = "Simulate", IsStatic = false}, M_Simulate },
                    { new Puerts.MethodKey { Name = "Raycast", IsStatic = false}, M_Raycast },

                    { new Puerts.MethodKey { Name = "op_Equality", IsStatic = true}, O_op_Equality },

                    { new Puerts.MethodKey { Name = "op_Inequality", IsStatic = true}, O_op_Inequality }
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
