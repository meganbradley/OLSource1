---
title: "cosh (&lt;valarray&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cosh"
  - "std::cosh"
  - "valarray/std::cosh"
  - "std.cosh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cosh function"
ms.assetid: fd82b7d3-f594-435b-8b2c-6e267e9d9ebd
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cosh (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the hyperbolic cosine of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the hyperbolic cosine of the elements of the input valarray.  
  
## Remarks  
 Identities defining the hyperbolic cosine in terms of exponential function:  
  
 cosh ( *z* ) = ( exp ( *z* ) + exp ( -*z* ) ) / 2  
  
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
**The hyperbolic cosine of the initial valarray is:**  
**11.592**  
**5.32275**  
**2.50918**  
**1.32461**  
**1**  
**1.32461**  
**2.50918**  
**5.32275**  
**11.592**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std