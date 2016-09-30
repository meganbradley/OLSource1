---
title: "basic_regex::mark_count"
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
  - "std::tr1::basic_regex::mark_count"
  - "mark_count"
  - "std.tr1.basic_regex.mark_count"
  - "basic_regex.mark_count"
  - "basic_regex::mark_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mark_count method [TR1]"
ms.assetid: 196723cf-320a-4c2f-83b8-8792261081dd
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::mark_count
Returns number of subexpressions matched.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the number of capture groups in the regular expression.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)