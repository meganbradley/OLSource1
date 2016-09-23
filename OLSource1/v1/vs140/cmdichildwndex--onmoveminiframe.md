---
title: "CMDIChildWndEx::OnMoveMiniFrame"
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
  - CMDIChildWndEx.OnMoveMiniFrame
  - CMDIChildWndEx::OnMoveMiniFrame
  - OnMoveMiniFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnMoveMiniFrame method
ms.assetid: fb774296-99e6-4193-a3e0-f9e431e27dfd
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIChildWndEx::OnMoveMiniFrame
Called by the framework to move a mini-frame window.  
  
## Syntax  
  
```  
virtual BOOL OnMoveMiniFrame(  
   CWnd* pFrame  
);  
```  
  
#### Parameters  
 [in] `pFrame`  
 A pointer to a mini-frame window.  
  
## Return Value  
 `TRUE` if the method succeeds, otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)