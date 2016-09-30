---
title: "ios_base::unsetf"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ios_base.unsetf"
  - "ios_base::unsetf"
  - "xiosbase/std::ios_base::unsetf"
  - "std::ios_base::unsetf"
  - "std.ios_base.unsetf"
  - "unsetf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsetf method"
ms.assetid: c363bae8-62f7-40d5-8453-f5210e948668
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::unsetf
Causes the specified flags to be off.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The flags that you want off.  
  
## Remarks  
 The member function effectively calls [flags](../vs140/ios_base--flags.md)(<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>*_Mask* **& flags**) (clear selected bits).  
  
## Example  
 See [ios_base::setf](../vs140/ios_base--setf.md) for a sample of using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)