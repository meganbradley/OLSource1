---
title: "asin (&lt;valarray&gt;)"
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
  - "valarray/std::asin"
  - "asin"
  - "std::asin"
  - "std.asin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asin function"
ms.assetid: cbbcb0c1-db60-4048-94f8-c8d89e8b167d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asin (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the arcsine of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the arcsine of the elements of the input valarray.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between +pi/2 and –pi/2 that is consistent with the sine value input.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is: -1 -0.75 -0.5 -0.25 0 0.25 0.5 0.75 1**  
**The arcsine of the initial valarray is:**  
 **-1.5708  radians, which is          -90  degrees**  
 **-0.848062  radians, which is     -48.5904  degrees**  
 **-0.523599  radians, which is          -30  degrees**  
 **-0.25268  radians, which is     -14.4775  degrees**  
 **0  radians, which is            0  degrees**  
 **0.25268  radians, which is      14.4775  degrees**  
 **0.523599  radians, which is           30  degrees**  
 **0.848062  radians, which is      48.5904  degrees**  
 **1.5708  radians, which is           90  degrees**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std