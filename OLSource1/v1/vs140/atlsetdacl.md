---
title: "AtlSetDacl"
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
  - "AtlSetDacl"
  - "ATL.AtlSetDacl"
  - "ATL::AtlSetDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlSetDacl function"
ms.assetid: eb88ccb6-1f1b-444d-b0c9-8d5cd0dd6c0b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlSetDacl
Call this function to set the discretionary access-control list (DACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      inline bool AtlSetDacl(  
HANDLE hObject,  
SE_OBJECT_TYPE ObjectType,  
const CDacl& rDacl,  
DWORD dwInheritanceFlowControl= 0  
) throw(...);  
```  
  
#### Parameters  
 `hObject`  
 Handle to the object for which to set security information.  
  
 `ObjectType`  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the `hObject` parameter.  
  
 `rDacl`  
 The DACL containing the new security information.  
  
 `dwInheritanceFlowControl`  
 The inheritance flow control. This value can be 0 (the default), PROTECTED_DACL_SECURITY_INFORMATION or UNPROTECTED_DACL_SECURITY_INFORMATION.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if `hObject` is invalid, or if `dwInheritanceFlowControl` is not one of the three permitted values.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlGetDacl](../vs140/atlgetdacl.md)   
 [CDacl Class](../vs140/cdacl-class.md)