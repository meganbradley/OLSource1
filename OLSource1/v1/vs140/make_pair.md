---
title: "make_pair"
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
  - "std.make_pair"
  - "make_pair"
  - "utility/std::make_pair"
  - "std::make_pair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_pair"
  - "make_pair function"
ms.assetid: d4cc3871-ec32-469c-b96a-8e1409a62a0b
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_pair
A template function that you can use to construct objects of type `pair`, where the component types are automatically chosen based on the data types that are passed as parameters.  
  
## Syntax  
  
```  
template<class Type1, class Type2>   
  pair<Type1, Type2> make_pair(Type1& Val1, Type2& Val2);  
template<class Type1, class Type2>   
  pair<Type1, Type2> make_pair(Type1& Val1, Type2&& Val2);   
template<class Type1, class Type2>   
  pair<Type1, Type2> make_pair(Type1&& Val1, Type2& Val2);   
template<class Type1, class Type2>   
  pair<Type1, Type2> make_pair(Type1&& Val1, Type2&& Val2);  
```  
  
#### Parameters  
 `Val1`  
 Value that initializes the first element of `pair`.  
  
 `Val2`  
 Value that initializes the second element of `pair`.  
  
## Return Value  
 The pair object that's constructed: `pair`<`Type1`, `Type2`>(`Val1`, `Val2`).  
  
## Remarks  
 `make_pair` converts object of type [reference_wrapper](../vs140/reference_wrapper-class.md) to reference types and converts decaying arrays and functions to pointers.  
  
 In the returned `pair` object, `Type1` is determined as follows:  
  
-   If the input type `Type1` is `reference_wrapper<X>`, the returned type `Type1` is `X&`.  
  
-   Otherwise, the returned type `Type1` is `decay<Type1>::type`. If [decay](../vs140/decay-class.md) is not supported, the returned type `Type1` is the same as the input type `Type1`.  
  
 The returned type `Type2` is similarly determined from the input type `Type2`.  
  
 One advantage of `make_pair` is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as `make_pair<int, int>(1, 2)` when you use `make_pair` because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure. For this example, the correct syntax would be `make_pair(1, 2)`  
  
 The `make_pair` helper function also makes it possible to pass two values to a function that requires a pair as an input parameter.  
  
## Example  
 For an example about how to use the helper function `make_pair` to declare and initialize a pair, see [pair Structure](../vs140/pair-structure.md).  
  
## Requirements  
 **Header:** <utility\>  
  
 **Namespace:** std  
  
## See Also  
 [<utility\>](../vs140/-utility-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)