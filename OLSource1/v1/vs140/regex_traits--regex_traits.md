---
title: "regex_traits::regex_traits"
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
  - "regex_traits.regex_traits"
  - "regex_traits"
  - "std.tr1.regex_traits.regex_traits"
  - "regex_traits::regex_traits"
  - "std::tr1::regex_traits::regex_traits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_traits constructor [TR1]"
ms.assetid: f18f03a8-bc56-4c23-a027-fb0cb3f379dc
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::regex_traits
Constructs the object.  
  
## Syntax  
  
```  
regex_traits();  
```  
  
## Remarks  
 The constructor constructs an object whose stored `locale` object is initialized to the default locale.  
  
## Example  
  
```  
// std_tr1__regex__regex_traits_construct.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
typedef std::regex_traits<char> Mytr;   
int main()   
    {   
    Mytr tr;   
  
    Mytr::char_type ch = tr.translate('a');   
    std::cout << "translate('a') == 'a' == " << std::boolalpha   
        << (ch == 'a') << std::endl;   
  
    std::cout << "nocase 'a' == 'A' == " << std::boolalpha   
        << (tr.translate_nocase('a') == tr.translate_nocase('A'))   
        << std::endl;   
  
    const char *lbegin = "abc";   
    const char *lend = lbegin + strlen(lbegin);   
    Mytr::size_type size = tr.length(lbegin);   
    std::cout << "length(\"abc\") == " << size <<std::endl;   
  
    Mytr::string_type str = tr.transform(lbegin, lend);   
    std::cout << "transform(\"abc\") < \"abc\" == " << std::boolalpha   
        << (str < "abc") << std::endl;   
  
    const char *ubegin = "ABC";   
    const char *uend = ubegin + strlen(ubegin);   
    std::cout << "primary \"ABC\" < \"abc\" == " << std::boolalpha   
        << (tr.transform_primary(ubegin, uend) <   
            tr.transform_primary(lbegin, lend))   
        << std::endl;   
  
    const char *dig = "digit";   
    Mytr::char_class_type cl = tr.lookup_classname(dig, dig + 5);   
    std::cout << "class digit == d == " << std::boolalpha   
        << (cl == tr.lookup_classname(dig, dig + 1))   
        << std::endl;   
  
    std::cout << "'3' is digit == " <<std::boolalpha   
        << tr.isctype('3', tr.lookup_classname(dig, dig + 5))   
        << std::endl;   
  
    std::cout << "hex C == " << tr.value('C', 16) << std::endl;   
  
// other members   
    str = tr.lookup_collatename(dig, dig + 5);   
  
    Mytr::locale_type loc = tr.getloc();   
    tr.imbue(loc);   
  
    return (0);   
    }  
  
```  
  
 **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_traits](../vs140/regex_traits-class.md)