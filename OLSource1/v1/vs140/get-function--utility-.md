---
title: "get Function &lt;utility&gt;"
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
  - "std.tr1.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get function [TR1]"
ms.assetid: 2426d22e-f6d6-4c22-ba90-4de5fd0ea4e7
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# get Function &lt;utility&gt;
Gets an element from a `pair` object by index position, or by type.  
  
## Syntax  
  
```  
// get reference to element at Index in pair Pr  
template<size_t Index, class T1, class T2>  
constexpr tuple_element_t<Index, pair<T1, T2> >&  
get(pair<T1, T2>& Pr) noexcept;  
  
// get reference to element T1 in pair Pr  
template<class T1, class T2>  
constexpr T1& get(pair<T1, T2>& Pr) noexcept;  
  
// get reference to element T2 in pair Pr  
template<class T2, class T1>  
constexpr T2& get(pair<T1, T2>& Pr) noexcept;  
  
// get const reference to element at Index in pair Pr  
template<size_t Index, class T1, class T2>  
constexpr const tuple_element_t<Index, pair<T1, T2> > &  
get(const pair<T1, T2>& Pr) noexcept;  
  
// get const reference to element T1 in pair Pr  
template<class T1, class T2>  
constexpr const T1& get(const pair<T1, T2>& Pr) noexcept;  
  
// get const reference to element T2 in pair Pr  
template<class T2, class T1>  
constexpr const T2& get(const pair<T1, T2>& Pr) noexcept;  
  
// get rvalue reference to element at Index in pair Pr  
template<size_t Index, class T1, class T2>  
constexpr tuple_element_t<Index, pair<T1, T2> > &&  
get(pair<T1, T2>&& Pr) noexcept;  
  
// get rvalue reference to element T1 in pair Pr  
template<class T1, class T2>  
constexpr T1&& get(pair<T1, T2>&& Pr) noexcept;  
  
// get rvalue reference to element T2 in pair Pr  
template<class T2, class T1>  
constexpr T2&& get(pair<T1, T2>&& Pr) noexcept;  
```  
  
#### Parameters  
 `Index`  
 The 0-based index of the designated element.  
  
 `T1`  
 The type of the first pair element.  
  
 `T2`  
 The type of the second pair element.  
  
 `pr`  
 The pair to select from.  
  
## Remarks  
 The template functions each return a reference to an element of its `pair` argument.  
  
 For the indexed overloads, if the value of `Index` is 0 the functions return `pr.first` and if the value of `Index` is 1 the functions return `pr.second`. The type `RI` is the type of the returned element.  
  
 For the overloads that do not have an Index parameter, the element to return is deduced by the type argument. Calling `get<T>(Tuple)` will produce a compiler error if `pr` contains more or less than one element of type T.  
  
## Example  
  
```  
#include <utility>  
#include <iostream>   
using namespace std;  
int main()  
{  
  
typedef pair<int, double> MyPair;  
  
MyPair c0(9, 3.14);  
  
// get elements by index  
cout << " " << get<0>(c0);  
cout << " " << get<1>(c0) << endl;  
  
// get elements by type (C++14)  
MyPair c1(1, 0.27);  
cout << " " << get<int>(c1);  
cout << " " << get<double>(c1) << endl;  
  
/*  
Output:  
9 3.14  
1 0.27  
*/  
  
}  
```  
  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)   
 [tuple_element](../vs140/tuple_element-class--utility-.md)   
 [tuple_size](../vs140/tuple_size-class--utility-.md)