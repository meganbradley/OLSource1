---
title: "basic_regex::basic_regex"
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
  - "std.tr1.basic_regex.basic_regex"
  - "std::tr1::basic_regex::basic_regex"
  - "basic_regex::basic_regex"
  - "basic_regex.basic_regex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_regex constructor [TR1]"
ms.assetid: 2771018f-c603-426e-b98d-fa8f3ec71375
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::basic_regex
Construct the regular expression object.  
  
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
 All constructors store a default-constructed object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The first constructor constructs an empty <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. The other constructors construct a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object that holds the regular expression described by the operand sequence.  
  
 An empty <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object does not match any character sequence when passed to [regex_match](../vs140/regex_match-function.md), [regex_search](../vs140/regex_search-function.md), or [regex_replace](../vs140/regex_replace-function.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc", "abc") == true**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)