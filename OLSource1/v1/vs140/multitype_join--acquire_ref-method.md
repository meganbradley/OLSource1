---
title: "multitype_join::acquire_ref Method"
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
  - "agents/concurrency::multitype_join::acquire_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acquire_ref method"
ms.assetid: fe0e2c2a-c1d9-411a-ae62-9371f285a9c3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join::acquire_ref Method
Acquires a reference count on this `multitype_join` messaging block, to prevent deletion.  
  
## Syntax  
  
```  
virtual void acquire_ref(  
   _Inout_ ITarget<_Destination_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to the target block that is calling this method.  
  
## Remarks  
 This method is called by an `ITarget` object that is being linked to this source during the `link_target` method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)