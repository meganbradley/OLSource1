---
title: "alloca"
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
ms.assetid: 2b209335-e3a0-4934-93f0-3b5925d22918
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# alloca
[_alloca](../vs140/_alloca.md) is required to be 16-byte aligned and additionally required to use a frame pointer.  
  
 The stack that is allocated needs to include space below it for parameters of subsequently called functions, as discussed in [Stack Allocation](../vs140/stack-allocation.md).  
  
## See Also  
 [Stack Usage](../vs140/stack-usage.md)