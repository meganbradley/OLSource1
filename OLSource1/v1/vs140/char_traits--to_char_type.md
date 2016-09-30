---
title: "char_traits::to_char_type"
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
  - "std.char_traits.to_char_type"
  - "iosfwd/std::char_traits::to_char_type"
  - "std::char_traits::to_char_type"
  - "char_traits::to_char_type"
  - "to_char_type"
  - "char_traits.to_char_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_char_type typedef"
  - "to_char_type method"
ms.assetid: 2b9e8fd8-7da5-4eea-964a-f68b4284bda9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::to_char_type
Converts an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> character and returns the result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> character to be represented as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> character corresponding to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> character.  
  
 A value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that cannot be represented as such yields an unspecified result.  
  
## Remarks  
 The conversion operations [to_int_type](../vs140/char_traits--to_int_type.md) and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are inverse to each other, so that:  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> ( *x* ) ) == *x*  
  
 for any <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> *x* and  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> ( *x* ) ) == *x*  
  
 for any <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> *x*.  
  
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