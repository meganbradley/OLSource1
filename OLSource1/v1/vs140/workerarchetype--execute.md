---
title: "WorkerArchetype::Execute"
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
  - "WorkerArchetype.Execute"
  - "WorkerArchetype::Execute"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Execute method"
ms.assetid: f5d1de03-b034-4d54-898f-cbdedd68e04d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WorkerArchetype::Execute
Called to process a work item.  
  
## Syntax  
  
```  
  
      void Execute(  
   RequestType request,  
   void* pvWorkerParam,  
   OVERLAPPED* pOverlapped   
);  
```  
  
#### Parameters  
 `request`  
 The work item to be processed. The work item is of the same type as [RequestType](../vs140/workerarchetype--requesttype.md).  
  
 `pvWorkerParam`  
 A custom parameter understood by the worker class. Also passed to [Initialize](../vs140/workerarchetype--initialize.md) and [Terminate](../vs140/workerarchetype--terminate.md).  
  
 `pOverlapped`  
 A pointer to the [OVERLAPPED](http://msdn.microsoft.com/library/windows/desktop/ms684342) structure used to create the queue on which work items were queued.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [Worker Archetype](../vs140/worker-archetype.md)