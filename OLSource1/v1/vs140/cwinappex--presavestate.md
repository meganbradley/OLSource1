---
title: "CWinAppEx::PreSaveState"
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
  - CWinAppEx::PreSaveState
  - PreSaveState
  - CWinAppEx.PreSaveState
dev_langs: 
  - C++
helpviewer_keywords: 
  - PreSaveState method
ms.assetid: 61c5c221-0088-497a-8540-a5d4ff942a40
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinAppEx::PreSaveState
The framework calls this method immediately before it saves the application state.  
  
## Syntax  
  
```  
virtual void PreSaveState();  
```  
  
## Remarks  
 Override this method if you want to do any processing immediately before the framework saves the application state.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)