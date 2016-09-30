---
title: "basic_string::data"
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
  - "std::basic_string::data"
  - "std.basic_string.data"
  - "basic_string::data"
  - "data"
  - "xstring/std::basic_string::data"
  - "Data"
  - "basic_string.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data method"
ms.assetid: 5f705a86-6ad6-454e-824a-73af9984e9a0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::data
Converts the contents of a string into an array of characters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the first element of the array containing the contents of the string, or, for an empty array, a non-null pointer that cannot be dereferenced.  
  
## Remarks  
 Objects of type string belonging to the C++ template class basic_string \<char> are not necessarily null terminated. The return type for **data** is not a valid C-string, because no null character gets appended. The null character ' \0 ' is used as a special character in a C-string to mark the end of the string, but has no special meaning in an object of type string and may be a part of the string object just like any other character.  
  
 There is an automatic conversion from const **char\*** into strings, but the string class does not provide for automatic conversions from C-style strings to objects of type **basic_string \<char>**.  
  
 The returned string should not be modified, because this could invalidate the pointer to the string, or deleted, because the string has a limited lifetime and is owned by the class string.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string object str1 is: Hello world**  
**The length of the string object str1 = 11**  
**The modified string object ptr1 is: Hello world**  
**The length of character array str1 = 11**  
**The C-style string c_str1 is: Hello world**  
**The length of C-style string str1 = 11**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)