---
title: "sub_match::operator basic_string&lt;value_type&gt;"
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
  - sub_match::operator basic_string<value_type>
  - sub_match.operator basic_string<value_type>
  - operator basic_string<value_type>
  - std.tr1.sub_match.operator basic_string<value_type>
  - std::tr1::sub_match::operator basic_string<value_type>
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator basic_string<value_type> operator [TR1]
ms.assetid: 2e41a7d2-0a37-4c80-a9aa-3bbffa826da2
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# sub_match::operator basic_string&lt;value_type&gt;
Casts submatch to a string.  
  
## Syntax  
  
```  
operator basic_string<value_type>() const;  
```  
  
## Remarks  
 The member operator returns `str()`.  
  
## Example  
  
```  
// std_tr1__regex__sub_match_operator_str.cpp   
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
 [sub_match::str](../vs140/sub_match--str.md)