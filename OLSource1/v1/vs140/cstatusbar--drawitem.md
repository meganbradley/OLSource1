---
title: "CStatusBar::DrawItem"
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
  - "CStatusBar::DrawItem"
  - "CStatusBar.DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
ms.assetid: 1597ca40-0bbf-4314-96b4-3d70ece93114
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::DrawItem
This member function is called by the framework when a visual aspect of an owner-drawn status bar changes.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
   LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A pointer to a [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure that contains information about the type of drawing required.  
  
## Remarks  
 The **itemAction** member of the `DRAWITEMSTRUCT` structure defines the drawing action that is to be performed. Override this member function to implement drawing for an owner-draw `CStatusBar` object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before the termination of this member function.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)