---
title: "CWinThread::PumpMessage"
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
  - "CWinThread.PumpMessage"
  - "CWinThread::PumpMessage"
  - "PumpMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PumpMessage method"
  - "CWinThread class, overridables"
ms.assetid: 04c22d38-7a1d-4eb7-8974-6b1c26e20a16
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::PumpMessage
Contains the thread's message loop.  
  
## Syntax  
  
```  
  
virtual BOOL PumpMessage( );  
  
```  
  
## Remarks  
 `PumpMessage` contains the thread's message loop. **PumpMessage** is called by `CWinThread` to pump the thread's messages. You can call `PumpMessage` directly to force messages to be processed, or you can override `PumpMessage` to change its default behavior.  
  
 Calling `PumpMessage` directly and overriding its default behavior is recommended for advanced users only.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)