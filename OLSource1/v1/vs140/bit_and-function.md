---
title: "bit_and Function"
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
  - "bit_and"
  - "functional/std::bit_and"
  - "std.bit_and"
  - "std::bit_and"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bit_and function"
ms.assetid: f82603ca-520e-4f21-83d1-d48956fb6a32
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bit_and Function
A predefined function object that performs the bitwise AND operation (binary `operator&`) on its arguments.  
  
## Syntax  
  
```  
template<class Type = void>  
    struct bit_and : public binary_function<Type, Type, Type> {  
        Type operator()(  
            const Type& Left,   
            const Type& Right  
        )   const;  
    };  
  
// specialized transparent functor for operator&  
template<>  
   struct bit_and<void>  
   {  
      template<class Type1, class Type2>  
      auto operator()(Type1&& Left, Type2&& Right) const  
         -> decltype(std::forward<Type1>(Left)  
            & std::forward<Type2>(Right));  
   };  
  
```  
  
#### Parameters  
 `Type`, `Type1`, `Type2`  
 Any type that supports an `operator&` that takes operands of the specified or inferred types.  
  
 `Left`  
 The left operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type `Type`. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type `Type1`.  
  
 `Right`  
 The right operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type `Type`. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type `Type2`.  
  
## Return Value  
 The result of `Left``&``Right`. The specialized template does perfect forwarding of the result, which has the type that's returned by `operator&`.  
  
## Remarks  
 The `bit_and` functor is restricted to integral types for the basic data types, or to user-defined types that implement binary `operator&`.  
  
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [<functional\>](../vs140/-functional-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)