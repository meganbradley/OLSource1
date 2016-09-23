---
title: "CWinThread::m_nThreadID"
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
  - CWinThread.m_nThreadID
  - m_nThreadID
  - CWinThread::m_nThreadID
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinThread class, data members
  - m_nThreadID
ms.assetid: 20bfe043-48ac-4156-80b2-deea74e82dbc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinThread::m_nThreadID
ID of the thread attached to this `CWinThread`.  
  
## Syntax  
  
```  
DWORD m_nThreadID;  
```  
  
## Remarks  
 The **m_nThreadID** data member is a public variable of type `DWORD`. It is only valid if underlying thread currently exists.  
  
## Example  
 See the example for [AfxGetThread](../vs140/afxgetthread.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)