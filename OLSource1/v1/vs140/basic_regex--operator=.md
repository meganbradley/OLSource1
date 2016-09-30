---
title: "basic_regex::operator="
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
  - "basic_regex.operator="
  - "std.tr1.basic_regex.operator="
  - "basic_regex::operator="
  - "std::tr1::basic_regex::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
ms.assetid: b139c41c-5bac-4c68-b878-3af8369200c9
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::operator=
Assigns a value to the regular expression object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Traits class for a string source.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Allocator class for a string source.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Regex source to copy.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 String to copy.  
  
## Remarks  
 The operators each replace the regular expression held by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the regular expression described by the operand sequence, then return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
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
 [basic_regex::assign](../vs140/basic_regex--assign.md)