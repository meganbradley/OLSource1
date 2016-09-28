---
title: "CDacl Class"
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
  - "ATL::CDacl"
  - "CDacl"
  - "ATL.CDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDacl class"
ms.assetid: 2dc76616-6362-4967-b6cf-e2d39ca37ddd
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDacl Class
This class is a wrapper for a DACL (discretionary access-control list) structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CDacl : public CAcl  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDacl::CDacl](../vs140/cdacl--cdacl.md)|The constructor.|  
|[CDacl::~CDacl](../vs140/cdacl--~cdacl.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDacl::AddAllowedAce](../vs140/cdacl--addallowedace.md)|Adds an allowed ACE (access-control entry) to the `CDacl` object.|  
|[CDacl::AddDeniedAce](../vs140/cdacl--adddeniedace.md)|Adds a denied ACE to the `CDacl` object.|  
|[CDacl::GetAceCount](../vs140/cdacl--getacecount.md)|Returns the number of ACEs (access-control entries) in the `CDacl` object.|  
|[CDacl::RemoveAce](../vs140/cdacl--removeace.md)|Removes a specific ACE (access-control entry) from the `CDacl` object.|  
|[CDacl::RemoveAllAces](../vs140/cdacl--removeallaces.md)|Removes all of the ACEs contained in the `CDacl` object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CDacl::operator =](../vs140/cdacl--operator-=.md)|Assignment operator.|  
  
## Remarks  
 An object's security descriptor can contain a DACL. A DACL contains zero or more ACEs (access-control entries) that identify the users and groups who can access the object. If a DACL is empty (that is, it contains zero ACEs), no access is explicitly granted, so access is implicitly denied. However, if an object's security descriptor does not have a DACL, the object is unprotected and everyone has complete access.  
  
 To retrieve an object's DACL, you must be the object's owner or have READ_CONTROL access to the object. To change an object's DACL, you must have WRITE_DAC access to the object.  
  
 Use the class methods provided to create, add, remove, and delete ACEs from the `CDacl` object. See also [AtlGetDacl](../vs140/atlgetdacl.md) and [AtlSetDacl](../vs140/atlsetdacl.md).  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Inheritance Hierarchy  
 [CAcl](../vs140/cacl-class.md)  
  
 `CDacl`  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  <a name="cdacl__addallowedace"></a>  CDacl::AddAllowedAce  
 Adds an allowed ACE (access-control entry) to the `CDacl` object.  
  
```  
  
bool AddAllowedAce(  
      const CSid &  rSid,  
      ACCESS_MASK  AccessMask,  
      BYTE  AceFlags  
    = 0  
   ) throw(...);  
   bool AddAllowedAce(  
      const CSid &  rSid,  
      ACCESS_MASK  AccessMask,  
      BYTE  AceFlags,  
      const GUID *  pObjectType,  
      const GUID *  pInheritedObjectType  
   ) throw(...);  
  
```  
  
### Parameters  
 `rSid`  
 A [CSid](../vs140/csid-class.md) object.  
  
 `AccessMask`  
 Specifies the mask of access rights to be allowed for the specified `CSid` object.  
  
 `AceFlags`  
 A set of bit flags that control ACE inheritance.  
  
 `pObjectType`  
 The object type.  
  
 `pInheritedObjectType`  
 The inherited object type.  
  
### Return Value  
 Returns **true** if the ACE is added to the `CDacl` object,                         **false** on failure.  
  
### Remarks  
 A `CDacl` object contains zero or more ACEs (access-control entries) that identify the users and groups who can access the object. This method adds an ACE that allows access to the `CDacl` object.  
  
> [!NOTE]
>  The second form of `AddAllowedAce` is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the `AceFlags` parameter.  
  
##  <a name="cdacl__adddeniedace"></a>  CDacl::AddDeniedAce  
 Adds a denied ACE (access-control entry) to the `CDacl` object.  
  
