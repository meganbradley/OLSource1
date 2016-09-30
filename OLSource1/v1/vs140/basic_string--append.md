---
title: "basic_string::append"
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
  - "Append"
  - "xstring/std::basic_string::append"
  - "std::basic_string::append"
  - "append"
  - "std.basic_string.append"
  - "basic_string.append"
  - "basic_string::append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "append method"
ms.assetid: cc71e4b4-2da5-4674-88ec-17f30045c873
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::append
Adds characters to the end of a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The C-string to be appended.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string whose characters are to be appended.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The index of the part of the source string supplying the characters to be appended.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of characters to be appended, at most, from the source string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The character value to be appended.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be appended.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the range to be appended.  
  
## Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
## Remarks  
 Characters may be appended to a string using the [operator+=](../vs140/basic_string--operator-=.md) or the member functions **append** or [push_back](../vs140/basic_string--push_back.md). <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> appends single-argument values while the multiple-argument **append** member function allows a specific part of a string to be specified for adding.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello**   
**The C-string cstr1a is: Out There**   
**Appending the C-string cstr1a to string str1 gives: Hello Out There .**  
**The string str1b is: Hello**   
**The C-string cstr1b is: Out There**   
**Appending the 1st part of the C-string cstr1b to string str1 gives: Hello Out.**  
**The string str2c is: Wide World**   
**The appended string str1 is: Hello World.**  
**The  string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World .**  
**The string str1 appended with exclamations is: Hello !!!!**  
**The string str2f is: Wide World**   
**The appended string str1 is: Hello World.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [basic_string::append](../vs140/basic_string--append--stl-samples-.md)