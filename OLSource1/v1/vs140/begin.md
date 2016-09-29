---
title: "begin"
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
  - "std.begin"
  - "begin"
  - "xutility/std::end"
  - "iterator/std:end"
  - "std::begin"
dev_langs: 
  - "C++"
ms.assetid: d49a71c1-13b5-495b-a469-c13a037acc71
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# begin
Retrieves an iterator to the first element in a specified container.  
  
## Syntax  
  
```  
template<class Container>  
    auto begin(Container& cont)  
        -> decltype(cont.begin());  
template<class Container>  
    auto begin(const Container& cont)   
        -> decltype(cont.begin());  
template<class Ty, class Size>  
    Ty *begin(Ty (&array)[Size]);  
```  
  
#### Parameters  
 `cont`  
 A container.  
  
 `array`  
 An array of objects of type `Ty`.  
  
## Return Value  
 The first two template functions return `cont.begin()`. The first function is non-constant; the second one is constant.  
  
 The third template function returns `array`.  
  
## Example  
 We recommend that you use this template function in place of container member `begin()` when more generic behavior is required.  
  
```cpp  
// cl.exe /EHsc /nologo /W4 /MTd   
#include <algorithm>  
#include <functional>  
#include <iostream>  
#include <iterator>  
#include <vector>  
  
template <typename C> void reverse_sort(C& c) {  
    using std::begin;  
    using std::end;  
  
    std::sort(begin(c), end(c), std::greater<>());  
}  
  
template <typename C> void print(const C& c) {  
    for (const auto& e : c) {  
        std::cout << e << " ";  
    }  
  
    std::cout << "\n";  
}  
  
int main() {  
    std::vector<int> v = { 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 };  
  
    print(v);  
    reverse_sort(v);  
    print(v);  
  
    std::cout << "--\n";  
  
    int arr[] = { 23, 70, 35, 106, 53, 160, 80, 40, 20, 10, 5, 16, 8, 4, 2, 1 };  
  
    print(arr);  
    reverse_sort(arr);  
    print(arr);  
}  
  
```  
  
```  
Output:  
11 34 17 52 26 13 40 20 10 5 16 8 4 2 1  
52 40 34 26 20 17 16 13 11 10 8 5 4 2 1  
--  
23 70 35 106 53 160 80 40 20 10 5 16 8 4 2 1  
160 106 80 70 53 40 35 23 20 16 10 8 5 4 2 1  
```  
  
 The function `reverse_sort` supports containers of any kind, in addition to regular arrays, because it calls the non-member version of `begin()`. If `reverse_sort` were coded to use the container member `begin()`:  
  
```cpp  
template <typename C> void reverse_sort(C& c) {  
    using std::begin;  
    using std::end;  
  
    std::sort(c.begin(), c.end(), std::greater<>());  
}  
```  
  
 Then sending an array to it would cause this compiler error:  
  
```  
error C2228: left of '.begin' must have class/struct/union  
```  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [cbegin](../vs140/cbegin.md)   
 [cend](../vs140/cend.md)   
 [end](../vs140/end.md)