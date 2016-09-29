---
title: "typeof Goes to T::typeid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "typeid operator"
  - "__typeof keyword"
  - "typeid keyword [C++]"
ms.assetid: 6a0d35a7-7a1a-4070-b187-cff37cfdc205
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typeof Goes to T::typeid
The `typeof` operator used in Managed Extensions for C++ has been supplanted by the `typeid` keyword in [!INCLUDE[cpp_current_long](../VS_csharp/includes/cpp_current_long_md.md)].  
  
 In Managed Extensions, the `__typeof()` operator returns the associated `Type*` object when passed the name of a managed type. For example:  
  
```  
// Creates and initializes a new Array instance.  
Array* myIntArray =   
   Array::CreateInstance( __typeof(Int32), 5 );  
```  
  
 In the new syntax, `__typeof` has been replaced by an additional form of `typeid` that returns a `Type^` when a managed type is specified.  
  
```  
// Creates and initializes a new Array instance.  
Array^ myIntArray =   
   Array::CreateInstance( Int32::typeid, 5 );  
```  
  
## See Also  
 [General Language Changes](../VS_csharp/general-language-changes--c---cli-.md)   
 [typeid](../VS_csharp/typeid---c---component-extensions-.md)