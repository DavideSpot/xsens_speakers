//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XDA {

public class XsIntArrayImpl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsIntArrayImpl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsIntArrayImpl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsIntArrayImpl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsIntArrayImpl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsIntArrayImpl(uint count, SWIGTYPE_p_int src) : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_0(count, SWIGTYPE_p_int.getCPtr(src)), true) {
  }

  public XsIntArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_1(count), true) {
  }

  public XsIntArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_2(), true) {
  }

  public XsIntArrayImpl(XsIntArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_3(XsIntArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsIntArrayImpl(SWIGTYPE_p_int arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_4(SWIGTYPE_p_int.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsIntArrayImpl(SWIGTYPE_p_int arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsIntArrayImpl__SWIG_5(SWIGTYPE_p_int.getCPtr(arg0), sz), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsIntArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public int value(uint index) {
    int ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_value(swigCPtr, index);
    return ret;
  }

  public int at(uint index) {
    int ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_at__SWIG_0(swigCPtr, index);
    return ret;
  }

  public void insert(int item, uint index) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_insert__SWIG_0(swigCPtr, item, index);
  }

  public void insert(SWIGTYPE_p_int items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_insert__SWIG_1(swigCPtr, SWIGTYPE_p_int.getCPtr(items), index, count);
  }

  public void push_back(int item) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_push_back(swigCPtr, item);
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(int item) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_push_front(swigCPtr, item);
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, SWIGTYPE_p_int src) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_assign(swigCPtr, count, SWIGTYPE_p_int.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsIntArrayImpl other) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_append(swigCPtr, XsIntArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsIntArrayImpl other) {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_swap(swigCPtr, XsIntArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int find(int needle) {
    int ret = xsensdeviceapiPINVOKE.XsIntArrayImpl_find(swigCPtr, needle);
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_removeDuplicates(swigCPtr);
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsIntArrayImpl_sort(swigCPtr);
  }

}

}
