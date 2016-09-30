---
title: "basic_string::find"
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
  - "find"
  - "basic_string.find"
  - "Find"
  - "xstring/std::basic_string::find"
  - "std::basic_string::find"
  - "std.basic_string.find"
  - "basic_string::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: e8254589-ae65-4414-b28f-54ba8f544656
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find
Searches a string in a forward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
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
 The index of the first character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found after the 3rd position in str1 is: 8**  
**The Character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' after**  
 **the 5th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: This is a sample string for this program**  
**The index of the 1st element of sample in str3 is: 10**  
**The index of the next occurrence of 'for' is in str3 begins at: 24**  
**The original string str4 is: clearly this perfectly unclear.**  
**The index of the 1st element of 'clear' after**  
 **the 5th position in str4 is: 25**  
**The index of the 1st element of 'clear' in str4 is: 0**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [strstr, wcsstr, _mbsstr, _mbsstr_l](../vs140/strstr--wcsstr--_mbsstr--_mbsstr_l.md)