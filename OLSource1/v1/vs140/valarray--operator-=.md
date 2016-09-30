---
title: "valarray::operator|="
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
  - "std::valarray::operator|="
  - "std.valarray.operator|="
  - "valarray.operator|="
  - "valarray::operator|="
  - "|="
  - "operator|="
  - "valarray/std::valarray::operator|="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "|= operator"
  - "operator|="
ms.assetid: 01a9e549-ada8-44e2-b674-ed1e8b4e5913
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator|=
Obtains the bitwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of elements in an array either with the corresponding elements in a specified valarray or with a value of the element type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the bitwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise bitwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of the operand valarray by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **long double**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or other, more complex data types.  
  
 The bitwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> has the same truth table as the logical <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> but applies to the data type on the level of the individual bits. Given bits *b*1 and *b*2, *b*1 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> *b*2 is **true** if at least one of the bits is true; **false** if both bits are false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial operand valarray is:**  
 **( 1 0 1 0 1 0 1 0 1 0 ).**  
**The _Right valarray is:**  
 **( 0 0 1 3 3 4 6 6 7 9 ).**  
**The element-by-element result of the logical OR**  
 **operator&#124;= is the valarray:**  
 **( 1 0 1 3 3 4 7 6 7 9 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)