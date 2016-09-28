---
title: "CThreadPool::GetQueueHandle"
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
  - "CThreadPool.GetQueueHandle"
  - "ATL::CThreadPool::GetQueueHandle"
  - "CThreadPool::GetQueueHandle"
  - "ATL.CThreadPool.GetQueueHandle"
  - "GetQueueHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetQueueHandle method"
ms.assetid: 039c5ba7-d769-4ed7-86a9-840e40f0f967
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::GetQueueHandle
Call this method to get the handle of the IO completion port used to queue work items.  
  
## Syntax  
  
```  
  
HANDLE GetQueueHandle( ) throw( );  
  
```  
  
## Return Value  
 Returns the queue handle or NULL if the thread pool has not been initialized.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)