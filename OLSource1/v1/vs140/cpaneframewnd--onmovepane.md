---
title: "CPaneFrameWnd::OnMovePane"
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
  - "CPaneFrameWnd::OnMovePane"
  - "OnMovePane"
  - "CPaneFrameWnd.OnMovePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMovePane method"
ms.assetid: 7b1b2a4b-8a98-496c-b533-8ce90a79fb9b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::OnMovePane
Moves the mini-frame window by a specified offset.  
  
## Syntax  
  
```  
virtual void OnMovePane(  
   CPane* pBar,  
   CPoint ptOffset  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to a pane (ignored).  
  
 [in] `ptOffset`  
 The offset by which to move the pane.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)