
using System;

namespace PuertsStaticWrap
{
    public static class UnityEngine_DrivenRectTransformTracker_Wrap
    {

        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {
            
                    {
                
                        var result = new UnityEngine.DrivenRectTransformTracker();
                
                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.DrivenRectTransformTracker), result);
                    
                    }
                
                }
            
    
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_StopRecordingUndo(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                
        
                {
            
                    {
                
                        UnityEngine.DrivenRectTransformTracker.StopRecordingUndo();
                
                        
                        
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_StartRecordingUndo(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                
        
                {
            
                    {
                
                        UnityEngine.DrivenRectTransformTracker.StartRecordingUndo();
                
                        
                        
                        
                    }
                
                }
            
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Add(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DrivenRectTransformTracker)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    var argHelper0 = new Puerts.ArgumentHelper((int)data, isolate, info, 0);
                
                    var argHelper1 = new Puerts.ArgumentHelper((int)data, isolate, info, 1);
                
                    var argHelper2 = new Puerts.ArgumentHelper((int)data, isolate, info, 2);
                
                    {
                
                        var Arg0 = argHelper0.Get<UnityEngine.Object>(false);
                    
                        var Arg1 = argHelper1.Get<UnityEngine.RectTransform>(false);
                    
                        var Arg2 = (UnityEngine.DrivenTransformProperties)argHelper2.GetInt32(false);
                    
                        obj.Add(Arg0, Arg1, Arg2);
                
                        
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
        private static void M_Clear(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DrivenRectTransformTracker)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {
                
                        obj.Clear();
                
                        
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        
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
                    { new Puerts.MethodKey { Name = "StopRecordingUndo", IsStatic = true}, F_StopRecordingUndo },
                    { new Puerts.MethodKey { Name = "StartRecordingUndo", IsStatic = true}, F_StartRecordingUndo },
                    { new Puerts.MethodKey { Name = "Add", IsStatic = false}, M_Add },
                    { new Puerts.MethodKey { Name = "Clear", IsStatic = false}, M_Clear }
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
