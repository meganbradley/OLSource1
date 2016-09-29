---
title: "AtlSetSacl"
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
  - "ATL.AtlSetSacl"
  - "ATL::AtlSetSacl"
  - "AtlSetSacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlSetSacl function"
ms.assetid: 54daab9a-8c69-45fd-86c4-18eb30d59547
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlSetSacl
Call this function to set the system access-control list (SACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      inline bool AtlSetSacl(  
HANDLE hObject,  
SE_OBJECT_TYPE ObjectType,  
const CSacl& rSacl,  
DWORD dwInheritanceFlowControl= 0,  
bool bRequestNeededPrivileges= true  
) throw(...);  
```  
  
#### Parameters  
 `hObject`  
 Handle to the object for which to set security information.  
  
 `ObjectType`  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the `hObject` parameter.  
  
 *rSacl*  
 The SACL containing the new security information.  
  
 `dwInheritanceFlowControl`  
 The inheritance flow control. This value can be 0 (the default), PROTECTED_SACL_SECURITY_INFORMATION or UNPROTECTED_SACL_SECURITY_INFORMATION.  
  
 `bRequestNeededPrivileges`  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if `hObject` is invalid, or if `dwInheritanceFlowControl` is not one of the three permitted values.  
  
 If `AtlSetSacl` is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with `bRequestNeededPrivileges` set to false.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlGetSacl](../vs140/atlgetsacl.md)   
 [CSacl Class](../vs140/csacl-class.md)