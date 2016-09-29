---
title: "overwrite_buffer::has_value Method"
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
  - "agents/concurrency::overwrite_buffer::has_value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_value method"
ms.assetid: 26befe72-492f-4a10-83b9-20800cc409a0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer::has_value Method
Checks whether this `overwrite_buffer` messaging block has a value yet.  
  
## Syntax  
  
```  
bool has_value() const;  
```  
  
## Return Value  
 `true` if the block has received a value, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../VS_csharp/overwrite_buffer-class.md)