---
title: "context_unblock_unbalanced::context_unblock_unbalanced Constructor"
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
  - "concrt/concurrency::context_unblock_unbalanced::context_unblock_unbalanced"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "context_unblock_unbalanced, constructor"
ms.assetid: c35fea03-54fd-4c3c-9945-71dc50e00705
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# context_unblock_unbalanced::context_unblock_unbalanced Constructor
Constructs a `context_unblock_unbalanced` object.  
  
## Syntax  
  
```  
explicit _CRTIMP context_unblock_unbalanced(  
   _In_z_ const char * _Message  
) throw();  
  
context_unblock_unbalanced() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [context_unblock_unbalanced Class](../vs140/context_unblock_unbalanced-class.md)