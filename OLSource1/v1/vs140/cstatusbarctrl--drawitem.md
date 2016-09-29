---
title: "CStatusBarCtrl::DrawItem"
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
  - "CStatusBarCtrl::DrawItem"
  - "CStatusBarCtrl.DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "status bar controls, drawing items"
  - "DrawItem method"
  - "CStatusBarCtrl class, overridables"
ms.assetid: 4aba9b72-1100-4021-ac3d-bffa018de8ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::DrawItem
Called by the framework when a visual aspect of an owner-draw status bar control changes.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
   LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A long pointer to a [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure that contains information about the type of drawing required.  
  
## Remarks  
 The **itemAction** member of the `DRAWITEMSTRUCT` structure defines the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw `CStatusBarCtrl` object.  
  
 The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before this member function terminates.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)