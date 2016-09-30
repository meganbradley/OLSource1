---
title: "operator^"
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
  - "std::^"
  - "valarray/std::operator^"
  - "operator^"
  - "std.operator^"
  - "std::operator^"
  - "std.^"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "^ operator, valarrays"
  - "operator^"
ms.assetid: e5716a0c-ffa5-42b9-800f-dafc09f5e09c
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator^
Obtains the bitwise exclusive <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (**XOR**) between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise combination of the bitwise **XOR** operation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or other, more complex data types.  
  
 The bitwise exclusive <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (**XOR**) has the following semantics: Given bits *b*1 and *b*2, *b*1 **XOR** *b*2 is **true** if exactly one of the bits is true; **false** if both bits are false or if both bits are true.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial Left valarray is:  ( 1 0 1 0 1 0 1 0 1 0 ).**  
**The initial Right valarray is: ( 0 0 1 3 3 4 6 6 7 9 ).**  
**The element-by-element result of the bitwise XOR operator^ is the**  
 **valarray: ( 1 0 0 3 2 4 7 6 6 9 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std