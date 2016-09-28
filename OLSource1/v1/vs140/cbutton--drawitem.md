---
title: "CButton::DrawItem"
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
  - "CButton::DrawItem"
  - "CButton.DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CButton class, overridables"
  - "owner-drawn buttons"
  - "DrawItem method"
  - "button objects (CButton), images"
  - "images [C++], button objects"
  - "button objects (CButton), overridables"
  - "owner-drawn buttons, DrawItem method"
ms.assetid: 0df15d4d-6afc-498f-97ef-412bc2c13a9e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::DrawItem
Called by the framework when a visual aspect of an owner-drawn button has changed.  
  
## Syntax  
  
```  
  
      virtual void DrawItem(  
   LPDRAWITEMSTRUCT lpDrawItemStruct   
);  
```  
  
#### Parameters  
 `lpDrawItemStruct`  
 A long pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure. The structure contains information about the item to be drawn and the type of drawing required.  
  
## Remarks  
 An owner-drawn button has the **BS_OWNERDRAW** style set. Override this member function to implement drawing for an owner-drawn `CButton` object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in `lpDrawItemStruct` before the member function terminates.  
  
 Also see the [BS_](../vs140/button-styles.md) style values.  
  
## Example  
 [!code[NVC_MFC_CButton#3](../vs140/codesnippet/CPP/cbutton--drawitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetButtonStyle](../vs140/cbutton--setbuttonstyle.md)   
 [WM_DRAWITEM](http://msdn.microsoft.com/library/windows/desktop/bb775923)