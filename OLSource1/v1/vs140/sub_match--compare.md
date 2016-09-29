---
title: "sub_match::compare"
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
  - "sub_match::compare"
  - "std::tr1::sub_match::compare"
  - "sub_match.compare"
  - "std.tr1.sub_match.compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method [TR1]"
ms.assetid: de1bd73d-66a2-4417-9b5d-cfc35bda3743
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sub_match::compare
Compare submatch against a sequence.  
  
## Syntax  
  
```  
int compare(const sub_match& right) const;  
int compare(const basic_string<value_type>& str) const;  
int compare(const value_type *ptr) const;  
```  
  
#### Parameters  
 `right`  
 The submatch to compare to.  
  
 `str`  
 The string to compare to.  
  
 `ptr`  
 The nul-terminated sequence to compare to.  
  
## Remarks  
 The first member function compares the matched sequence `[first, second)` to the matched sequence `[right.first, right.second)`. The second member function compares the matched sequence `[first, second)` to the character sequence `[right.begin(), right.end())`. The third member function compares the matched sequence `[first, second)` to the character sequence `[right, right + std::char_traits<value_type>::length(right))`.  
  
 Each function returns:  
  
 a negative value if the first differing value in the matched sequence compares less than the corresponding element in the operand sequence (as determined by `std::char_traits<value_type>::compare`), or if the two have a common prefix but the target sequence is longer  
  
 zero if the two compare equal element by element and have the same length  
  
 a positive value otherwise  
  
## Example  
  
```  
// std_tr1__regex__sub_match_compare.cpp   
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
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)