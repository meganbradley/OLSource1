---
title: "char_traits::assign"
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
  - "std::char_traits::assign"
  - "assign"
  - "char_traits::assign"
  - "std.char_traits.assign"
  - "Assign"
  - "iosfwd/std::char_traits::assign"
  - "char_traits.assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: e0b94ff6-198a-42d3-b6c6-2d15b812e26e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::assign
Assigns one character value to another or to a range of elements in a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **_** *CharFrom*  
 The character whose value is to be assigned.  
  
 *_CharTo*  
 The element that is to be assigned the character value.  
  
 *_StrTo*  
 The string or character array whose initial elements are to be assigned character values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements that are going to be assigned values.  
  
## Return Value  
 The second member function returns a pointer to the string whose first <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements have been assigned values of *_CharFrom*.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial characters ( ChTo , ChFrom ) are: ( t , f ).**  
**After assigning, the characters ( ChTo , ChFrom ) are: ( f , f ).**  
**The target string s1 is: abcd-1234-abcd**  
**The result1 = assign ( s1 , 4 , 'f' ) is: ffff-1234-abcd**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)