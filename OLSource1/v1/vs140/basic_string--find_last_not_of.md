---
title: "basic_string::find_last_not_of"
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
  - "std::basic_string::find_last_not_of"
  - "find_last_not_of"
  - "basic_string.find_last_not_of"
  - "basic_string::find_last_not_of"
  - "xstring/std::basic_string::find_last_not_of"
  - "std.basic_string.find_last_not_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_last_not_of method"
ms.assetid: 2c52054b-097b-4482-a88e-b76145067fa2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find_last_not_of
Searches through a string for the last character that is not any element of a specified string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Index of the position at which the search is to finish.  
  
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
 **The original string str1 is: dddd-1dd4-abdd**  
**The index of the last non 'd'**  
 **found before the 7th position in str1 is: 5**  
**The index of the non 'd' found in str1 is: 11**  
**The original string str2 is: BBB-1111**  
**The index of the last occurrence of a element**  
 **not of 'B1' in str2 before the 6th position is: 3**  
**The elements of the substring 'B-1' were not found in str2 .**  
**The original string str3 is: 444-555-GGG**  
**The index of the last occurrence of an element in str3**  
 **other than one of the characters in '45G' is: 7**  
**The index of the penultimate occurrence of an element**  
 **not in '45G' in str3 is: 3**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the last occurrence of an element not**  
 **in 'b-a' in str4 before the 5th position is: 1**  
**The index of the last occurrence of an element not in '12'**  
 **in str4 before the end position is: 10**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)