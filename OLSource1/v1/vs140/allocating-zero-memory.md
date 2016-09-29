---
title: "Allocating Zero Memory"
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
  - "C"
helpviewer_keywords: 
  - "memory allocation, zero memory"
  - "zero memory"
ms.assetid: 768f2ab9-83a1-4887-8eb5-c094c18489a8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Allocating Zero Memory
**ANSI 4.10.3** The behavior of the `calloc`, `malloc`, or `realloc` function if the size requested is zero  
  
 The `calloc`, `malloc`, and `realloc` functions accept zero as an argument. No actual memory is allocated, but a valid pointer is returned and the memory block can be modified later by realloc.  
  
## See Also  
 [Library Functions](../vs140/library-functions.md)