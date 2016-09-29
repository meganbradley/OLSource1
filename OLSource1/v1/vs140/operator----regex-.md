---
title: "operator&lt;&lt; &lt;regex&gt;"
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
  - "std::tr1::regex::operator<<"
  - "regex::operator<<"
  - "std.tr1.regex.operator<<"
  - "regex.operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<< operator [TR1]"
ms.assetid: f1ac8244-790d-48b4-9f23-79d491855ef0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;&lt; &lt;regex&gt;
Inserts a sub_match in a stream.  
  
## Syntax  
  
```  
template<class Elem, class IOtraits, class Alloc, class BidIt>  
    basic_ostream<Elem, IOtraits>&  
    operator<<(basic_ostream<Elem, IOtraits>& os,  
        const sub_match<BidIt>& right);  
```  
  
#### Parameters  
 `Elem`  
 The element type.  
  
 `IOtraits`  
 The string traits class.  
  
 `Alloc`  
 The allocator class.  
  
 `BidIt`  
 The iterator type.  
  
 `os`  
 The output stream.  
  
 `right`  
 The object to insert.  
  
## Remarks  
 The template operator returns `os << right.str()`.  
  
## Example  
  
```  
// std_tr1__regex__operator_ins.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex rx("c(a*)|(b)");   
    std::cmatch mr;   
  
    std::regex_search("xcaaay", mr, rx);   
  
    std::csub_match sub = mr[0];   
    std::cout << "whole match: " << sub << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **whole match: caaa**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)