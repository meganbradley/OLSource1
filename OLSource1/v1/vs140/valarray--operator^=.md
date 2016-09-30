---
title: "valarray::operator^="
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
  - "std.valarray.operator^="
  - "valarray/std::valarray::operator^="
  - "valarray::operator^="
  - "valarray.operator^="
  - "^="
  - "std::valarray::operator^="
  - "operator^="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "^= operator, with specific standard C++ objects"
  - "operator^="
ms.assetid: 0cefc10d-f6a0-4693-8b70-163cd53dd6f4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator^=
Obtains the element-wise exclusive logical or operator (**XOR**) of an array with either a specified valarray or a value of the element type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the exclusive logical **XOR** with the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise, exclusive logical **XOR** of the operand valarray and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Remarks  
 The exclusive logical or, referred to as **XOR**, has the following semantics: Given elements *e*1 and *e*2, *e*1 **XOR** *e*2 is **true** if exactly one of the elements is true; **false** if both elements are false or if both elements are true.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial operand valarray is:  ( 1 0 1 0 1 0 1 0 1 0 ).**  
**The _Right valarray is: ( 0 0 1 3 3 4 6 6 7 9 ).**  
**The element-by-element result of the bitwise XOR operator^= is the**  
 **valarray: ( 1 0 0 3 2 4 7 6 6 9 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)