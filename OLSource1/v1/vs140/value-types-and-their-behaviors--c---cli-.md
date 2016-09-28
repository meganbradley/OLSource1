---
title: "Value Types and Their Behaviors (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Value Types and Their Behaviors (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value types"
ms.assetid: 5cb872a6-1e0a-429d-853d-df4ab47e8f2a
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value Types and Their Behaviors (C++-CLI)
Value types have changed in various ways from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)]. In this section, we look at the CLR enum type and the value class type, together with a look at boxing and access to the boxed instance on the CLR heap, as well as a look at interior and pinning pointers. There have been extensive language changes in this area.  
  
## In This Section  
 [CLR Enum Type](../vs140/value-types-and-their-behaviors--c---cli-.md)  
 Discusses changes in the declaration and behavior of enums.  
  
 [Implicit Boxing](../vs140/implicit-boxing-of-value-types.md)  
 Discusses the motivation for implicit boxing of value types and the consequent changes in behavior.  
  
 [A Tracking Handle to a Boxed Value](../vs140/a-tracking-handle-to-a-boxed-value.md)  
 Discusses how implicit boxing of value types translates to a tracking handle to the boxed value object.  
  
 [Value Type Semantics](../vs140/value-type-semantics.md)  
 Discusses changes to value type semantics, including inherited virtual methods, class default constructors, interior pointers, and pinning pointers.  
  
## See Also  
 [C++/CLI Migration Primer](../vs140/c---cli-migration-primer.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)