---
title: "numeric_limits::epsilon"
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
  - "std.numeric_limits.epsilon"
  - "std::numeric_limits::epsilon"
  - "epsilon"
  - "numeric_limits.epsilon"
  - "numeric_limits::epsilon"
  - "limits/std::numeric_limits::epsilon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "epsilon method"
ms.assetid: e1d9f59d-dd3c-4bc1-bcef-afbdb466d357
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::epsilon
The function returns the difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
## Remarks  
 The value is FLT_EPSILON for type **float**. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for a type is the smallest positive floating-point number *N* such that *N* + <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> + *N* is representable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The difference between 1 and the smallest value greater than 1**  
 **for float objects is: 1.19209e-007**  
**The difference between 1 and the smallest value greater than 1**  
 **for double objects is: 2.22045e-016**  
**The difference between 1 and the smallest value greater than 1**  
 **for long double objects is: 2.22045e-016**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)