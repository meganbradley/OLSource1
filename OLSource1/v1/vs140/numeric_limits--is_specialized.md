---
title: "numeric_limits::is_specialized"
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
  - "is_specialized"
  - "numeric_limits::is_specialized"
  - "std::numeric_limits::is_specialized"
  - "limits/std::numeric_limits::is_specialized"
  - "numeric_limits.is_specialized"
  - "std.numeric_limits.is_specialized"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_specialized method"
ms.assetid: 2c40c3ce-526b-4e06-aa22-1da809e8ae21
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_specialized
Tests if a type has an explicit specialization defined in the template class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **true** if the type has an explicit specialization defined in the template class; **false** if not.  
  
## Remarks  
 All scalar types other than pointers have an explicit specialization defined for template class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Whether float objects have an explicit specialization in the class: 1**  
**Whether float\* objects have an explicit specialization in the class: 0**  
**Whether int objects have an explicit specialization in the class: 1**  
**Whether int\* objects have an explicit specialization in the class: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)