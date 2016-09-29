---
title: "regex_iterator::reference"
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
  - "regex_iterator.reference"
  - "reference"
  - "regex_iterator::reference"
  - "std.tr1.regex_iterator.reference"
  - "std::tr1::regex_iterator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef [TR1]"
ms.assetid: 8fc89359-9a72-4291-8b89-9851f8ababcc
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator::reference
The type of a reference to a match.  
  
## Syntax  
  
```  
typedef match_results<BidIt>& reference;  
```  
  
## Remarks  
 The type is a synonym for `match_results<BidIt>&`, where `BidIt` is the template parameter.  
  
## Example  
  
```  
// std_tr1__regex__regex_iterator_reference.cpp   
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