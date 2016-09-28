---
title: "match_results::reference"
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
  - "match_results::reference"
  - "std.tr1.match_results.reference"
  - "match_results.reference"
  - "reference"
  - "std::tr1::match_results::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef [TR1]"
ms.assetid: 98734b01-88aa-4361-aa8c-ff60e713486b
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# match_results::reference
The type of an element reference.  
  
## Syntax  
  
```  
typedef const_reference reference;  
```  
  
## Remarks  
 The type is a synonym for the type `const_reference`.  
  
## Example  
  
```  
// std_tr1__regex__match_results_reference.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex rx("c(a*)|(b)");   
    std::cmatch mr;   
  
    std::regex_search("xcaaay", mr, rx);   
  
    std::cout << "prefix: matched == " << std::boolalpha   
        << mr.prefix().matched   
        << ", value == " << mr.prefix() << std::endl;   
    std::cout << "whole match: " << mr.length() << " chars, value == "   
        << mr.str() << std::endl;   
    std::cout << "suffix: matched == " << std::boolalpha   
        << mr.suffix().matched   
        << ", value == " << mr.suffix() << std::endl;   
    std::cout << std::endl;   
  
    std::string fmt("\"c(a*)|(b)\" matched \"$0\"\n"   
        "\"(a*)\" matched \"$1\"\n"   
        "\"(b)\" matched \"$2\"\n");   
    std::cout << mr.format(fmt) << std::endl;   
    std::cout << std::endl;   
  
// index through submatches   
    for (size_t n = 0; n < mr.size(); ++n)   
        {   
        std::cout << "submatch[" << n << "]: matched == " << std::boolalpha   
            << mr[n].matched <<   
            " at position " << mr.position(n) << std::endl;   
        std::cout << "  " << mr.length(n)   
            << " chars, value == " << mr[n] << std::endl;   
        }   
    std::cout << std::endl;   
  
// iterate through submatches   
    for (std::cmatch::iterator it = mr.begin(); it != mr.end(); ++it)   
        {   
        std::cout << "next submatch: matched == " << std::boolalpha   
            << it->matched << std::endl;   
        std::cout << "  " << it->length()   
            << " chars, value == " << *it << std::endl;   
        }   
    std::cout << std::endl;   
  
// other members   
    std::cmatch mr1(mr);   
    mr = mr1;   
    mr.swap(mr1);   
  
    char buf[10];   
    *mr.format(&buf[0], "<$0>") = '\0';   
    std::cout << &buf[0] << std::endl;   
    std::cout << "empty == " << std::boolalpha << mr.empty() << std::endl;   
  
    std::cmatch::allocator_type al = mr.get_allocator();   
    std::cmatch::string_type str = std::string("x");   
    std::cmatch::size_type maxsiz = mr.max_size();   
    std::cmatch::char_type ch = 'x';   
    std::cmatch::difference_type dif = mr.begin() - mr.end();   
    std::cmatch::const_iterator cit = mr.begin();   
    std::cmatch::value_type val = *cit;   
    std::cmatch::const_reference cref = val;   
    std::cmatch::reference ref = val;   
  
    maxsiz = maxsiz;  // to quiet "unused" warnings   
    if (ref == cref)   
        ch = ch;   
    dif = dif;   
  
    return (0);   
    }  
  
```  
  
 **prefix: matched == true, value == x**  
**whole match: 4 chars, value == caaa**  
**suffix: matched == true, value == y**  
**"c(a\*)&#124;(b)" matched "caaa"**  
**"(a\*)" matched "aaa"**  
**"(b)" matched ""**  
**submatch[0]: matched == true at position 1**  
 **4 chars, value == caaa**  
**submatch[1]: matched == true at position 2**  
 **3 chars, value == aaa**  
**submatch[2]: matched == false at position 6**  
 **0 chars, value ==**   
**next submatch: matched == true**  
 **4 chars, value == caaa**  
**next submatch: matched == true**  
 **3 chars, value == aaa**  
**next submatch: matched == false**  
 **0 chars, value ==**   
**<caaa\>**  
**empty == false**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [match_results](../vs140/match_results-class.md)   
 [match_results::const_reference](../vs140/match_results--const_reference.md)