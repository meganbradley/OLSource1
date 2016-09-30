---
title: "char_traits::to_int_type"
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
  - "std.char_traits.to_int_type"
  - "to_int_type"
  - "char_traits.to_int_type"
  - "iosfwd/std::char_traits::to_int_type"
  - "std::char_traits::to_int_type"
  - "char_traits::to_int_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_int_type method"
  - "to_int_type typedef"
ms.assetid: 76a73bd5-5bcf-4f46-86a9-fb17688644b8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::to_int_type
Converts a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> character and returns the result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> character to be represented as an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> character corresponding to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> character.  
  
## Remarks  
 The conversion operations <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and [to_char_type](../vs140/char_traits--to_char_type.md) are inverse to each other, so that:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ( *x* ) ) == *x*  
  
 for any <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *x*, and  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> ( *x* ) ) == *x*  
  
 for any <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> *x*.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The char_types and corresponding int_types are:**  
 **ch1 = a corresponding to int1 = 97.**  
 **ch2 = b corresponding to int1 = 98.**  
 **ch3 = a corresponding to int1 = 97.**  
**The recovered char_types and corresponding int_types are:**  
 **recovered ch1 = a from int1 = 97.**  
 **recovered ch2 = b from int2 = 98.**  
**The recovered char_type of ch1 is equal to the original ch1.**  
**The recovered char_type of ch2 is equal to the original ch2.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)