---
title: "Worker Archetype"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Worker archetype"
ms.assetid: 834145cd-09d3-4149-bc99-620e1871cbfb
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Worker Archetype
Classes that conform to the *worker* archetype provide the code to process work items queued on a thread pool.  
  
 **Implementation**  
  
 To implement a class conforming to this archetype, the class must provide the following features:  
  
|Method|Description|  
|------------|-----------------|  
|[Initialize](../vs140/workerarchetype--initialize.md)|Called to initialize the worker object before any requests are passed to [Execute](../vs140/workerarchetype--execute.md).|  
|[Execute](../vs140/workerarchetype--execute.md)|Called to process a work item.|  
|[Terminate](../vs140/workerarchetype--terminate.md)|Called to uninitialize the worker object after all requests have been passed to [Execute](../vs140/workerarchetype--execute.md).|  
  
|Typedef|Description|  
|-------------|-----------------|  
|[RequestType](../vs140/workerarchetype--requesttype.md)|A typedef for the type of work item that can be processed by the worker class.|  
  
 A typical *worker* class looks like this:  
  
 [!code[NVC_ATL_Utilities#137](../vs140/codesnippet/CPP/worker-archetype_1.cpp)]  
  
 **Existing Implementations**  
  
 These classes conform to this archetype:  
  
|Class|Description|  
|-----------|-----------------|  
|[CNonStatelessWorker](../vs140/cnonstatelessworker-class.md)|Receives requests from the thread pool and passes them on to a worker object that is created and destroyed for each request.|  
  
 **Use**  
  
 These template parameters expect the class to conform to this archetype:  
  
|Parameter name|Used by|  
|--------------------|-------------|  
|*Worker*|[CThreadPool](../vs140/cthreadpool-class.md)|  
|*Worker*|[CNonStatelessWorker](../vs140/cnonstatelessworker-class.md)|  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Archetypes](../vs140/atl-archetypes.md)   
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)