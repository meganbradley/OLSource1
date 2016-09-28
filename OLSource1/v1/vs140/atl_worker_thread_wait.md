---
title: "ATL_WORKER_THREAD_WAIT"
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
  - "ATL_WORKER_THREAD_WAIT"
  - "ATLUTIL/ATL_WORKER_THREAD_WAIT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_WORKER_THREAD_WAIT macro"
ms.assetid: 4d209004-47f4-4c6a-98b4-aee49ffb0911
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL_WORKER_THREAD_WAIT
This macro defines the default value in milliseconds that [CWorkerThread::Shutdown](../vs140/cworkerthread--shutdown.md) will wait for the worker thread to shut down.  
  
## Syntax  
  
```  
  
#define ATL_WORKER_THREAD_WAIT  
  
```  
  
## Remarks  
 ATL_WORKER_THREAD_WAIT defaults to 10 seconds. If necessary, you can define your own value for this symbol before including atlutil.h.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)