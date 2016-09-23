---
title: "bit_not Function"
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
  - bit_not
  - functional/std::bit_not
  - std::bit_not
  - std.bit_not
dev_langs: 
  - C++
helpviewer_keywords: 
  - bit_not function
ms.assetid: 3680129d-96a3-4a86-8874-c5de91ef47ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# bit_not Function
A predefined function object that performs the bitwise complement (NOT) operation (unary `operator~`) on its argument.  
  
## Syntax  
  
```  
template<class Type = void>  
   struct bit_not : public unary_function<Type, Type>   
   {  
      Type operator()(const Type& Right) const;  
   };  
  
// specialized transparent functor for operator~  
template<>   
   struct bit_not<void>   
   {  
      template<class Type>  
      auto operator()(Type&& Right) const   
         -> decltype(~std::forward<Type>(Right));  
   };  
```  
  
#### Parameters  
 `Type`  
 A type that supports a unary `operator~`.  
  
 `Right`  
 The operand of the bitwise complement operation. The unspecialized template takes an lvalue reference argument of type `Type`. The specialized template does perfect forwarding of an lvalue or rvalue reference argument of inferred type `Type`.  
  
## Return Value  
 The result of `~``Right`. The specialized template does perfect forwarding of the result, which has the type that's returned by `operator~`.  
  
## Remarks  
 The `bit_not` functor is restricted to integral types for the basic data types, or to user-defined types that implement binary `operator~`.  
  
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [<functional\>](../vs140/-functional-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)