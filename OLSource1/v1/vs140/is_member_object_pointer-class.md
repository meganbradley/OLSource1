---
title: "is_member_object_pointer Class"
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
  - "is_member_object_pointer"
  - "std.tr1.is_member_object_pointer"
  - "std::tr1::is_member_object_pointer"
  - "std.is_member_object_pointer"
  - "std::is_member_object_pointer"
  - "type_traits/std::is_member_object_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_member_object_pointer class [TR1]"
  - "is_member_object_pointer"
ms.assetid: 64f9cdf3-4621-4310-a076-a7bc986926b9
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_member_object_pointer Class
Tests if type is a pointer to member object.  
  
## Syntax  
  
```  
template<class Ty>  
    struct is_member_object_pointer;  
```  
  
#### Parameters  
 `Ty`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type `Ty` is a pointer to member object or a `cv-qualified` pointer to member object, otherwise it holds false. Note that `is_member_object_pointer` holds false if `Ty` is a pointer to member function.  
  
## Example  
  
```  
// std_tr1__type_traits__is_member_object_pointer.cpp   
// compile with: /EHsc   
#include <type_traits>   
#include <iostream>   
  
struct trivial   
    {   
    int val;   
    };   
  
struct functional   
    {   
    int f();   
    };   
  
int main()   
    {   
    std::cout << "is_member_object_pointer<trivial *> == "   
        << std::boolalpha   
        << std::is_member_object_pointer<trivial *>::value   
        << std::endl;   
    std::cout << "is_member_object_pointer<int trivial::*> == "   
        << std::boolalpha   
        << std::is_member_object_pointer<int trivial::*>::value   
        << std::endl;   
    std::cout << "is_member_object_pointer<int (functional::*)()> == "   
        << std::boolalpha   
        << std::is_member_object_pointer<int (functional::*)()>::value   
        << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **is_member_object_pointer<trivial \*> == false**  
**is_member_object_pointer<int trivial::\*> == true**  
**is_member_object_pointer<int (functional::\*)()> == false**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)   
 [is_member_pointer](../vs140/is_member_pointer-class.md)