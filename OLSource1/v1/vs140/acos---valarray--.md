---
title: "acos (&lt;valarray&gt;)"
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
  - "valarray/std::acos"
  - "std.acos"
  - "acos"
  - "std::acos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acos function"
ms.assetid: 57d3c499-0c9a-475d-90c8-53b36800c370
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# acos (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the arccosine of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the arccosine of the elements of the input valarray.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between 0 and +pi that is consistent with the cosine value input.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is: -1 -0.75 -0.5 -0.25 0 0.25 0.5 0.75 1**  
**The arccosine of the initial valarray is:**  
 **3.14159  radians, which is          180  degrees**  
 **2.41886  radians, which is       138.59  degrees**  
 **2.0944  radians, which is          120  degrees**  
 **1.82348  radians, which is      104.478  degrees**  
 **1.5708  radians, which is           90  degrees**  
 **1.31812  radians, which is      75.5225  degrees**  
 **1.0472  radians, which is           60  degrees**  
 **0.722734  radians, which is      41.4096  degrees**  
 **0  radians, which is            0  degrees**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std