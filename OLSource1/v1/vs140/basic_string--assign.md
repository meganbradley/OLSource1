---
title: "basic_string::assign"
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
  - "basic_string::assign"
  - "basic_string.assign"
  - "assign"
  - "Assign"
  - "std.basic_string.assign"
  - "xstring/std::basic_string::assign"
  - "std::basic_string::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: fc864882-6e04-4c3a-9a1e-c78f0f1ea8ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::assign
Assigns new character values to the contents of a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the characters of the C-string to be assigned to the target string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of characters to be appended, at most, from the source string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source string whose characters are to be assigned to the target string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The character value to be assigned.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first character in the range of the source string to be assigned to the target range.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the one beyond the last character in the range of the source string to be assigned to the target range.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The position at which new characters will start to be assigned.  
  
## Return Value  
 A reference to the string object that is being assigned new characters by the member function.  
  
## Remarks  
 The strings can be assigned new character values. The new value can be either a string and C-string or a single character. The [operator=](../vs140/basic_string--operator=.md) may be used if the new value can be described by a single parameter; otherwise the member function **assign**, which has multiple parameters, can be used to specify which part of the string is to be assigned to a target string.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The C-string cstr1a is: Out There.**  
**Assigning the C-string cstr1a to string str1 gives: Out There.**  
**The C-string cstr1b is: Out There**  
**Assigning the 1st part of the C-string cstr1b to string str1 gives: Out.**  
**The string str2c is: Wide World**   
**The newly assigned string str1 is: World.**  
**The original string str1 is: Hello.**  
**The string str2d is: Wide**  
**The string str1 newly assigned with string str2d is: Wide.**  
**The string str3d is: World.**  
**The string str1 reassigned with string str3d is: World.**  
**The string str1 assigned with eclamations is: !!!!**  
**The string str2f is: Wide World**   
**The string str1 assigned a range of string str2f is: World.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)