---
title: "CWinThread::m_bAutoDelete"
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
  - "CWinThread.m_bAutoDelete"
  - "CWinThread::m_bAutoDelete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bAutoDelete"
  - "CWinThread class, data members"
ms.assetid: c4cd5f2a-31f9-45fe-8bfe-ef5af16d699c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::m_bAutoDelete
Specifies whether the `CWinThread` object should be automatically deleted at thread termination.  
  
## Syntax  
  
```  
  
BOOL m_bAutoDelete;  
  
```  
  
## Remarks  
 The `m_bAutoDelete` data member is a public variable of type **BOOL**.  
  
 The value of `m_bAutoDelete` does not affect how the underlying thread handle is closed. The thread handle is always closed when the `CWinThread` object is destroyed.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxBeginThread](../vs140/afxbeginthread.md)   
 [CWinThread::ResumeThread](../vs140/cwinthread--resumethread.md)