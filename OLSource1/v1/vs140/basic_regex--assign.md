---
title: "basic_regex::assign"
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
  - "std::tr1::basic_regex::assign"
  - "basic_regex.assign"
  - "std.tr1.basic_regex.assign"
  - "basic_regex::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method [TR1]"
ms.assetid: d20a067a-aaec-4a3b-827d-88ecdd4d531b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::assign
Assigns a value to the regular expressoin object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Traits class for a string source.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Allocator class for a string source.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Input iterator type for a range source.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Regex source to copy.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Syntax option flags to add while copying.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Length of sequence to copy.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 String to copy.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 End of sequence to copy.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The initializer_list to copy.  
  
## Remarks  
 The member functions each replace the regular expression held by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with the regular expression described by the operand sequence, then return <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc") == true**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)   
 [basic_regex::operator_as](../vs140/basic_regex--operator=.md)