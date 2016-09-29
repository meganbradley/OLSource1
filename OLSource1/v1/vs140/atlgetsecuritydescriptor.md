---
title: "AtlGetSecurityDescriptor"
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
  - "AtlGetSecurityDescriptor"
  - "ATL::AtlGetSecurityDescriptor"
  - "ATL.AtlGetSecurityDescriptor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetSecurityDescriptor function"
ms.assetid: 233578b8-dcc5-4f51-8e62-7cdcc2ff6b11
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetSecurityDescriptor
Call this function to retrieve the security descriptor of a given object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      inline bool AtlGetSecurityDescriptor(  
LPCTSTR pszObjectName,  
SE_OBJECT_TYPE ObjectType,  
CSecurityDesc * pSecurityDescriptor,  
SECURITY_INFORMATION requestedInfo= OWNER_SECURITY_INFORMATION |   
GROUP_SECURITY_INFORMATION | DACL_SECURITY_INFORMATION |   
SACL_SECURITY_INFORMATION,  
bool bRequestNeededPrivileges= true  
) throw(...);  
```  
  
#### Parameters  
 *pszObjectName*  
 Pointer to a null-terminated string that specifies the name of the object from which to retrieve security information.  
  
 `ObjectType`  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the *pszObjectName* parameter.  
  
 *pSecurityDescriptor*  
 The object which receives the requested security descriptor.  
  
 *requestedInfo*  
 A set of [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags that indicate the type of security information to retrieve. This parameter can be a combination of the following values.  
  
 `bRequestNeededPrivileges`  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 If `AtlGetSecurityDescriptor` is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with `bRequestNeededPrivileges` set to false.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)