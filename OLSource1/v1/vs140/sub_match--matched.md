---
title: "sub_match::matched"
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
  - "std.tr1.sub_match.matched"
  - "sub_match.matched"
  - "matched"
  - "sub_match::matched"
  - "std::tr1::sub_match::matched"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "matched method [TR1]"
ms.assetid: c257f1e6-ca59-44a0-9c26-cf4d9f0cfba8
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sub_match::matched
Indicates if match succeeded.  
  
## Syntax  
  
```  
bool matched;  
```  
  
## Remarks  
 The member holds `true` only if the capture group associated with `*this` was part of the regular expression match.  
  
## Example  
  
```  
// std_tr1__regex__sub_match_matched.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex rx("c(a*)|(b)");   
    std::cmatch mr;   
  
    std::regex_search("xcaaay", mr, rx);   
  
    std::csub_match sub = mr[1];   
    std::cout << "matched == " << std::boolalpha   
        << sub.matched << std::endl;   
    std::cout << "length == " << sub.length() << std::endl;   
  
    std::csub_match::difference_type dif = std::distance(sub.first, sub.second);   
    std::cout << "difference == " << dif << std::endl;   
  
    std::csub_match::iterator first = sub.first;   
    std::csub_match::iterator last = sub.second;   
    std::cout << "range == " << std::string(first, last)   
        << std::endl;   
    std::cout << "string == " << sub << std::endl;   
  
    std::csub_match::value_type *ptr = "aab";   
    std::cout << "compare(\"aab\") == "   
        << sub.compare(ptr) << std::endl;   
    std::cout << "compare(string) == "   
        << sub.compare(std::string("AAA")) << std::endl;   
    std::cout << "compare(sub) == "   
        << sub.compare(sub) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)