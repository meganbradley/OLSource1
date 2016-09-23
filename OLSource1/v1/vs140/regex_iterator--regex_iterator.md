---
title: "regex_iterator::regex_iterator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - regex_iterator::regex_iterator
  - regex_iterator.regex_iterator
  - std::tr1::regex_iterator::regex_iterator
  - std.tr1.regex_iterator.regex_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - regex_iterator constructor [TR1]
ms.assetid: 0dd4d584-0a3c-43f3-8f55-a1bdd6b3d10e
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# regex_iterator::regex_iterator
Constructs the iterator.  
  
## Syntax  
  
```  
regex_iterator();  
regex_iterator(BidIt first, BidIt last,  
    const regex_type& re, regex_constants::match_flag_type f = regex_constants::match_default);  
```  
  
#### Parameters  
 `first`  
 Beginning of sequence to match.  
  
 `last`  
 End of sequence to match.  
  
 `re`  
 Regular expression for matches.  
  
 `f`  
 Flags for matches.  
  
## Remarks  
 The first constructor constructs an end-of-sequence iterator. The second constructor initializes the stored value `begin` with `first`, the stored value `end` with `last`, the stored value `pregex` with `&re`, and the stored value `flags` with `f`. It then calls `regex_search(begin, end, match, *pregex, flags)`. If the search fails, the constructor sets the object to an end-of-sequence iterator.  
  
## Example  
  
```  
// std_tr1__regex__regex_iterator_construct.cpp   
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