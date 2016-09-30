---
title: "remove_extent Class"
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
  - "std::tr1::remove_extent"
  - "std.tr1.remove_extent"
  - "remove_extent"
  - "std.remove_extent"
  - "std::remove_extent"
  - "type_traits/std::remove_extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_extent class [TR1]"
  - "remove_extent"
ms.assetid: b9320862-3891-49fc-80bc-571eb2c035cf
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# remove_extent Class
Makes element type from array type.  
  
## Syntax  
  
```  
template<class T>  
    struct remove_extent;  
  
template<class T>  
using remove_extent_t = typename remove_extent<T>::type;  
```  
  
#### Parameters  
 `T`  
 The type to modify.  
  
## Remarks  
 An instance of `remove_extent<T>` holds a modified-type that is `T1` when `T` is of the form `T1[N]`, otherwise `T`.  
  
## Example  
  
```  
#include <type_traits>   
#include <iostream>   
  
int main()   
    {   
    std::cout << "remove_extent_t<int> == "  
        << typeid(std::remove_extent_t<int>).name()  
        << std::endl;T  
    std::cout << "remove_extent_t<int[5]> == "  
        << typeid(std::remove_extent_t<int[5]>).name()  
        << std::endl;T  
    std::cout << "remove_extent_t<int[5][10]> == "  
        << typeid(std::remove_extent_t<int[5][10]>).name()  
        << std::endl;   
    return (0);   
    }  
  
```  
  
  **remove_extent_t\<int> == int**  
**remove_extent_t\<int[5]> == int**  
**remove_extent_t\<int[5][10]> == int [10]**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)   
 [remove_all_extents](../vs140/remove_all_extents-class.md)