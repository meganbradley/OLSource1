---
title: "CComboBox::DrawItem"
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
  - "CComboBox.DrawItem"
  - "CComboBox::DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
  - "CComboBox class, overridables"
ms.assetid: b1148873-a8db-4bbc-9b4b-70ccb778b765
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::DrawItem
Called by the framework when a visual aspect of an owner-draw combo box changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
## Remarks  
 The **itemAction** member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed. See [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md) for a description of this structure.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. Before this member function terminates, the application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFC_CComboBox#11](../vs140/codesnippet/CPP/ccombobox--drawitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::CompareItem](../vs140/ccombobox--compareitem.md)   
 [WM_DRAWITEM](http://msdn.microsoft.com/library/windows/desktop/bb775923)   
 [CComboBox::MeasureItem](../vs140/ccombobox--measureitem.md)   
 [CComboBox::DeleteItem](../vs140/ccombobox--deleteitem.md)