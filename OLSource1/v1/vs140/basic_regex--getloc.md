---
title: "basic_regex::getloc"
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
  - "std.tr1.basic_regex.getloc"
  - "std::tr1::basic_regex::getloc"
  - "getloc"
  - "basic_regex::getloc"
  - "basic_regex.getloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getloc method [TR1]"
ms.assetid: c2962df6-b933-411a-bf77-8565e76bc7fa
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::getloc
Returns the stored locale object.  
  
## Syntax  
  
```  
locale_type getloc() const;  
```  
  
## Remarks  
 The member function returns `traits.`[getloc](../vs140/regex_traits--getloc.md)`()`.  
  
## Example  
  
```  
// std_tr1__regex__basic_regex_getloc.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex::value_type elem = 'x';   
    std::regex::flag_type flag = std::regex::grep;   
  
    elem = elem;  // to quiet "unused" warnings   
    flag = flag;   
  
// constructors   
    std::regex rx0;   
    std::cout << "match(\"abc\", \"\") == " << std::boolalpha   
        << regex_match("abc", rx0) << std::endl;   
  
    std::regex rx1("abcd", std::regex::ECMAScript);   
    std::cout << "match(\"abc\", \"abcd\") == " << std::boolalpha   
        << regex_match("abc", rx1) << std::endl;   
  
    std::regex rx2("abcd", 3);   
    std::cout << "match(\"abc\", \"abc\") == " << std::boolalpha   
        << regex_match("abc", rx2) << std::endl;   
  
    std::regex rx3(rx2);   
    std::cout << "match(\"abc\", \"abc\") == " << std::boolalpha   
        << regex_match("abc", rx3) << std::endl;   
  
    std::string str("abcd");   
    std::regex rx4(str);   
    std::cout << "match(string(\"abcd\"), \"abc\") == " << std::boolalpha   
        << regex_match("abc", rx4) << std::endl;   
  
    std::regex rx5(str.begin(), str.end() - 1);   
    std::cout << "match(string(\"abc\"), \"abc\") == " << std::boolalpha   
        << regex_match("abc", rx5) << std::endl;   
    std::cout << std::endl;   
  
// assignments   
    rx0 = "abc";   
    rx0 = rx1;   
    rx0 = str;   
  
    rx0.assign("abcd", std::regex::ECMAScript);   
    rx0.assign("abcd", 3);   
    rx0.assign(rx1);   
    rx0.assign(str);   
    rx0.assign(str.begin(), str.end() - 1);   
  
    rx0.swap(rx1);   
  
// mark_count   
    std::cout << "\"abc\" mark_count == "   
        << std::regex("abc").mark_count() << std::endl;   
    std::cout << "\"(abc)\" mark_count == "   
        << std::regex("(abc)").mark_count() << std::endl;   
  
// locales   
    std::regex::locale_type loc = rx0.imbue(std::locale());   
    std::cout << "getloc == imbued == " << std::boolalpha   
        << (loc == rx0.getloc()) << std::endl;   
  
    return (0);   
    }  
  
```  
  
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
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)   
 [basic_regex::imbue](../vs140/basic_regex--imbue.md)   
 [basic_regex::locale_type](../vs140/basic_regex--locale_type.md)