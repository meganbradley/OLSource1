---
title: "CSecurityDesc Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CSecurityDesc"
  - "ATL.CSecurityDesc"
  - "CSecurityDesc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSecurityDesc class"
ms.assetid: 3767a327-378f-4690-ba40-4d9f6a1f5ee4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc Class
This class is a wrapper for the **SECURITY_DESCRIPTOR** structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSecurityDesc::CSecurityDesc](../vs140/csecuritydesc--csecuritydesc.md)|The constructor.|  
|[CSecurityDesc::~CSecurityDesc](../vs140/csecuritydesc--~csecuritydesc.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSecurityDesc::FromString](../vs140/csecuritydesc--fromstring.md)|Converts a string-format security descriptor into a valid, functional security descriptor.|  
|[CSecurityDesc::GetControl](../vs140/csecuritydesc--getcontrol.md)|Retrieves control information from the security descriptor.|  
|[CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)|Retrieves discretionary access-control list (DACL) information from the security descriptor.|  
|[CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)|Retrieves the primary group information from the security descriptor.|  
|[CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)|Retrieves owner informaton from the security descriptor.|  
|[CSecurityDesc::GetPSECURITY_DESCRIPTOR](../vs140/csecuritydesc--getpsecurity_descriptor.md)|Returns a pointer to the **SECURITY_DESCRIPTOR** structure.|  
|[CSecurityDesc::GetSacl](../vs140/csecuritydesc--getsacl.md)|Retrieves system access-control list (SACL) information from the security descriptor.|  
|[CSecurityDesc::IsDaclAutoInherited](../vs140/csecuritydesc--isdaclautoinherited.md)|Determines if the DACL is configured to support automatic propagation.|  
|[CSecurityDesc::IsDaclDefaulted](../vs140/csecuritydesc--isdacldefaulted.md)|Determines if the security descriptor is configured with a default DACL.|  
|[CSecurityDesc::IsDaclPresent](../vs140/csecuritydesc--isdaclpresent.md)|Determines if the security descriptor contains a DACL.|  
|[CSecurityDesc::IsDaclProtected](../vs140/csecuritydesc--isdaclprotected.md)|Determines if the DACL is configured to prevent modifications.|  
|[CSecurityDesc::IsGroupDefaulted](../vs140/csecuritydesc--isgroupdefaulted.md)|Determines if the security descriptor's group security identifier (SID) was set by default.|  
|[CSecurityDesc::IsOwnerDefaulted](../vs140/csecuritydesc--isownerdefaulted.md)|Determines if the security descriptor's owner SID was set by default.|  
|[CSecurityDesc::IsSaclAutoInherited](../vs140/csecuritydesc--issaclautoinherited.md)|Determines if the SACL is configured to support automatic propagation.|  
|[CSecurityDesc::IsSaclDefaulted](../vs140/csecuritydesc--issacldefaulted.md)|Determines if the security descriptor is configured with a default SACL.|  
|[CSecurityDesc::IsSaclPresent](../vs140/csecuritydesc--issaclpresent.md)|Determines if the security descriptor contains a SACL.|  
|[CSecurityDesc::IsSaclProtected](../vs140/csecuritydesc--issaclprotected.md)|Determines if the SACL is configured to prevent modifications.|  
|[CSecurityDesc::IsSelfRelative](../vs140/csecuritydesc--isselfrelative.md)|Determines if the security descriptor is in self-relative format.|  
|[CSecurityDesc::MakeAbsolute](../vs140/csecuritydesc--makeabsolute.md)|Call this method to convert the security descriptor to absolute format.|  
|[CSecurityDesc::MakeSelfRelative](../vs140/csecuritydesc--makeselfrelative.md)|Call this method to convert the security descriptor to self-relative format.|  
|[CSecurityDesc::SetControl](../vs140/csecuritydesc--setcontrol.md)|Sets the control bits of a security descriptor.|  
|[CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md)|Sets information in a DACL. If a DACL is already present in the security descriptor, it is replaced.|  
|[CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md)|Sets the primary group information of an absolute format security descriptor, replacing any primary group information already present.|  
|[CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md)|Sets the owner information of an absolute format security descriptor, replacing any owner information already present.|  
|[CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md)|Sets information in a SACL. If a SACL is already present in the security descriptor, it is replaced.|  
|[CSecurityDesc::ToString](../vs140/csecuritydesc--tostring.md)|Converts a security descriptor to a string format.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSecurityDesc::operator const SECURITY_DESCRIPTOR *](../vs140/csecuritydesc--operator-const-security_descriptor--.md)|Returns a pointer to the **SECURITY_DESCRIPTOR** structure.|  
|[CSecurityDesc::operator =](../vs140/csecuritydesc--operator-=.md)|Assignment operator.|  
  
