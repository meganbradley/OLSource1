---
title: "extent Class"
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
  - "std.tr1.extent"
  - "extent"
  - "std::tr1::extent"
  - "std.extent"
  - "std::extent"
  - "type_traits/std::extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extent class [TR1]"
  - "extent"
ms.assetid: 6d16263d-90b2-4330-9ec7-b59ed898792d
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# extent Class
Gets an array dimension.  
  
## Syntax  
  
```  
template<class Ty, unsigned I = 0>  
    struct extent;  
```  
  
#### Parameters  
 `Ty`  
 The type to query.  
  
 `I`  
 The array bound to query.  
  
## Remarks  
 If `Ty` is an array type that has at least `I` dimensions, the type query holds the number of elements in the dimension specified by `I`. If `Ty` is not an array type or its rank is less than `I`, or if `I` is zero and `Ty` is of type "array of unknown bound of `U`", the type query holds the value 0.  
  
## Example  
  
```  
// std_tr1__type_traits__extent.cpp   
// compile with: /EHsc   
#include <type_traits>   
#include <iostream>   
  
int main()   
    {   
    std::cout << "extent 0 == "   
        << std::extent<int[5][10]>::value << std::endl;   
    std::cout << "extent 1 == "   
        << std::extent<int[5][10], 1>::value << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **extent 0 == 5**  
**extent 1 == 10**    
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../VS_csharp/-type_traits-.md)   
 [remove_all_extents](../VS_csharp/remove_all_extents-class.md)   
 [remove_extent](../VS_csharp/remove_extent-class.md)