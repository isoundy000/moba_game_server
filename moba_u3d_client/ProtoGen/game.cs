//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: game.proto
namespace gprotocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuestLoginReq")]
  public partial class GuestLoginReq : global::ProtoBuf.IExtensible
  {
    public GuestLoginReq() {}
    
    private string _guestkey;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guestkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guestkey
    {
      get { return _guestkey; }
      set { _guestkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserCenterInfo")]
  public partial class UserCenterInfo : global::ProtoBuf.IExtensible
  {
    public UserCenterInfo() {}
    
    private string _unick;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string unick
    {
      get { return _unick; }
      set { _unick = value; }
    }
    private int _sex;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int sex
    {
      get { return _sex; }
      set { _sex = value; }
    }
    private int _face;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"face", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int face
    {
      get { return _face; }
      set { _face = value; }
    }
    private int _uvip;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"uvip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uvip
    {
      get { return _uvip; }
      set { _uvip = value; }
    }
    private int _uid;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuestLoginRes")]
  public partial class GuestLoginRes : global::ProtoBuf.IExtensible
  {
    public GuestLoginRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private UserCenterInfo _info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public UserCenterInfo info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"Stype")]
    public enum Stype
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVALID_STYPE", Value=0)]
      INVALID_STYPE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Auth", Value=1)]
      Auth = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"System", Value=2)]
      System = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Logic", Value=3)]
      Logic = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Cmd")]
    public enum Cmd
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVALID_CMD", Value=0)]
      INVALID_CMD = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eGuestLoginReq", Value=1)]
      eGuestLoginReq = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eGuestLoginRes", Value=2)]
      eGuestLoginRes = 2
    }
  
}