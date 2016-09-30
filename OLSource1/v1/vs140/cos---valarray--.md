---
title: "cos (&lt;valarray&gt;)"
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
  - "cos"
  - "valarray/std::cos"
  - "std.cos"
  - "std::cos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cos function"
ms.assetid: c1520074-c863-4206-b36b-b6cf5ffee76d
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cos (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the cosine of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is:**  
 **-3.14159  radians, which is   -180  degrees**  
 **-2.35619  radians, which is   -135  degrees**  
 **-1.5708  radians, which is    -90  degrees**  
 **-0.785398  radians, which is    -45  degrees**  
 **0  radians, which is      0  degrees**  
 **0.785398  radians, which is     45  degrees**  
 **1.5708  radians, which is     90  degrees**  
 **2.35619  radians, which is    135  degrees**  
 **3.14159  radians, which is    180  degrees**  
**The cosine of the initial valarray is:**  
**-1**  
**-0.707107**  
**-1.03412e-013**  
**0.707107**  
**1**  
**0.707107**  
**-1.03412e-013**  
**-0.707107**  
**-1**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [Trigonometry Functions](../vs140/trigonometry-functions.md)