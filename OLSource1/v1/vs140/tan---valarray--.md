---
title: "tan (&lt;valarray&gt;)"
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
  - "tan"
  - "std::tan"
  - "std.tan"
  - "valarray/std::tan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tan function"
  - "calculating tangents"
ms.assetid: 471c465d-71d1-4c6a-8d2e-56b380c0021d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tan (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the tangent of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the tangent of the elements of the input valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is:**  
 **-1.5708     radians, which is     -90   degrees**  
 **-1.1781     radians, which is   -67.5   degrees**  
 **-0.785398     radians, which is     -45   degrees**  
 **-0.392699     radians, which is   -22.5   degrees**  
 **0     radians, which is       0   degrees**  
 **0.392699     radians, which is    22.5   degrees**  
 **0.785398     radians, which is      45   degrees**  
 **1.1781     radians, which is    67.5   degrees**  
 **1.5708     radians, which is      90   degrees**  
**The tangent of the initial valarray is:**  
 **9.6701e+012**  
**-2.41421**  
**-1**  
**-0.414214**  
**0**  
**0.414214**  
**1**  
**2.41421**  
**-9.6701e+012**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [Trigonometry Functions](../vs140/trigonometry-functions.md)