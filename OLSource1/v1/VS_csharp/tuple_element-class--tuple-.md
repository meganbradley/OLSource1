---
title: "tuple_element Class &lt;tuple&gt;"
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
  - "std.tr1.tuple_element"
  - "tuple_element"
  - "std::tr1::tuple_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tuple_element Class <tuple> (TR1)"
ms.assetid: 4c51a6c1-ce81-462f-8c6c-291d69f2b77c
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# tuple_element Class &lt;tuple&gt;
Wraps a `tuple` element.  
  
## Syntax  
  
```  
// CLASS tuple_element (find element by index)  
template<size_t Index, class Tuple>  
struct tuple_element;  
  
// tuple_element for const  
template<size_t Index, class Tuple>  
struct tuple_element<Index, const Tuple>;  
  
// tuple_element for volatile  
template<size_t Index, class Tuple>  
struct tuple_element<Index, volatile Tuple>;  
  
// tuple_element for const volatile  
template<size_t Index, class Tuple>  
struct tuple_element<Index, const volatile Tuple>;  
  
template<size_t Index, class Tuple>  
using tuple_element_t = typename tuple_element<Index, Tuple>::type;  
  
```  
  
#### Parameters  
 `Index`  
 The index of the designated element.  
  
 `Tuple`  
 The type of the tuple.  
  
## Remarks  
 The template class has a nested typedef `type` that is a synonym for the type at index `Index` of the tuple type `Tuple`.  
  
## Example  
  
```  
#include <tuple>  
#include <string>  
#include <iostream>  
  
using namespace std;  
typedef tuple<int, double, string> MyTuple;  
  
int main()  
{  
  
    MyTuple c0{ 0, 1.5, "Tail" };  
  
    tuple_element_t<0, MyTuple> val = get<0>(c0); //get by index  
    tuple_element_t<1, MyTuple> val2 = get<1>(c0);  
    tuple_element_t<2, MyTuple> val3 = get<string>(c0); // get by type  
  
    cout << val << " " << val2 << " " << val3 << endl;  
}  
  
/*  
Output:  
0 1.5 Tail  
*/  
```  
  
## Requirements  
 **Header:** <tuple\>  
  
 **Namespace:** std  
  
## See Also  
 [<tuple\>](../VS_csharp/-tuple-.md)   
 [tuple](../VS_csharp/tuple-class.md)   
 [tuple_element](../VS_csharp/tuple_element-class--tuple-.md)