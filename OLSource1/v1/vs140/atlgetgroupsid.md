---
title: "AtlGetGroupSid"
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
  - "ATL.AtlGetGroupSid"
  - "ATL::AtlGetGroupSid"
  - "AtlGetGroupSid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetGroupSid function"
ms.assetid: 8e7ec6b9-15c8-4a8a-977e-1e4c853d0be7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetGroupSid
Call this function to retrieve the group security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the object from which to retrieve security information.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object which will contain the new security information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlSetGroupSid](../vs140/atlsetgroupsid.md)   
 [CSid Class](../vs140/csid-class.md)