## Remarks  
 The **SECURITY_DESCRIPTOR** structure contains the security information associated with an object. Applications use this structure to set and query an object's security status. See also [AtlGetSecurityDescriptor](../vs140/atlgetsecuritydescriptor.md).  
  
 Applications should not modify the **SECURITY_DESCRIPTOR** structure directly, and instead should use the class methods provided.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="csecuritydesc__csecuritydesc">\</a>  CSecurityDesc::CSecurityDesc  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object or **SECURITY_DESCRIPTOR** structure to assign to the new <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object can optionally be created using a **SECURITY_DESCRIPTOR** structure or a previously defined <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
##  \<a name="csecuritydesc___dtorcsecuritydesc">\</a>  CSecurityDesc::~CSecurityDesc  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees all allocated resources.  
  
##  \<a name="csecuritydesc__fromstring">\</a>  CSecurityDesc::FromString  
 Converts a string-format security descriptor into a valid, functional security descriptor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the [string-format security descriptor](http://msdn.microsoft.com/library/windows/desktop/aa379570) to be converted.  
  
### Return Value  
 Returns true on success. Throws an exception on failure.  
  
### Remarks  
 The string can be created by using [CSecurityDesc::ToString](../vs140/csecuritydesc--tostring.md). Converting the security descriptor into a string makes it easier to store and transmit.  
  
 This method is only available with Windows 2000 and later because it calls [ConvertStringSecurityDescriptorToSecurityDescriptor](http://msdn.microsoft.com/library/windows/desktop/aa376401).  
  
##  \<a name="csecuritydesc__getcontrol">\</a>  CSecurityDesc::GetControl  
 Retrieves control information from the security descriptor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *psdc*  
 Pointer to a **SECURITY_DESCRIPTOR_CONTROL** structure that receives the security descriptor's control information.  
  
### Return Value  
 Returns true if the method succeeds, false if it fails.  
  
### Remarks  
 This method is only meaningful when using Windows 2000 or later, as it calls [GetSecurityDescriptorControl](http://msdn.microsoft.com/library/windows/desktop/aa446647).  
  
##  \<a name="csecuritydesc__getdacl">\</a>  CSecurityDesc::GetDacl  
 Retrieves discretionary access-control list (DACL) information from the security descriptor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Pointer to an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> structure in which to store a copy of the security descriptor's DACL. If a discretionary **ACL** exists, the method sets <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to the address of the security descriptor's discretionary **ACL**. If a discretionary **ACL** does not exist, no value is stored.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Pointer to a value that indicates the presence of a discretionary **ACL** in the specified security descriptor. If the security descriptor contains a discretionary **ACL**, this parameter is set to true. If the security descriptor does not contain a discretionary **ACL**, this parameter is set to false.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_DACL_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure if a discretionary **ACL** exists for the security descriptor. If this flag is true, the discretionary **ACL** was retrieved by a default mechanism; if false, the discretionary **ACL** was explicitly specified by a user.  
  
### Return Value  
 Returns true if the method succeeds, false if it fails.  
  
##  \<a name="csecuritydesc__getgroup">\</a>  CSecurityDesc::GetGroup  
 Retrieves the primary group information from the security descriptor.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Pointer to a [CSid](../vs140/csid-class.md) (security identifier) that receives a copy of the group stored in the CDacl.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_GROUP_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure when the method returns.  
  
### Return Value  
 Returns true if the method succeeds, false if it fails.  
  
##  \<a name="csecuritydesc__getowner">\</a>  CSecurityDesc::GetOwner  
 Retrieves owner informaton from the security descriptor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Pointer to a [CSid](../vs140/csid-class.md) (security identifier) that receives a copy of the group stored in the CDacl.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_OWNER_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure when the method returns.  
  
### Return Value  
 Returns true if the method succeeds, false if it fails.  
  
##  \<a name="csecuritydesc__getpsecurity_descriptor">\</a>  CSecurityDesc::GetPSECURITY_DESCRIPTOR  
 Returns a pointer to the **SECURITY_DESCRIPTOR** structure.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561) structure.  
  
##  \<a name="csecuritydesc__getsacl">\</a>  CSecurityDesc::GetSacl  
 Retrieves system access-control list (SACL) information from the security descriptor.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Pointer to an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> structure in which to store a copy of the security descriptor's SACL. If a system **ACL** exists, the method sets <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to the address of the security descriptor's system **ACL**. If a system **ACL** does not exist, no value is stored.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Pointer to a flag the method sets to indicate the presence of a system **ACL** in the specified security descriptor. If the security descriptor contains a system **ACL**, this parameter is set to true. If the security descriptor does not contain a system **ACL**, this parameter is set to false.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_SACL_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure if a system **ACL** exists for the security descriptor.  
  
### Return Value  
 Returns true if the method succeeds, false if it fails.  
  
##  \<a name="csecuritydesc__isdaclautoinherited">\</a>  CSecurityDesc::IsDaclAutoInherited  
 Determines if the discretionary access-control list (DACL) is configured to support automatic propagation.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a DACL which is set up to support automatic propagation of inheritable access-control entries (ACEs) to existing child objects. Returns false otherwise.  
  
### Remarks  
 The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.  
  
##  \<a name="csecuritydesc__isdacldefaulted">\</a>  CSecurityDesc::IsDaclDefaulted  
 Determines if the security descriptor is configured with a default discretionary access-control list (DACL).  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a default DACL, false otherwise.  
  
### Remarks  
 This flag can affect how the system treats the DACL, with respect to access-control entry (ACE) inheritance. For example, if an object's creator does not specify a DACL, the object receives the default DACL from the creator's access token. The system ignores this flag if the SE_DACL_PRESENT flag is not set.  
  
 This flag is used to determine how the final DACL on the object is to be computed and is not stored physically in the security descriptor control of the securable object.  
  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
##  \<a name="csecuritydesc__isdaclpresent">\</a>  CSecurityDesc::IsDaclPresent  
 Determines if the security descriptor contains a discretionary access-control list (DACL).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a DACL, false otherwise.  
  
### Remarks  
 If this flag is not set, or if this flag is set and the DACL is NULL, the security descriptor allows full access to everyone.  
  
 This flag is used to hold the security information specified by a caller until the security descriptor is associated with a securable object. Once the security descriptor is associated with a securable object, the SE_DACL_PRESENT flag is always set in the security descriptor control.  
  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
##  \<a name="csecuritydesc__isdaclprotected">\</a>  CSecurityDesc::IsDaclProtected  
 Determines if the discretionary access-control list (DACL) is configured to prevent modifications.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the DACL is configured to prevent the security descriptor from being modified by inheritable access-control entries (ACEs). Returns false otherwise.  
  
### Remarks  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
 This method is only meaningful for Windows 2000 or later, as only Windows 2000 supports automatic propagation of inheritable ACEs.  
  
##  \<a name="csecuritydesc__isgroupdefaulted">\</a>  CSecurityDesc::IsGroupDefaulted  
 Determines if the security descriptor's group security identifier (SID) was set by default.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if a default mechanism, rather than the original provider of the security descriptor, provided the security descriptor's group SID. Returns false otherwise.  
  
### Remarks  
 To set this flag, use the [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md) method.  
  
##  \<a name="csecuritydesc__isownerdefaulted">\</a>  CSecurityDesc::IsOwnerDefaulted  
 Determines if the security descriptor's owner security identifier (SID) was set by default.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if a default mechanism, rather than the original provider of the security descriptor, provided the security descriptor's owner SID. Returns false otherwise.  
  
### Remarks  
 To set this flag, use the [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md) method.  
  
##  \<a name="csecuritydesc__issaclautoinherited">\</a>  CSecurityDesc::IsSaclAutoInherited  
 Determines if the system access-control list (SACL) is configured to support automatic propagation.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a SACL which is set up to support automatic propagation of inheritable access-control entries (ACEs) to existing child objects. Returns false otherwise.  
  
### Remarks  
 The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.  
  
##  \<a name="csecuritydesc__issacldefaulted">\</a>  CSecurityDesc::IsSaclDefaulted  
 Determines if the security descriptor is configured with a default system access-control list (SACL).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a default SACL, false otherwise.  
  
### Remarks  
 This flag can affect how the system treats the SACL, with respect to access-control entry (ACE) inheritance. The system ignores this flag if the SE_SACL_PRESENT flag is not set.  
  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
##  \<a name="csecuritydesc__issaclpresent">\</a>  CSecurityDesc::IsSaclPresent  
 Determines if the security descriptor contains a system access-control list (SACL).  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor contains a SACL, false otherwise.  
  
### Remarks  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
##  \<a name="csecuritydesc__issaclprotected">\</a>  CSecurityDesc::IsSaclProtected  
 Determines if the system access-control list (SACL) is configured to prevent modifications.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the SACL is configured to prevent the security descriptor from being modified by inheritable access-control entries (ACEs). Returns false otherwise.  
  
### Remarks  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
 This method is only meaningful for Windows 2000 or later, as only Windows 2000 supports automatic propagation of inheritable ACEs.  
  
##  \<a name="csecuritydesc__isselfrelative">\</a>  CSecurityDesc::IsSelfRelative  
 Determines if the security descriptor is in self-relative format.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the security descriptor is in self-relative format with all the security information in a contiguous block of memory. Returns false if the security descriptor is in absolute format. For more information, see [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807).  
  
##  \<a name="csecuritydesc__makeabsolute">\</a>  CSecurityDesc::MakeAbsolute  
 Call this method to convert the security descriptor to absolute format.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the method succeeds, false otherwise.  
  
### Remarks  
 A security descriptor in absolute format contains pointers to the information it contains, rather than the information itself. A security descriptor in self-relative format contains the information in a contiguous block of memory. In a self-relative security descriptor, a **SECURITY_DESCRIPTOR** structure always starts the information, but the security descriptor's other components can follow the structure in any order. Instead of using memory addresses, the components of the self-relative security descriptor are identified by offsets from the beginning of the security descriptor. This format is useful when a security descriptor must be stored on a disk or transmitted by means of a communications protocol. For more information, see [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807).  
  
##  \<a name="csecuritydesc__makeselfrelative">\</a>  CSecurityDesc::MakeSelfRelative  
 Call this method to convert the security descriptor to self-relative format.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the method succeeds, false otherwise.  
  
### Remarks  
 A security descriptor in absolute format contains pointers to the information it contains, rather than containing the information itself. A security descriptor in self-relative format contains the information in a contiguous block of memory. In a self-relative security descriptor, a **SECURITY_DESCRIPTOR** structure always starts the information, but the security descriptor's other components can follow the structure in any order. Instead of using memory addresses, the components of the security descriptor are identified by offsets from the beginning of the security descriptor. This format is useful when a security descriptor must be stored on a disk or transmitted by means of a communications protocol. For more information, see [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807).  
  
##  \<a name="csecuritydesc__operator__eq">\</a>  CSecurityDesc::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The **SECURITY_DESCRIPTOR** structure or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object to assign to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
##  \<a name="csecuritydesc__operator_const_security_descriptor__star">\</a>  CSecurityDesc::operator const SECURITY_DESCRIPTOR *  
 Casts a value to a pointer to the **SECURITY_DESCRIPTOR** structure.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="csecuritydesc__setcontrol">\</a>  CSecurityDesc::SetControl  
 Sets the control bits of a security descriptor.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A **SECURITY_DESCRIPTOR_CONTROL** mask that indicates the control bits to set. For a list of the flags which can be set, see [SetSecurityDescriptorControl](http://msdn.microsoft.com/library/windows/desktop/aa379582\(v=vs.85\).aspx).  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>t  
 A <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> mask that indicates the new values for the control bits specified by the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> mask. This parameter can be a combination of the flags listed for the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 This method is available only on Windows 2000 and later, as it calls [SetSecurityDescriptorControl](http://msdn.microsoft.com/library/windows/desktop/aa379582\(v=vs.85\).aspx).  
  
##  \<a name="csecuritydesc__setdacl">\</a>  CSecurityDesc::SetDacl  
 Sets information in a discretionary access-control list (DACL). If a DACL is already present in the security descriptor, it is replaced.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *Dacl*  
 Reference to a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object specifying the DACL for the security descriptor. This parameter must not be NULL. To set a NULL DACL in the security descriptor, the first form of the method should be used with <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> set to false.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Specifies a flag indicating the presence of a DACL in the security descriptor. If this parameter is true, the method sets the SE_DACL_PRESENT flag in the **SECURITY_DESCRIPTOR_CONTROL** structure and uses the values in the *Dacl* and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameters. If it is false, the method clears the SE_DACL_PRESENT flag, and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is ignored.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies a flag indicating the source of the DACL. If this flag is true, the DACL has been retrieved by some default mechanism. If false, the DACL has been explicitly specified by a user. The method stores this value in the SE_DACL_DEFAULTED flag of the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is not specified, the SE_DACL_DEFAULTED flag is cleared.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 There is an important difference between an empty and a nonexistent DACL. When a DACL is empty, it contains no access-control entries and no access rights have been explicitly granted. As a result, access to the object is implicitly denied. When an object has no DACL, on the other hand, no protection is assigned to the object, and any access request is granted.  
  
##  \<a name="csecuritydesc__setgroup">\</a>  CSecurityDesc::SetGroup  
 Sets the primary group information of an absolute format security descriptor, replacing any primary group information already present.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Reference to a [CSid](../vs140/csid-class.md) object for the security descriptor's new primary group. This parameter must not be NULL. A security descriptor can be marked as not having a DACL or a SACL, but it must have a group and an owner, even it these are the NULL SID (which is a built-in SID with a special meaning).  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Indicates whether the primary group information was derived from a default mechanism. If this value is true, it is default information, and the method stores this value as the SE_GROUP_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is zero, the SE_GROUP_DEFAULTED flag is cleared.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="csecuritydesc__setowner">\</a>  CSecurityDesc::SetOwner  
 Sets the owner information of an absolute format security descriptor. It replaces any owner information already present.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object for the security descriptor's new primary owner. This parameter must not be NULL.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Indicates whether the owner information is derived from a default mechanism. If this value is true, it is default information. The method stores this value as the SE_OWNER_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is zero, the SE_OWNER_DEFAULTED flag is cleared.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="csecuritydesc__setsacl">\</a>  CSecurityDesc::SetSacl  
 Sets information in a system access-control list (SACL). If a SACL is already present in the security descriptor, it is replaced.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *Sacl*  
 Pointer to an <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object specifying the SACL for the security descriptor. This parameter must not be NULL, and must be a CSacl object. Unlike DACLs, there is no difference between NULL and an empty SACL, as SACL objects do not specify access rights, only auditing information.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies a flag indicating the source of the SACL. If this flag is true, the SACL has been retrieved by some default mechanism. If false, the SACL has been explicitly specified by a user. The method stores this value in the SE_SACL_DEFAULTED flag of the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is not specified, the SE_SACL_DEFAULTED flag is cleared.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="csecuritydesc__tostring">\</a>  CSecurityDesc::ToString  
 Converts a security descriptor to a string format.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string which will receive the [string-format security descriptor](http://msdn.microsoft.com/library/windows/desktop/aa379570).  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Specifies a combination of SECURITY_INFORMATION bit flags to indicate the components of the security descriptor to include in the output string.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 Once the security descriptor is in string format, it can more easily be stored or transmitted. Use the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> method to convert the string back into a security descriptor.  
  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> parameter can contain the following SECURITY_INFORMATION flags:  
  
|Value|Meaning|  
|-----------|-------------|  
|OWNER_SECURITY_INFORMATION|Include the owner.|  
|GROUP_SECURITY_INFORMATION|Include the primary group.|  
|DACL_SECURITY_INFORMATION|Include the DACL.|  
|SACL_SECURITY_INFORMATION|Include the SACL.|  
  
 If the DACL is NULL and the SE_DACL_PRESENT control bit is set in the input security descriptor, the method fails.  
  
 If the DACL is NULL and the SE_DACL_PRESENT control bit is not set in the input security descriptor, the resulting security descriptor string does not have a D: component. See [Security Descriptor String Format](http://msdn.microsoft.com/library/windows/desktop/aa379570) for more details.  
  
 This method is only available with Windows 2000 and later, as it calls [ConvertStringSecurityDescriptorToSecurityDescriptor](http://msdn.microsoft.com/library/windows/desktop/aa376401).  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)