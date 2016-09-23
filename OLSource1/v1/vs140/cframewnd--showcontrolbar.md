---
title: "CFrameWnd::ShowControlBar"
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
  - ShowControlBar
  - CFrameWnd::ShowControlBar
  - CFrameWnd.ShowControlBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFrameWnd class, initialization
  - ShowControlBar method
ms.assetid: 1115463b-0c0a-4403-8ab5-5701a7889490
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::ShowControlBar
Call this member function to show or hide the control bar.  
  
## Syntax  
  
```  
  
      void ShowControlBar(  
   CControlBar* pBar,  
   BOOL bShow,  
   BOOL bDelay   
);  
```  
  
#### Parameters  
 `pBar`  
 Pointer to the control bar to be shown or hidden.  
  
 `bShow`  
 If **TRUE**, specifies that the control bar is to be shown. If **FALSE**, specifies that the control bar is to be hidden.  
  
 *bDelay*  
 If **TRUE**, delay showing the control bar. If **FALSE**, show the control bar immediately.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)