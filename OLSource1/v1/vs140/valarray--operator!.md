---
title: "valarray::operator!"
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
  - "!"
  - "valarray/std::valarray::operator!"
  - "valarray::operator!"
  - "std::valarray::operator!"
  - "operator!"
  - "std.valarray.operator!"
  - "valarray.operator!"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "! operator"
  - "operator !, valarrays"
  - "operator!, valarrays"
ms.assetid: 26d14a45-d2ac-4e38-9f7a-3b6e74d75430
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator!
A unary operator that obtains the logical **NOT** values of each element in a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The valarray of Boolean values that are the negation of the element values of the operand valarray.  
  
## Remarks  
 The logical operation **NOT** negates the elements because it converts all zeros into ones and regards all nonzero values as ones and converts them into zeros. The returned valarray of Boolean values is of the same size as the operand valarray.  
  
 There is also a bitwise **NOT** [valarray::operator~](../vs140/valarray--operator~.md) that negates on the level of individual bits within the binary representation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements of a valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is:  ( 0 0 0 2 0 4 0 6 0 8 ).**  
**The element-by-element result of the logical NOT operator! is the**  
 **valarray: ( 1 1 1 0 1 0 1 0 1 0 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)