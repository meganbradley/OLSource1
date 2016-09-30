---
title: "char_traits::compare"
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
  - "iosfwd/std::char_traits::compare"
  - "Compare"
  - "char_traits::compare"
  - "std.char_traits.compare"
  - "char_traits.compare"
  - "std::char_traits::compare"
  - "compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method"
ms.assetid: ba7b0d89-7d15-499e-ba26-743b68d11520
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::compare
Compares up to a specified number of characters in two strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *_Str1*  
 The first of two strings to be compared to each other.  
  
 *_Str2*  
 The second of two strings to be compared to each other.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of elements in the strings to be compared.  
  
## Return Value  
 A negative value if the first string is less than the second string, 0 if the two strings are equal, or a positive value if the first string is greater than the second string.  
  
## Remarks  
 The comparison between the strings is made element by element, first testing for equality and then, if a pair of elements in the sequence tests not equal, they are tested for less than.  
  
 If two strings compare equal over a range but one is longer than the other, then the shorter of the two is less than the longer one.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)