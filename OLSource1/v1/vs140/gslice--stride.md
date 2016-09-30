---
title: "gslice::stride"
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
  - "stride"
  - "gslice.stride"
  - "gslice::stride"
  - "std::gslice::stride"
  - "valarray/std::gslice::stride"
  - "std.gslice.stride"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stride method"
ms.assetid: e356ea07-6062-479a-87ff-3e986f46dd54
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gslice::stride
Finds the distance between elements in a general slice of a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A valarray specifying the distances between elements in each slice of a general slice of a valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is:**  
 **( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 ).**  
**The valarray for vaGSlice is vaResult:**  
 **va[vaGSlice] = ( 0 4 8 12 7 11 15 19 ).**  
**The strides of vaResult are:**  
 **vaGSlice.stride ( ) = ( 7 4 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [gslice Class](../vs140/gslice-class.md)