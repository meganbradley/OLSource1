---
title: "is_pointer Class"
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
  - std.tr1.is_pointer
  - is_pointer
  - std::tr1::is_pointer
  - std.is_pointer
  - std::is_pointer
  - type_traits/std::is_pointer
dev_langs: 
  - C++
helpviewer_keywords: 
  - is_pointer class [TR1]
  - is_pointer
ms.assetid: 44e0a403-7241-4e0a-8922-32877bcb9a4c
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# is_pointer Class
Tests if type is a pointer.  
  
## Syntax  
  
```  
template<class Ty>  
    struct is_pointer;  
```  
  
#### Parameters  
 `Ty`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type `Ty` is a pointer to `void`, a pointer to an object, or a pointer to a function, or a `cv-qualified` form of one of them, otherwise it holds false. Note that `is_pointer` holds false if `Ty` is a pointer to member or a pointer to member function.  
  
## Example  
  
```  
// std_tr1__type_traits__is_pointer.cpp   
// compile with: /EHsc   
#include <type_traits>   
#include <iostream>   
  
struct trivial   
    {   
    int val;   
    };   
  
int main()   
    {   
    std::cout << "is_pointer<trivial> == " << std::boolalpha   
        << std::is_pointer<trivial>::value << std::endl;   
    std::cout << "is_pointer<int trivial::*> == " << std::boolalpha   
        << std::is_pointer<int trivial::*>::value << std::endl;   
    std::cout << "is_pointer<trivial *> == " << std::boolalpha   
        << std::is_pointer<trivial *>::value << std::endl;   
    std::cout << "is_pointer<int> == " << std::boolalpha   
        << std::is_pointer<int>::value << std::endl;   
    std::cout << "is_pointer<int *> == " << std::boolalpha   
        << std::is_pointer<int *>::value << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **is_pointer<trivial\> == false**  
**is_pointer<int trivial::\*> == false**  
**is_pointer<trivial \*> == true**  
**is_pointer<int\> == false**  
**is_pointer<int \*> == true**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)   
 [is_member_pointer](../vs140/is_member_pointer-class.md)   
 [is_reference](../vs140/is_reference-class.md)