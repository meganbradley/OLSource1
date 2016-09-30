---
title: "valarray::valarray"
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
  - "std::valarray::valarray"
  - "valarray/std::valarray::valarray"
  - "valarray"
  - "std.valarray.valarray"
  - "valarray::valarray"
  - "valarray.valarray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "valarray class, constructor"
  - "valarray method"
ms.assetid: 02fe09e6-4e9c-4c19-a950-287f335392ca
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::valarray
Constructs a valarray of a specific size or with elements of a specific value or as a copy of another valarray or subset of another valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements to be in the valarray.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to be used in initializing the elements in the valarray.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the values to be used to initialize the elements in the valarray.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An existing valarray to initialize the new valarray.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A slice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A gslice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A mask_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A indirect_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The initializer_list containing the elements to copy.  
  
## Remarks  
 The first (default) constructor initializes the object to an empty array. The next three constructors each initialize the object to an array of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements as follows:  
  
-   For explicit <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, each element is initialized with the default constructor.  
  
-   For <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, each element is initialized with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   For <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the element at position <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is initialized with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>].  
  
 Each remaining constructor initializes the object to a valarray\<Type> object determined by the subset specified in the argument.  
  
 The last constructor is the same as the next to last, but with an [rvalue reference](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is:( 0 2 2 2 2 2 2 2 2 2 )The new valarray initialized from the slice is vaSlice =va[slice( 2, 4, 3)] = ( 0 0 0 )1 2 3 4**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)