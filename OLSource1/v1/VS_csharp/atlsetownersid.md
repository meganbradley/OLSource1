---
title: "AtlSetOwnerSid"
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
  - "ATL.AtlSetOwnerSid"
  - "AtlSetOwnerSid"
  - "ATL::AtlSetOwnerSid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlSetOwnerSid function"
ms.assetid: 3a8abb76-1d2c-465d-a5e8-62a12a3c37f3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlSetOwnerSid
Call this function to set the owner security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      inline bool AtlSetOwnerSid(  
HANDLE hObject,  
SE_OBJECT_TYPE ObjectType,  
const CSid& rSid  
) throw(...);  
```  
  
#### Parameters  
 `hObject`  
 Handle to the object for which to set security information.  
  
 `ObjectType`  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the `hObject` parameter.  
  
 `rSid`  
 The `CSid` object containing the new security information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../VS_csharp/security-global-functions.md)   
 [AtlGetOwnerSid](../VS_csharp/atlgetownersid.md)   
 [CSid Class](../VS_csharp/csid-class.md)