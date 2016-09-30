---
title: "valarray::operator"
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
  - "valarray/std::valarray::operator[]"
  - "[]"
  - "operator[]"
  - "std::valarray::operator[]"
  - "valarray.operator[]"
  - "valarray::operator[]"
  - "std.valarray.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], valarrays"
  - "operator[], valarrays"
  - "[] operator, with specific standard C++ objects"
ms.assetid: c1750085-b0a7-474b-aed9-0f3b38b3a6a0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator
Returns a reference to an element or its value at specified index or a specified subset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the element to be assigned a value.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A slice_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A gslice_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 *_Boolarray*  
 A bool_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An indirect_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
## Return Value  
 A reference to an element or its value at specified index or a specified subset.  
  
## Remarks  
 The member operator is overloaded to provide several ways to select sequences of elements from among those controlled by *\****this**. The first group of five member operators work in conjunction with various overloads of [operator=](../vs140/valarray--operator=.md) (and other assigning operators) to allow selective replacement (slicing) of the controlled sequence. The selected elements must exist.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the valarray.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
 See the examples for [slice::slice](../vs140/slice--slice.md) and [gslice::gslice](../vs140/gslice--gslice.md) for an example of how to declare and use the operator.  
  
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)