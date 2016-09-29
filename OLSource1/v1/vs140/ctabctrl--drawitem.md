---
title: "CTabCtrl::DrawItem"
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
  - "CTabCtrl::DrawItem"
  - "CTabCtrl.DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
ms.assetid: b537cbee-977c-4b93-b818-3a8a36922e4d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::DrawItem
Called by the framework when a visual aspect of an owner-draw tab control changes.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
  LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A pointer to a [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure describing the item to be painted.  
  
## Remarks  
 The **itemAction** member of the `DRAWITEMSTRUCT` structure defines the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw `CTabCtrl` object.  
  
 The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before this member function terminates.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)