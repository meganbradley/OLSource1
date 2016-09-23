---
title: "overwrite_buffer::supports_anonymous_source Method"
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
  - agents/concurrency::overwrite_buffer::supports_anonymous_source
dev_langs: 
  - C++
helpviewer_keywords: 
  - supports_anonymous_source method
ms.assetid: 42a2ec54-a4ff-4ae4-8f60-233828f6a363
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# overwrite_buffer::supports_anonymous_source Method
Overrides the `supports_anonymous_source` method to indicate that this block can accept messages offered to it by a source that is not linked.  
  
## Syntax  
  
```  
virtual bool supports_anonymous_source();  
```  
  
## Return Value  
 `true` because the block does not postpone offered messages.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)