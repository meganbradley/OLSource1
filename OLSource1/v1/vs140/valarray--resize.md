---
title: "valarray::resize"
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
  - "Resize"
  - "std.valarray.resize"
  - "valarray/std::valarray::resize"
  - "resize"
  - "valarray::resize"
  - "valarray.resize"
  - "std::valarray::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 33d9f421-43f0-4630-b08d-f56b0b76f70b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::resize
Changes the number of elements in a valarray to a specified number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements in the resized valarray.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to be given to the elements of the resized valarray.  
  
## Remarks  
 The first member function initializes elements with their default constructor.  
  
 Any pointers or references to elements in the controlled sequence are invalidated.  
  
## Example  
 The following example demonstrates the use of the valarray::resize member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The valarray contains ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The number of elements in the valarray is: 10.**  
**The valarray contains ( 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 ).**  
**The number of elements in the resized valarray is: 15.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)