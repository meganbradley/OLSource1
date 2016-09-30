---
title: "AtlGetSacl"
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
  - "AtlGetSacl"
  - "ATL::AtlGetSacl"
  - "ATL.AtlGetSacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetSacl function"
ms.assetid: 1d69611f-d8a7-467b-9d57-cbe2f1610bf8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetSacl
Call this function to retrieve the system access-control list (SACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the object from which to retrieve the security information.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a SACL object which will contain the retrieved security information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> set to false.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlSetSacl](../vs140/atlsetsacl.md)   
 [CSacl Class](../vs140/csacl-class.md)