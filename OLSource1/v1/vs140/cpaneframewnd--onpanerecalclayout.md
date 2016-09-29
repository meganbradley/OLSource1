---
title: "CPaneFrameWnd::OnPaneRecalcLayout"
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
  - "OnPaneRecalcLayout"
  - "CPaneFrameWnd::OnPaneRecalcLayout"
  - "CPaneFrameWnd.OnPaneRecalcLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaneRecalcLayout method"
ms.assetid: 51331d5b-1432-4975-bb66-fe3de82adfc1
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::OnPaneRecalcLayout
Adjusts the layout of a pane inside a mini-frame window.  
  
## Syntax  
  
```  
virtual void OnPaneRecalcLayout();  
```  
  
## Remarks  
 The framework calls this method when it must adjust the layout of a pane inside the mini-frame window.  
  
 By default, the pane is positioned to cover the complete client area of the mini-frame window.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)