---
title: "General Language Changes (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "General Language Changes (C++/CLI)"
dev_langs: 
  - "C++"
ms.assetid: 79a70768-225c-4ae2-84d1-178b20a9b042
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# General Language Changes (C++-CLI)
A number of CLR language features changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 The changes described in this section are a sort of language miscellany. It includes a change in the handling of string literals, a change in the overload resolution between an ellipsis and the `Param` attribute, the change of `typeof` to `typeid`, a change in the calling of constructor initializer lists, and the introduction of a new cast notation, that of `safe_cast`.  
  
 [String Literal](../vs140/string-literal.md)  
 Discusses how the handling of string literals has changed.  
  
 [Param Array and Ellipsis](../vs140/param-array-and-ellipsis.md)  
 Discusses how `ParamArray` is now given precedence over the ellipsis (`…`) for resolving function calls with varying numbers of arguments.  
  
 [Typeof Goes to T::typeid](../vs140/typeof-goes-to-t--typeid.md)  
 Discusses how the `typeof` operator has been supplanted by `typeid`.  
  
 [Initializer Lists](../vs140/initializer-lists.md)  
 Discusses changes in the calling order of initializer lists.  
  
 [Cast Notation and Introduction of safe_cast<>](../vs140/cast-notation-and-introduction-of-safe_cast--.md)  
 Discusses changes to cast notation and in particular the introduction of `safe_cast`.  
  
## See Also  
 [C++/CLI Migration Primer](../vs140/c---cli-migration-primer.md)