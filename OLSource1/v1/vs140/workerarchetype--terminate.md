---
title: "WorkerArchetype::Terminate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "WorkerArchetype.Terminate"
  - "WorkerArchetype::Terminate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Terminate method"
ms.assetid: 9bb841f2-fed6-4808-a2af-440b25ec91db
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WorkerArchetype::Terminate
Called to uninitialize the worker object after all requests have been passed to [Execute](../vs140/workerarchetype--execute.md).  
  
## Syntax  
  
```  
  
      void Terminate(  
   void* pvParam  
) throw( );  
```  
  
#### Parameters  
 `pvParam`  
 A custom parameter understood by the worker class. Also passed to [Initialize](../vs140/workerarchetype--initialize.md) and [Execute](../vs140/workerarchetype--execute.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [Worker Archetype](../vs140/worker-archetype.md)