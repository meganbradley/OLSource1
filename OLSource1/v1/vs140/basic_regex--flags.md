---
title: "basic_regex::flags"
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
  - "std::tr1::basic_regex::flags"
  - "basic_regex::flags"
  - "flags"
  - "basic_regex.flags"
  - "std.tr1.basic_regex.flags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flags method [TR1]"
ms.assetid: 1b2d7602-612a-45dc-8820-7bb1752e82dd
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::flags
Returns syntax option flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument passed to the most recent call to one of the [assign](../vs140/basic_regex--assign.md) member functions or, if no such call has been made, the value passed to the constructor.  
  
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
 [basic_regex::flag_type](../vs140/basic_regex--flag_type.md)