---
title: "CNonStatelessWorker::Execute"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CNonStatelessWorker.Execute
  - CNonStatelessWorker::Execute
  - ATL::CNonStatelessWorker<Worker>::Execute
  - CNonStatelessWorker.Execute
  - CNonStatelessWorker<Worker>::Execute
  - ATL.CNonStatelessWorker<Worker>.Execute
  - ATL::CNonStatelessWorker::Execute
dev_langs: 
  - C++
helpviewer_keywords: 
  - Execute method
ms.assetid: a8205d96-087f-4813-97ff-5ac783d9c259
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CNonStatelessWorker::Execute
Implementation of [WorkerArchetype::Execute](../vs140/workerarchetype--execute.md).  
  
## Syntax  
  
```  
  
      void Execute(  
   Worker::RequestType request,  
   void* pvWorkerParam,  
   OVERLAPPED* pOverlapped   
);  
```  
  
## Remarks  
 This method creates an instance of the *Worker* class on the stack and calls [Initialize](../vs140/workerarchetype--initialize.md) on that object. If the initialization is successful, this method also calls [Execute](../vs140/workerarchetype--execute.md) and [Terminate](../vs140/workerarchetype--terminate.md) on the same object.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CNonStatelessWorker Class](../vs140/cnonstatelessworker-class.md)