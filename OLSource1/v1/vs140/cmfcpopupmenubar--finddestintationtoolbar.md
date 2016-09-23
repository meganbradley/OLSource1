---
title: "CMFCPopupMenuBar::FindDestintationToolBar"
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
  - FindDestintationToolBar
  - CMFCPopupMenuBar.FindDestintationToolBar
  - CMFCPopupMenuBar::FindDestintationToolBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindDestintationToolBar method
ms.assetid: 9e4f3e8f-482e-4640-b3b9-ced21d58c41f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenuBar::FindDestintationToolBar
Locates the toolbar where a specified point lies.  
  
## Syntax  
  
```  
CMFCToolBar* FindDestintationToolBar(  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `point`  
 A point on the screen.  
  
## Return Value  
 Returns a handle to the toolbar where the point lies, if therei is one, or `NULL` if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpopupmenubar.h  
  
## See Also  
 [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)