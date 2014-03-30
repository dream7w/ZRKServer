/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

public class NetworkIDManager : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NetworkIDManager(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NetworkIDManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NetworkIDManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NetworkIDManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public Dictionary<IntPtr, NetworkIDObject> pointerDictionary = new Dictionary<IntPtr, NetworkIDObject>();

     public NetworkIDObject GET_BASE_OBJECT_FROM_ID(ulong x)
     {
	return pointerDictionary[GET_BASE_OBJECT_FROM_IDORIG(x).GetIntPtr()];
     }


  public static NetworkIDManager GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.NetworkIDManager_GetInstance();
    NetworkIDManager ret = (cPtr == IntPtr.Zero) ? null : new NetworkIDManager(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(NetworkIDManager i) {
    RakNetPINVOKE.NetworkIDManager_DestroyInstance(NetworkIDManager.getCPtr(i));
  }

  public NetworkIDManager() : this(RakNetPINVOKE.new_NetworkIDManager(), true) {
  }

  protected NetworkIDObject GET_BASE_OBJECT_FROM_IDORIG(ulong x) {
    IntPtr cPtr = RakNetPINVOKE.NetworkIDManager_GET_BASE_OBJECT_FROM_IDORIG(swigCPtr, x);
    NetworkIDObject ret = (cPtr == IntPtr.Zero) ? null : new NetworkIDObject(cPtr, false);
    return ret;
  }

}

}
