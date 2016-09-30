---
title: "CListBox::MeasureItem"
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
  - "CListBox.MeasureItem"
  - "CListBox::MeasureItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MeasureItem method"
  - "CListBox class, overridables"
ms.assetid: f7e8043a-a528-46f1-a0dd-11efce26c4ca
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::MeasureItem
Called by the framework when a list box with an owner-draw style is created.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A long pointer to a [MEASUREITEMSTRUCT](../vs140/measureitemstruct-structure.md) structure.  
  
## Remarks  
 By default, this member function does nothing. Override this member function and fill in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure to inform Windows of the list-box dimensions. If the list box is created with the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, the framework calls this member function for each item in the list box. Otherwise, this member is called only once.  
  
 For further information about using the [LBS_OWNERDRAWFIXED](../vs140/list-box-styles.md) style in an owner-draw list box created with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the discussion in [Technical Note 14](../vs140/tn014--custom-controls.md).  
  
 See [CWnd::OnMeasureItem](../vs140/cwnd--onmeasureitem.md) for a description of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure**.**  
  
## Example  
 [!code[NVC_MFC_CListBox#25](../vs140/codesnippet/CPP/clistbox--measureitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::CompareItem](../vs140/clistbox--compareitem.md)   
 [CWnd::OnMeasureItem](../vs140/cwnd--onmeasureitem.md)   
 [CListBox::DrawItem](../vs140/clistbox--drawitem.md)   
 [CListBox::DeleteItem](../vs140/clistbox--deleteitem.md)