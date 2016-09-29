---
title: "result_of Class1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "result_of Class"
f1_keywords: 
  - "result_of"
  - "std.result_of"
  - "std::result_of"
  - "type_traits/std::result_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "result_of"
ms.assetid: 5374a096-4b4a-4712-aa97-6852c5cdd6be
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# result_of Class1
Determines the return type of the callable type that takes the specified argument types.  
  
## Syntax  
  
```  
template <class Fn, class... ArgTypes>  
    struct result_of<Fn(ArgTypes...)>;  
```  
  
#### Parameters  
 `Fn`  
 The callable type to query.  
  
 `ArgTypes`  
 The types of the argument list to the callable type to query.  
  
## Remarks  
 Use this template to determine at compile time the result type of `Fn`(`ArgTypes`), where `Fn` is a callable type invoked with an argument list of the types in `ArgTypes`. The `type` member of the template class names the result type of `decltype(INVOKE(declval<Fn>(), declval<ArgTypes>()...))` if the unevaluated expression `INVOKE(declval<Fn>(), declval<ArgTypes>()...)` is well-formed. Otherwise, the template class has no member `type`. The type `Fn` and all types in the parameter pack `ArgTypes` must be complete types, `void`, or arrays of unknown bound.  
  
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)