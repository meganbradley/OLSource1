---
title: "atan (&lt;valarray&gt;)"
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
  - "atan"
  - "valarray/std::atan"
  - "std.atan"
  - "std::atan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atan function"
ms.assetid: 100989a8-edd0-462f-992f-e167f85f3b29
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atan (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the principal value of the arctangent of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the arctangent of the elements of the input valarray.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between +pi/2 and –pi/2 that is consistent with the tangent value input.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is: -100 -3.75 -2.5 -1.25 0 1.25 2.5 3.75 100 .**  
**The arcsine of the initial valarray is:**  
 **-1.5608  radians, which is     -89.4271  degrees**  
 **-1.31019  radians, which is     -75.0686  degrees**  
 **-1.19029  radians, which is     -68.1986  degrees**  
 **-0.896055  radians, which is     -51.3402  degrees**  
 **0  radians, which is            0  degrees**  
 **0.896055  radians, which is      51.3402  degrees**  
 **1.19029  radians, which is      68.1986  degrees**  
 **1.31019  radians, which is      75.0686  degrees**  
 **1.5608  radians, which is      89.4271  degrees**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std