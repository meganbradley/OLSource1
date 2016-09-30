---
title: "get Function &lt;array&gt;"
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
  - "get"
  - "std::tr1::get"
  - "array/std::tr1::get"
  - "std.tr1.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get function [TR1]"
ms.assetid: 329a52b8-1c2a-4567-b784-996abbb8678b
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# get Function &lt;array&gt;
Returns a reference to `arr[Index]`.  
  
## Syntax  
  
```  
  
template<int Index, class T, size_t N>  
constexpr T& get(array<T, N>& arr) noexcept;  
  
template<int Index, class T, size_t N>  
constexpr const T& get(const array<T, N>& arr) noexcept;  
  
template<int Index, class T, size_t N>  
constexpr T&& get(array<T, N>&& arr) noexcept;  
```  
  
#### Parameters  
 `Index`  
 The element offset.  
  
 `T`  
 The type of an element.  
  
 `N`  
 The number of elements in the array.  
  
 `arr`  
 The array to select from.  
  
## Example  
  
```  
#include <array>   
#include <iostream>   
  
using namespace std;  
  
typedef array<int, 4> MyArray;  
  
int main()  
{  
    MyArray c0 { 0, 1, 2, 3 };  
  
    // display contents " 0 1 2 3"   
    for (const auto& e : c0)  
    {  
        cout << " " << e;  
    }  
    cout << endl;  
  
    // display odd elements " 1 3"   
    cout << " " << get<1>(c0);  
    cout << " " << get<3>(c0) << endl;  
}  
  
/*  
Output:  
0 1 2 3  
1 3  
*/  
```  
  
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [tuple_element](../vs140/tuple_element-class--array-.md)