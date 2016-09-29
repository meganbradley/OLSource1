---
title: "target_block::unlink_source Method"
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
  - "agents/concurrency::target_block::unlink_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unlink_source method"
ms.assetid: 4264d8fb-0fe2-4dbf-a019-5f046fe408cd
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::unlink_source Method
Unlinks a specified source block from this `target_block` object.  
  
## Syntax  
  
```  
virtual void unlink_source(  
   _Inout_ ISource<_Source_type> * _PSource  
);  
```  
  
#### Parameters  
 `_PSource`  
 A pointer to the `ISource` block that is to be unlinked.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../VS_csharp/target_block-class.md)