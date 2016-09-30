---
title: "basic_regex::imbue"
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
  - "std::tr1::basic_regex::imbue"
  - "basic_regex.imbue"
  - "imbue"
  - "std.tr1.basic_regex.imbue"
  - "basic_regex::imbue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imbue method [TR1]"
ms.assetid: 4ef57d97-2609-4fd9-9ced-3f0dbffcf289
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::imbue
Alters the stored locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale object to store.  
  
## Remarks  
 The member function empties <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[imbue](../vs140/regex_traits--imbue.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
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
 [basic_regex::locale_type](../vs140/basic_regex--locale_type.md)