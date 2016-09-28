---
title: "CWinThread::CWinThread"
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
  - "CWinThread::CWinThread"
  - "CWinThread.CWinThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinThread class, construction"
ms.assetid: b7cc4951-978f-4bb0-af2a-dd5cb93d7989
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::CWinThread
Constructs a `CWinThread` object.  
  
## Syntax  
  
```  
  
CWinThread( );  
```  
  
## Remarks  
 To begin the thread's execution, call the [CreateThread](../vs140/cwinthread--createthread.md) member function. You will usually create threads by calling [AfxBeginThread](../vs140/afxbeginthread.md), which will call this constructor and `CreateThread`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinThread::CreateThread](../vs140/cwinthread--createthread.md)