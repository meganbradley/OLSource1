---
title: "basic_string::rfind"
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
  - "std::basic_string::rfind"
  - "xstring/std::basic_string::rfind"
  - "basic_string::rfind"
  - "basic_string.rfind"
  - "rfind"
  - "std.basic_string.rfind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rfind method"
ms.assetid: f14c4ec2-e7af-41f9-83fb-c1e4bb7858f8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rfind
Searches a string in a backward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Index of the position at which the search is to begin.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
## Return Value  
 The index of the last occurrence, when searched backwards, of the first character of the substring when successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found before the 9th position in str1 is: 8**  
**The character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' before**  
 **the 30th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: It is a nice day. I am happy.**  
**The index of the 1st element of 'nice' in str3 is: 8**  
**The index of the next occurrance of 'am' in str3 begins at: 20**  
**The original string str4 is: This perfectly unclear.**  
**The substring 'clear' was not found in str4 before the 15th position.**  
**The index of the 1st element of 'clear' in str4 is: 17**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)