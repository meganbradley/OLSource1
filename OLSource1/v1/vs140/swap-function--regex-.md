---
title: "swap Function &lt;regex&gt;"
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
  - "std.tr1.swap"
  - "std::tr1::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function [TR1]"
ms.assetid: 73116d2c-0b3c-4413-9252-8fff4f23df49
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap Function &lt;regex&gt;
Swaps two basic_regex or match_results objects.  
  
## Syntax  
  
```  
template<class Elem, class RXtraits>  
    void swap(basic_regex<Elem, RXtraits, Alloc>& left,  
        basic_regex<Elem, RXtraits>& right) throw();  
template<class Elem, class IOtraits, class BidIt, class Alloc>  
    void swap(match_results<BidIt, Alloc>& left,  
        match_results<BidIt, Alloc>& right) throw();  
```  
  
#### Parameters  
 `Elem`  
 The type of elements to match.  
  
 `RXtraits`  
 Traits class for elements.  
  
## Remarks  
 The template functions swap the contents of their respective arguments in constant time and do not throw exceptions.  
  
## Example  
  
```  
// std_tr1__regex__swap.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex rx0("c(a*)|(b)");   
    std::regex rx1;   
    std::cmatch mr0;   
    std::cmatch mr1;   
  
    swap(rx0, rx1);   
    std::regex_search("xcaaay", mr1, rx1);   
    swap(mr0, mr1);   
  
    std::csub_match sub = mr0[1];   
    std::cout << "matched == " << std::boolalpha   
        << sub.matched << std::endl;   
    std::cout << "length == " << sub.length() << std::endl;   
    std::cout << "string == " << sub << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **matched == true**  
**length == 3**  
**string == aaa**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)   
 [match_results](../vs140/match_results-class.md)