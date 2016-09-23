---
title: "AtlGetSacl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - AtlGetSacl
  - ATL::AtlGetSacl
  - ATL.AtlGetSacl
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlGetSacl function
ms.assetid: 1d69611f-d8a7-467b-9d57-cbe2f1610bf8
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlGetSacl
Call this function to retrieve the system access-control list (SACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      inline bool AtlGetSacl(  
HANDLE hObject,  
SE_OBJECT_TYPE ObjectType,  
CSacl* pSacl,  
bool bRequestNeededPrivileges= true  
) throw(...);  
```  
  
#### Parameters  
 `hObject`  
 Handle to the object from which to retrieve the security information.  
  
 `ObjectType`  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the `hObject` parameter.  
  
 `pSacl`  
 Pointer to a SACL object which will contain the retrieved security information.  
  
 `bRequestNeededPrivileges`  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 If `AtlGetSacl` is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with `bRequestNeededPrivileges` set to false.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlSetSacl](../vs140/atlsetsacl.md)   
 [CSacl Class](../vs140/csacl-class.md)