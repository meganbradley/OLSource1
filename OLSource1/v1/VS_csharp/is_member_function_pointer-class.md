---
title: "is_member_function_pointer Class"
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
  - "std.tr1.is_member_function_pointer"
  - "std::tr1::is_member_function_pointer"
  - "is_member_function_pointer"
  - "std.is_member_function_pointer"
  - "std::is_member_function_pointer"
  - "type_traits/std::is_member_function_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_member_function_pointer class [TR1]"
  - "is_member_function_pointer"
ms.assetid: 02e372c4-2714-40f2-b376-2e10ca91c8ed
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_member_function_pointer Class
Tests if type is a pointer to member function.  
  
## Syntax  
  
```  
template<class Ty>  
    struct is_member_function_pointer;  
```  
  
#### Parameters  
 `Ty`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type `Ty` is a pointer to member function or a `cv-qualified` pointer to member function, otherwise it holds false.  
  
## Example  
  
```  
// std_tr1__type_traits__is_member_function_pointer.cpp   
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
    std::cout << "is_member_function_pointer<trivial *> == "   
        << std::boolalpha   
        << std::is_member_function_pointer<trivial *>::value   
        << std::endl;   
    std::cout << "is_member_function_pointer<int trivial::*> == "   
        << std::boolalpha   
        << std::is_member_function_pointer<int trivial::*>::value   
        << std::endl;   
    std::cout << "is_member_function_pointer<int (functional::*)()> == "   
        << std::boolalpha   
        << std::is_member_function_pointer<int (functional::*)()>::value   
        << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **is_member_function_pointer<trivial \*> == false**  
**is_member_function_pointer<int trivial::\*> == false**  
**is_member_function_pointer<int (functional::\*)()> == true**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../VS_csharp/-type_traits-.md)   
 [is_member_pointer](../VS_csharp/is_member_pointer-class.md)