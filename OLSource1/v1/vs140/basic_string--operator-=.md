---
title: "basic_string::operator+="
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
  - "operator+="
  - "basic_string.operator+="
  - "std.basic_string.operator+="
  - "+="
  - "std::basic_string::operator+="
  - "xstring/std::basic_string::operator+="
  - "basic_string::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator, appending strings"
  - "operator+="
  - "+= operator"
  - "operator +=, strings"
  - "operator+=, strings"
  - "operator +="
ms.assetid: bc44659d-b3a1-4f24-a4f7-2e8c50871834
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::operator+=
Appends characters to a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character to be appended.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The characters of the C-string to be appended.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The characters of the string to be appended.  
  
## Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
## Remarks  
 Characters may be appended to a string using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or the member functions [append](../vs140/basic_string--append.md) or [push_back](../vs140/basic_string--push_back.md). The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> appends single-argument values while the multiple argument append member function allows a specific part of a string to be specified for adding.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello**  
**The string str1 appended with an exclamation is: Hello!**  
**The C-string cstr1b is: Out There**  
**Appending the C-string cstr1b to string str1 gives: Hello Out There.**  
**The string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)