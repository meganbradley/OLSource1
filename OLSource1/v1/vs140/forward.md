---
title: "forward"
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
  - "utility/std::forward"
  - "std.forward"
  - "forward"
  - "std::forward"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "forward"
  - "forward method"
ms.assetid: 29089bd6-b556-4eb7-8e74-5cdb8137930e
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward
Conditionally casts its argument to an rvalue reference if the argument is an rvalue or rvalue reference. This restores the rvalue-ness of an argument to the forwarding function in support of perfect forwarding.  
  
## Syntax  
  
```  
template<class Type>    // accepts lvalues  
constexpr Type&& forward(typename remove_reference<Type>::type& Arg) noexcept  
  
template<class Type>    // accepts everything else  
constexpr Type&& forward(typename remove_reference<Type>::type&& Arg) noexcept  
  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Type`|The type of the value passed in `Arg`, which might be different than the type of `Arg`. Typically determined by a template argument of the forwarding function.|  
|`Arg`|The argument to cast.|  
  
## Return Value  
 Returns an rvalue reference to `Arg` if the value passed in `Arg` was originally an rvalue or a reference to an rvalue; otherwise, returns `Arg` without modifying its type.  
  
## Remarks  
 You must specify an explicit template argument to call `forward`.  
  
 `forward` does not forward its argument. Instead, by conditionally casting its argument to an rvalue reference if it was originally an rvalue or rvalue reference, `forward` enables the compiler to perform overload resolution with knowledge of the forwarded argument's original type. The apparent type of an argument to a forwarding function might be different than its original type—for example, when an rvalue is used as an argument to a function and is bound to a parameter name; having a name makes it an lvalue, regardless of whether the value actually exists as an rvalue—`forward` restores the rvalue-ness of the argument.  
  
 Restoring the rvalue-ness of an argument's original value in order to perform overload resolution is known as *perfect forwarding*. Perfect forwarding enables a template function to accept an argument of either reference type and to restore its rvalue-ness when it's necessary for correct overload resolution. By using perfect forwarding, you can preserve move semantics for rvalues and avoid having to provide overloads for functions that vary only by the reference type of their arguments.  
  
## Requirements  
 **Header:** <utility\>  
  
 **Namespace:** std  
  
## See Also  
 [<utility\>](../vs140/-utility-.md)   
 [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)