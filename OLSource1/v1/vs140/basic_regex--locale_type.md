---
title: "basic_regex::locale_type"
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
  - "std::tr1::basic_regex::locale_type"
  - "basic_regex::locale_type"
  - "basic_regex.locale_type"
  - "locale_type"
  - "std.tr1.basic_regex.locale_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale_type typedef [TR1]"
ms.assetid: 86cadc76-a133-4433-9cd4-10c57f54febc
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::locale_type
The type of the stored locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for [regex_traits::locale_type](../vs140/regex_traits--locale_type.md).  
  
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
 [basic_regex::getloc](../vs140/basic_regex--getloc.md)   
 [basic_regex::imbue](../vs140/basic_regex--imbue.md)