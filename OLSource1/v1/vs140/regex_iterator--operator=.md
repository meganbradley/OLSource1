---
title: "regex_iterator::operator="
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
  - "std::tr1::regex_iterator::operator="
  - "regex_iterator::operator="
  - "std.tr1.regex_iterator.operator="
  - "regex_iterator.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
ms.assetid: 01bd872c-28f8-4eb6-8aac-c7a2bda743e0
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator::operator=
Compares iterators for equality.  
  
## Syntax  
  
```  
bool operator==(const regex_iterator& right);  
```  
  
#### Parameters  
 `right`  
 The iterator to compare to.  
  
## Remarks  
 The member function returns true if `*this` and `right` are both end-of-sequence iterators or if neither is an end-of-sequence iterator and `begin == right.begin`, `end == right.end`, `pregex == right.pregex`, and `flags == right.flags`. Otherwise it returns false.  
  
## Example  
  
```  
// std_tr1__regex__regex_iterator_operator_as.cpp   
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
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)   
 [regex_iterator::operator_ne](../vs140/regex_iterator--operator!=.md)