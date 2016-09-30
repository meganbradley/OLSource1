---
title: "basic_string::find_first_of"
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
  - "find_first_of"
  - "xstring/std::basic_string::find_first_of"
  - "std.basic_string.find_first_of"
  - "basic_string::find_first_of"
  - "std::basic_string::find_first_of"
  - "basic_string.find_first_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_first_of method"
ms.assetid: 0801a053-5db5-42d4-a8e7-84b9be7125e5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find_first_of
Searches through a string for the first character that matches any element of a specified string.  
  
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
 **The original string str1 is: abcd-1234-abcd-1234**  
**The index of the 1st 'd' found after the 5th position in str1 is: 13**  
**The character 'x' was not found in str1.**  
**The original string str2 is: ABCD-1234-ABCD-1234**  
**The index of the 1st occurrence of an element of 'B1' in str2 after**  
 **the 6th position is: 11**  
**The index of the 1st element of 'D2' after**  
 **the 0th position in str2 is: 3**  
**The original string str3 is: 123-abc-123-abc-456-EFG-456-EFG**  
**The index of the 1st occurrence of an element of '5G' in str3 after**  
 **the 0th position is: 17**  
**The index of the second occurrence of an element of '5G' in str3**  
 **after the 0th position is: 22**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the 1st occurrence of an element of 'ba3' in str4 after**  
 **the 5th position is: 9**  
**The index of the 1st occurrence of an element of 'a2' in str4 after**  
 **the 0th position is: 1**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [basic_string::find_first_of](../vs140/basic_string--find_first_of--stl-samples-.md)