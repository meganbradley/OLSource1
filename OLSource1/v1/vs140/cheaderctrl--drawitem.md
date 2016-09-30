---
title: "CHeaderCtrl::DrawItem"
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
  - "CHeaderCtrl.DrawItem"
  - "CHeaderCtrl::DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
ms.assetid: 36512d6c-69ef-441b-bc92-8871ef22d373
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::DrawItem
Called by the framework when a visual aspect of an owner-draw header control changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure describing the item to be painted.  
  
## Remarks  
 The **itemAction** member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> before this member function terminates.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#6](../vs140/codesnippet/CPP/cheaderctrl--drawitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)