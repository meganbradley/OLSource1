---
title: "is_signed Class"
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
  - "is_signed"
  - "std.tr1.is_signed"
  - "std::tr1::is_signed"
  - "std.is_signed"
  - "std::is_signed"
  - "type_traits/std::is_signed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_signed class [TR1]"
  - "is_signed"
ms.assetid: 20ae44d9-22ad-4fbd-b26a-f18c62689451
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_signed Class
Test if type is signed integer.  
  
## Syntax  
  
```  
template<class Ty>  
    struct is_signed;  
```  
  
#### Parameters  
 `Ty`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type `Ty` is a signed integral type or a `cv-qualified` signed integral type, otherwise it holds false.  
  
## Example  
  
```  
// std_tr1__type_traits__is_signed.cpp   
// compile with: /EHsc   
#include <type_traits>   
#include <iostream>   
  
struct trivial   
    {   
    int val;   
    };   
  
int main()   
    {   
    std::cout << "is_signed<trivial> == " << std::boolalpha   
        << std::is_signed<trivial>::value << std::endl;   
    std::cout << "is_signed<int> == " << std::boolalpha   
        << std::is_signed<int>::value << std::endl;   
    std::cout << "is_signed<unsigned int> == " << std::boolalpha   
        << std::is_signed<unsigned int>::value << std::endl;   
    std::cout << "is_signed<float> == " << std::boolalpha   
        << std::is_signed<float>::value << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **is_signed<trivial\> == false**  
**is_signed<int\> == true**  
**is_signed<unsigned int\> == false**  
**is_signed<float\> == false**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)   
 [is_unsigned](../vs140/is_unsigned-class.md)