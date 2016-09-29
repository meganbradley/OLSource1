---
title: "operator== &lt;regex&gt;"
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
  - "regex::operator=="
  - "regex.operator=="
  - "std.tr1.regex.operator=="
  - "std::tr1::regex::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator [TR1]"
ms.assetid: 68803e0d-6c82-4a85-91e7-f000aa3f6079
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== &lt;regex&gt;
Equal comparison for various objects.  
  
## Syntax  
  
```  
template<class BidIt>  
    bool operator==(const sub_match<BidIt>& left,  
        const sub_match<BidIt>& right);  
template<class BidIt, class IOtraits, class Alloc>  
    bool operator==(  
        const basic_string<typename iterator_traits<BidIt>::value_type, IOtraits, Alloc>& left,  
        const sub_match<BidIt>& right);  
template<class BidIt, class IOtraits, class Alloc>  
    bool operator==(const sub_match<BidIt>& left,  
        const basic_string<typename iterator_traits<BidIt>::value_type, IOtraits, Alloc>& right);  
template<class BidIt>  
    bool operator==(const typename iterator_traits<BidIt>::value_type* left,  
        const sub_match<BidIt>& right);  
template<class BidIt>  
    bool operator==(const sub_match<BidIt>& left,  
        const typename iterator_traits<BidIt>::value_type* right);  
template<class BidIt>  
    bool operator==(const typename iterator_traits<BidIt>::value_type& left,  
        const sub_match<BidIt>& right);  
template<class BidIt>  
    bool operator==(const sub_match<BidIt>& left,  
        const typename iterator_traits<BidIt>::value_type& right);  
template<class BidIt, class Alloc>  
    bool operator==(const match_results<BidIt, Alloc>& left,  
        const match_results<BidIt, Alloc>& right);  
```  
  
#### Parameters  
 `BidIt`  
 The iterator type.  
  
 `IOtraits`  
 The string traits class.  
  
 `Alloc`  
 The allocator class.  
  
 `left`  
 The left object to compare.  
  
 `right`  
 The right object to compare.  
  
## Remarks  
 Each template operator converts each of its arguments to a string type and returns the result of comparing the converted objects for equality.  
  
 When a template operator converts its arguments to a string type it uses the first of the following transformations that applies:  
  
 arguments whose types are a specialization of template class `match_results` or `sub_match` are converted by calling the `str` member function;  
  
 arguments whose types are a specialization of the template class `basic_string` are unchanged;  
  
 all other argument types are converted by passing the argument value to the constructor for an appropriate specialization of the template class `basic_string`.  
  
## Example  
  
```  
// std_tr1__regex__operator_eq.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
typedef std::cmatch::string_type Mystr;   
int main()   
    {   
    std::regex rx("c(a*)|(b)");   
    std::cmatch mr;   
  
    std::regex_search("xcaaay", mr, rx);   
  
    std::csub_match sub = mr[1];   
    std::cout << "match == " << mr.str() << std::endl;   
    std::cout << "sub == " << sub << std::endl;   
    std::cout << std::endl;   
  
    std::cout << "match == match == " << std::boolalpha   
        << (mr == mr) << std::endl;   
    std::cout << "sub == sub == " << std::boolalpha   
        << (sub == sub) << std::endl;   
  
    std::cout << "string(\"aab\") == sub == " << std::boolalpha   
        << (Mystr("aab") == sub) << std::endl;   
    std::cout << "sub == string(\"aab\") == " << std::boolalpha   
        << (sub == Mystr("aab")) << std::endl;   
  
    std::cout << "\"aab\" == sub == " << std::boolalpha   
        << ("aab" == sub) << std::endl;   
    std::cout << "sub == \"aab\" == " << std::boolalpha   
        << (sub == "aab") << std::endl;   
  
    std::cout << "'a' == sub == " << std::boolalpha   
        << ('a' == sub) << std::endl;   
    std::cout << "sub == 'a' == " << std::boolalpha   
        << (sub == 'a') << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **match == caaa**  
**sub == aaa**  
**match == match == true**  
**sub == sub == true**  
**string("aab") == sub == false**  
**sub == string("aab") == false**  
**"aab" == sub == false**  
**sub == "aab" == false**  
**'a' == sub == false**  
**sub == 'a' == false**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [operator!==](../vs140/operator!=--regex-.md)   
 [operator<](../vs140/operator---regex-.md)   
 [operator<=](../vs140/operator-=--regex-.md)   
 [operator>](../vs140/operator---regex-.md)   
 [operator>=](../vs140/operator-=--regex-.md)