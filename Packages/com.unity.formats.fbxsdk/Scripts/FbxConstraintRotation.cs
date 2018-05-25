//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace UnityEngine.Formats.FbxSdk {

public class FbxConstraintRotation : FbxConstraint {
  internal FbxConstraintRotation(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxConstraintRotation Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = GlobalsPINVOKE.FbxConstraintRotation_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxConstraintRotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintRotation(cPtr, false);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxConstraintRotation Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = GlobalsPINVOKE.FbxConstraintRotation_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxConstraintRotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintRotation(cPtr, false);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyBool AffectX {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(GlobalsPINVOKE.FbxConstraintRotation_AffectX_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectY {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(GlobalsPINVOKE.FbxConstraintRotation_AffectY_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectZ {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(GlobalsPINVOKE.FbxConstraintRotation_AffectZ_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble3 Rotation {
    get {
      FbxPropertyDouble3 ret = new FbxPropertyDouble3(GlobalsPINVOKE.FbxConstraintRotation_Rotation_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void AddConstraintSource(FbxObject pObject, double pWeight) {
    GlobalsPINVOKE.FbxConstraintRotation_AddConstraintSource__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pWeight);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddConstraintSource(FbxObject pObject) {
    GlobalsPINVOKE.FbxConstraintRotation_AddConstraintSource__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject));
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetConstrainedObject(FbxObject pObject) {
    GlobalsPINVOKE.FbxConstraintRotation_SetConstrainedObject(swigCPtr, FbxObject.getCPtr(pObject));
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxConstraintRotation other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxConstraintRotation;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxConstraintRotation).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxConstraintRotation a, FbxConstraintRotation b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxConstraintRotation a, FbxConstraintRotation b) {
    return !(a == b);
  }

}

}
