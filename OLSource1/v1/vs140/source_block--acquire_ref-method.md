---
title: "source_block::acquire_ref Method"
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
  - "agents/concurrency::source_block::acquire_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acquire_ref method"
ms.assetid: b638c8a2-fc39-4224-bf68-856af748f5b3
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::acquire_ref Method
Acquires a reference count on this `source_block` object, to prevent deletion.  
  
## Syntax  
  
```  
virtual void acquire_ref(  
   _Inout_ ITarget<_Target_type> *  
);  
```  
  
## Remarks  
 This method is called by an `ITarget` object that is being linked to this source during the `link_target` method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)