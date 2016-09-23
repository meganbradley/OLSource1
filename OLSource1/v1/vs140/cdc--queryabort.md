---
title: "CDC::QueryAbort"
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
  - CDC::QueryAbort
  - QueryAbort
  - CDC.QueryAbort
dev_langs: 
  - C++
helpviewer_keywords: 
  - QueryAbort method
  - CDC class, printer escape functions
ms.assetid: 24c23370-94e2-433c-a886-89755c3ce7e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::QueryAbort
Calls the abort function installed by the [SetAbortProc](../vs140/cdc--setabortproc.md) member function for a printing application and queries whether the printing should be terminated.  
  
## Syntax  
  
```  
  
BOOL QueryAbort( ) const;  
```  
  
## Return Value  
 The return value is nonzero if printing should continue or if there is no abort procedure. It is 0 if the print job should be terminated. The return value is supplied by the abort function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetAbortProc](../vs140/cdc--setabortproc.md)