---
title: "char_traits::eq_int_type"
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
  - "char_traits.eq_int_type"
  - "iosfwd/std::char_traits::eq_int_type"
  - "eq_int_type"
  - "std::char_traits::eq_int_type"
  - "char_traits::eq_int_type"
  - "std.char_traits.eq_int_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "eq_int_type typedef"
  - "eq_int_type method"
ms.assetid: 5541a455-abb5-49de-b562-2ff8eaa86855
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::eq_int_type
Tests whether two characters represented as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>s are equal or not.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The first of the two characters to be tested for equality as **int_type**s.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The second of the two characters to be tested for equality as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s.  
  
## Return Value  
 **true** if the first character is equal to the second character; otherwise **false**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The char_types and corresponding int_types are:**  
 **ch1 = x corresponding to int1 = 120.**  
 **ch2 = y corresponding to int1 = 121.**  
 **ch3 = x corresponding to int1 = 120.**  
**The int_type representation of character ch1**  
 **is not equal to the int_type representation of ch2.**  
**The int_type representation of character ch1**  
 **is equal to the int_type representation of ch3.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)