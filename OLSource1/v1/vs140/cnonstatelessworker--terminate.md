---
title: "CNonStatelessWorker::Terminate"
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
  - CNonStatelessWorker<Worker>::Terminate
  - CNonStatelessWorker::Terminate
  - ATL::CNonStatelessWorker::Terminate
  - CNonStatelessWorker.Terminate
  - ATL.CNonStatelessWorker.Terminate
  - ATL::CNonStatelessWorker<Worker>::Terminate
dev_langs: 
  - C++
helpviewer_keywords: 
  - Terminate method
ms.assetid: 0e1a6c79-f759-49e9-8ee2-4328629f1962
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CNonStatelessWorker::Terminate
Implementation of [WorkerArchetype::Terminate](../vs140/workerarchetype--terminate.md).  
  
## Syntax  
  
```  
  
      void Terminate(  
   void* /*pvParam*/  
) throw( );  
```  
  
## Remarks  
 This class does not do any cleanup in `Terminate`.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CNonStatelessWorker Class](../vs140/cnonstatelessworker-class.md)