---
title: "regex_iterator::regex_type"
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
  - "std::tr1::regex_iterator::regex_type"
  - "std.tr1.regex_iterator.regex_type"
  - "regex_type"
  - "regex_iterator::regex_type"
  - "regex_iterator.regex_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_type typedef [TR1]"
ms.assetid: 00f3386b-7cef-42db-8d0f-5ef6082936ae
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator::regex_type
The type of the regular expression to match.  
  
## Syntax  
  
```  
typedef basic_regex<Elem, RXtraits> regex_type;  
```  
  
## Remarks  
 The typedef is a synonym for `basic_regex<Elem, RXtraits>`.  
  
## Example  
  
```  
// std_tr1__regex__regex_iterator_regex_type.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
typedef std::regex_iterator<const char *> Myiter;   
int main()   
    {   
    const char *pat = "axayaz";   
    Myiter::regex_type rx("a");   
    Myiter next(pat, pat + strlen(pat), rx);   
    Myiter end;   
  
    for (; next != end; ++next)   
        std::cout << "match == " << next->str() << std::endl;   
  
// other members   
    Myiter it1(pat, pat + strlen(pat), rx);   
    Myiter it2(it1);   
    next = it1;   
  
    Myiter::iterator_category cat = std::forward_iterator_tag();   
    Myiter::difference_type dif = -3;   
    Myiter::value_type mr = *it1;   
    Myiter::reference ref = mr;   
    Myiter::pointer ptr = &ref;   
  
    dif = dif; // to quiet "unused" warnings   
    ptr = ptr;   
  
    return (0);   
    }  
  
```  
  
 **match == a**  
**match == a**  
**match == a**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)