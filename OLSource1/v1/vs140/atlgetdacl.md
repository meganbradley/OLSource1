---
title: "AtlGetDacl"
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
  - "ATL::AtlGetDacl"
  - "AtlGetDacl"
  - "ATL.AtlGetDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetDacl function"
ms.assetid: a0973648-0d46-4c1a-914f-bda861fe5d19
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetDacl
Call this function to retrieve the discretionary access-control list (DACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the object for which to retrieve the security information.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a value from the [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a DACL object which will contain the retrieved security information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if either <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is invalid*.*  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Global Functions](../vs140/security-global-functions.md)   
 [AtlSetDacl](../vs140/atlsetdacl.md)   
 [CDacl Class](../vs140/cdacl-class.md)