```  
  
bool AddDeniedAce(  
      const CSid &  rSid,  
      ACCESS_MASK  AccessMask,  
      BYTE  AceFlags  
    = 0  
   ) throw(...);  
   bool AddDeniedAce(  
      const CSid &  rSid,  
      ACCESS_MASK  AccessMask,  
      BYTE  AceFlags,  
      const GUID *  pObjectType,  
      const GUID *  pInheritedObjectType  
   ) throw(...);  
  
```  
  
### Parameters  
 `rSid`  
 A `CSid` object.  
  
 `AccessMask`  
 Specifies the mask of access rights to be denied for the specified `CSid` object.  
  
 `AceFlags`  
 A set of bit flags that control ACE inheritance. Defaults to 0 in the first form of the method.  
  
 `pObjectType`  
 The object type.  
  
 `pInheritedObjectType`  
 The inherited object type.  
  
### Return Value  
 Returns **true** if the ACE is added to the `CDacl` object,                         **false** on failure.  
  
### Remarks  
 A `CDacl` object contains zero or more ACEs (access-control entries) that identify the users and groups who can access the object. This method adds an ACE that denies access to the `CDacl` object.  
  
> [!NOTE]
>  The second form of `AddDeniedAce` is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the `AceFlags` parameter.  
  
##  <a name="cdacl__cdacl"></a>  CDacl::CDacl  
 The constructor.  
  
```  
  
CDacl (  
      const ACL &  rhs  
   ) throw(...);  
   CDacl ( ) throw( );  
  
```  
  
### Parameters  
 `rhs`  
 An existing **ACL** (access-control list) structure.  
  
### Remarks  
 The `CDacl` object can be optionally created using an existing **ACL** structure. It is important to note that only a DACL (discretionary access-control list), and not a SACL (system access-control list), should be passed as this parameter. In debug builds, passing a SACL will cause an ASSERT. In release builds, passing a SACL will cause the ACEs (access-control entries) in the ACL to be ignored, and no error will occur.  
  
##  <a name="cdacl___dtorcdacl"></a>  CDacl::~CDacl  
 The destructor.  
  
```  
  
~CDacl ( ) throw( );  
  
```  
  
### Remarks  
 The destructor frees any resources acquired by the object, including all ACEs (access-control entries) using [CDacl::RemoveAllAces](../vs140/cdacl--removeallaces.md).  
  
##  <a name="cdacl__getacecount"></a>  CDacl::GetAceCount  
 Returns the number of ACEs (access-control entries) in the `CDacl` object.  
  
```  
  
UINT GetAceCount( ) const throw( );  
  
```  
  
### Return Value  
 Returns the number of ACEs contained in the `CDacl` object.  
  
##  <a name="cdacl__operator__eq"></a>  CDacl::operator =  
 Assignment operator.  
  
```  
  
CDacl & operator =(  
      const ACL &  rhs  
   ) throw(...);  
  
```  
  
### Parameters  
 `rhs`  
 The ACL (access-control list) to assign to the existing object.  
  
### Return Value  
 Returns a reference to the updated `CDacl` object.  
  
### Remarks  
 You should ensure that you only pass a DACL (discretionary access-control list) to this function. Passing a SACL (system access-control list) to this function will cause an ASSERT in debug builds but will cause no error in release builds.  
  
##  <a name="cdacl__removeace"></a>  CDacl::RemoveAce  
 Removes a specific ACE (access-control entry) from the `CDacl` object.  
  
```  
  
void RemoveAce(   
      UINT  nIndex   
   ) throw( );  
  
```  
  
### Parameters  
 `nIndex`  
 Index to the ACE entry to remove.  
  
### Remarks  
 This method is derived from [CAtlArray::RemoveAt](../vs140/catlarray--removeat.md).  
  
##  <a name="cdacl__removeallaces"></a>  CDacl::RemoveAllAces  
 Removes all of the ACEs (access-control entries) contained in the `CDacl` object.  
  
```  
  
void RemoveAllAces( ) throw( );  
  
```  
  
### Remarks  
 Removes every **ACE** (access-control entry) structure (if any) in the `CDacl` object.  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [CAcl Class](../vs140/cacl-class.md)   
 [ACLs](http://msdn.microsoft.com/library/windows/desktop/aa374872)   
 [ACEs](http://msdn.microsoft.com/library/windows/desktop/aa374868)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)