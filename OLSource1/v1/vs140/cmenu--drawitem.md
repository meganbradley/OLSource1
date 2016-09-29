---
title: "CMenu::DrawItem"
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
  - "CMenu::DrawItem"
  - "CMenu.DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
  - "CMenu class, overridables"
ms.assetid: bd0c399f-8069-4276-b992-c12dafda6d0a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::DrawItem
Called by the framework when a visual aspect of an owner-drawn menu changes.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
   LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
## Remarks  
 The `itemAction` member of the `DRAWITEMSTRUCT` structure defines the drawing action that is to be performed. Override this member function to implement drawing for an owner-draw `CMenu` object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before the termination of this member function.  
  
 See [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md) for a description of the `DRAWITEMSTRUCT` structure.  
  
## Example  
 The following code is from the MFC [CTRLTEST](../vs140/visual-c---samples.md) sample:  
  
 [!code[NVC_MFCWindowing#24](../vs140/codesnippet/CPP/cmenu--drawitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)