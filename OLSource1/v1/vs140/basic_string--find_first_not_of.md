---
title: "basic_string::find_first_not_of"
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
  - "basic_string::find_first_not_of"
  - "find_first_not_of"
  - "xstring/std::basic_string::find_first_not_of"
  - "std::basic_string::find_first_not_of"
  - "std.basic_string.find_first_not_of"
  - "basic_string.find_first_not_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_first_not_of method"
ms.assetid: 234fd624-95b4-4cd0-a78f-fbdc398b8161
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find_first_not_of
Searches through a string for the first character that is not an element of a specified string.  
  
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
 **The original string str1 is: xddd-1234-abcd**  
**The index of the 1st 'd' found after the 3rd position in str1 is: 4**  
**The index of the 'non x' found in str1 is: 1**  
**The original string str2 is: BBB-1111**  
**Elements of the substring 'B1' were not**  
 **found in str2 after the 6th position.**  
**The index of the 1st element of 'B2' after**  
 **the 0th position in str2 is: 3**  
**The original string str3 is: 444-555-GGG**  
**The index of the 1st occurrence of an element in str3**  
 **other than one of the characters in '45G' is: 3**  
**The index of the second occurrence of an element of '45G' in str3**  
 **after the 0th position is: 7**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the 1st non occurrence of an element of 'ba3' in str4 after**  
 **the 5th position is: 5**  
**The index of the 1st non occurrence of an element of '12' in str4 after**  
 **the 0th position is: 2**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)