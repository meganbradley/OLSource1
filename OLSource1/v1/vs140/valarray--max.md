---
title: "valarray::max"
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
  - "std.valarray.max"
  - "valarray::max"
  - "std::valarray::max"
  - "max"
  - "valarray.max"
  - "valarray/std::valarray::max"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max function"
  - "max method"
ms.assetid: 1be6ba74-99dc-4b91-80e3-aae663de2002
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::max
Finds the largest element in a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The maximum value of the elements in the operand valarray.  
  
## Remarks  
 The member function compares values by applying **operator\<** or **operator>** between pairs of elements of class **Type**, for which operators must be provided for the element **Type**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray is: ( 0 1 8 3 7 5 6 13 2 9 ).**  
**The largest element in the valarray is: 13.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)