---
title: "nothrow (&lt;new&gt;)"
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
  - "std.nothrow"
  - "nothrow"
  - "std::nothrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nothrow object"
ms.assetid: 4cec5d28-edcc-413f-b3b2-f78638a3faa6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nothrow (&lt;new&gt;)
Provides an object to be used as an argument for the `nothrow` versions of **new** and **delete**.  
  
## Syntax  
  
```  
extern const std::nothrow_t nothrow;  
```  
  
## Remarks  
 The object is used as a function argument to match the parameter type [std::nothrow_t](../vs140/nothrow_t-structure.md).  
  
## Example  
 See [operator new](../vs140/operator-new---new--.md) and [operator new&#91;&#93;](../vs140/operator-new--new--.md) for examples of how `std::nothrow_t` is used as a function parameter.  
  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std