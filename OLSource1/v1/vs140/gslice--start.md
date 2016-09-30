---
title: "gslice::start"
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
  - "Start"
  - "valarray/std::gslice::start"
  - "gslice::start"
  - "std.gslice.start"
  - "start"
  - "gslice.start"
  - "std::gslice::start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "start method"
ms.assetid: d16aaaac-07b5-4961-8d79-441e2ad14942
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gslice::start
Finds the starting index of a general slice of a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The starting index of a general slice of a valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is:**  
 **( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 ).**  
**The valarray for vaGSlice is vaResult:**  
 **va[vaGSlice] = ( 0 4 8 12 7 11 15 19 ).**  
**The index of the first element of vaResult is: 0.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)