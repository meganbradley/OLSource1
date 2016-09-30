---
title: "CListCtrl::EditLabel"
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
  - "CListCtrl::EditLabel"
  - "CListCtrl.EditLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EditLabel method"
ms.assetid: 597a0c1c-a6d0-442e-9d1c-1c10e267e1bf
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::EditLabel
Begins in-place editing of an item's text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the list view item that is to be edited.  
  
## Return Value  
 If successful, a pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that is used to edit the item text; otherwise **NULL**.  
  
## Remarks  
 A list view control that has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> window style enables a user to edit item labels in place. The user begins editing by clicking the label of an item that has the focus.  
  
 Use this function to begin in-place editing of the specified list view item's text.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#7](../vs140/codesnippet/CPP/clistctrl--editlabel_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetEditControl](../vs140/clistctrl--geteditcontrol.md)