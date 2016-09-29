---
title: "CListBox::DrawItem"
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
  - "CListBox.DrawItem"
  - "CListBox::DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
  - "CListBox class, overridables"
ms.assetid: c52c84dc-4cae-4a5e-991f-5a9a5a584f7e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::DrawItem
Called by the framework when a visual aspect of an owner-draw list box changes.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
   LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A long pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
## Remarks  
 The **itemAction** and **itemState** members of the `DRAWITEMSTRUCT` structure define the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw `CListBox` object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before this member function terminates.  
  
 See [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md) for a description of the `DRAWITEMSTRUCT` structure.  
  
## Example  
 [!code[NVC_MFC_CListBox#9](../vs140/codesnippet/CPP/clistbox--drawitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::CompareItem](../vs140/clistbox--compareitem.md)   
 [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)   
 [WM_DRAWITEM](http://msdn.microsoft.com/library/windows/desktop/bb775923)   
 [CListBox::MeasureItem](../vs140/clistbox--measureitem.md)   
 [CListBox::DeleteItem](../vs140/clistbox--deleteitem.md)