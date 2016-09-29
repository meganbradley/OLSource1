---
title: "CNonStatelessWorker::Initialize"
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
  - "ATL::CNonStatelessWorker<Worker>::Initialize"
  - "Initialize"
  - "CNonStatelessWorker<Worker>::Initialize"
  - "ATL.CNonStatelessWorker.Initialize"
  - "CNonStatelessWorker.Initialize"
  - "ATL::CNonStatelessWorker::Initialize"
  - "CNonStatelessWorker::Initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Initialize method"
ms.assetid: 731cdf31-d481-46bc-9ef2-1526d31e7156
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNonStatelessWorker::Initialize
Implementation of [WorkerArchetype::Initialize](../vs140/workerarchetype--initialize.md).  
  
## Syntax  
  
```  
  
      BOOL Initialize(  
   void* /*pvParam*/  
) throw( );  
```  
  
## Return Value  
 Always returns TRUE.  
  
## Remarks  
 This class does not do any initialization in `Initialize`.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CNonStatelessWorker Class](../vs140/cnonstatelessworker-class.md)