---
title: "bit_xor Function"
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
  - "std::bit_xor"
  - "functional/std::bit_xor"
  - "std.bit_xor"
  - "bit_xor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bit_xor function"
ms.assetid: 6229738c-941e-49bb-87c9-37b2287529a9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bit_xor Function
A predefined function object that performs the bitwise XOR operation (binary `operator^`) on its arguments.  
  
## Syntax  
  
```  
template<class Type = void>  
   struct bit_xor : public binary_function< Type, Type, Type > {  
      Type operator()(  
         const Type& Left,   
         const Type& Right  
      ) const;  
   };  
  
// specialized transparent functor for operator^  
template<>  
   struct bit_xor<void>  
   {  
      template<class Type1, class Type2>  
      auto operator()(Type1&& Left, Type2&& Right) const  
         -> decltype(std::forward<Type1>(Left)  
            ^ std::forward<Type2>(Right));  
   };  
  
```  
  
#### Parameters  
 `Type`, `Type1`, `Type2`  
 Any type that supports an `operator^` that takes operands of the specified or inferred types.  
  
 `Left`  
 The left operand of the bitwise XOR operation. The unspecialized template takes an lvalue reference argument of type `Type`. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type `Type1`.  
  
 `Right`  
 The right operand of the bitwise XOR operation. The unspecialized template takes an lvalue reference argument of type `Type`. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type `Type2`.  
  
## Return Value  
 The result of `Left``^``Right`. The specialized template does perfect forwarding of the result, which has the type that's returned by `operator^`.  
  
## Remarks  
 The `bit_xor` functor is restricted to integral types for the basic data types, or to user-defined types that implement binary `operator^`.  
  
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [<functional\>](../vs140/-functional-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)