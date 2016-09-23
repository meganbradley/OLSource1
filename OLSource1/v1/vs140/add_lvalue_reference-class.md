---
title: "add_lvalue_reference Class"
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
  - std::add_lvalue_reference
  - add_lvalue_reference
  - type_traits/std::add_lvalue_reference
  - std.add_lvalue_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - add_lvalue_reference
ms.assetid: 9933afc2-ad0d-465d-98fe-7d547fa3efe2
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# add_lvalue_reference Class
Makes reference to type from type.  
  
## Syntax  
  
```  
template<class T>  
    struct add_lvalue_reference;  
  
template<class T>  
    using add_lvalue_reference_t = typename add_lvalue_reference<T>::type;  
```  
  
#### Parameters  
 `T`  
 The type to modify.  
  
## Remarks  
 An instance of the type modifier holds a modified-type that is `T` if `T` is an lvalue reference, otherwise `T&`.  
  
## Example  
  
```  
#include <type_traits>   
#include <iostream>   
  
using namespace std;  
int main()  
{  
    int val = 0;  
    add_lvalue_reference_t<int> p = (int&)val;  
    p = p;  // to quiet "unused" warning   
    cout << "add_lvalue_reference_t<int> == "  
        << typeid(p).name() << endl;  
  
    return (0);  
}  
```  
  
  **add_lvalue_reference_t<int\> == int**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)   
 [remove_reference](../vs140/remove_reference-class.md)