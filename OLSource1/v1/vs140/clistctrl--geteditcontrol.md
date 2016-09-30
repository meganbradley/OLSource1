---
title: "CListCtrl::GetEditControl"
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
  - "CListCtrl.GetEditControl"
  - "CListCtrl::GetEditControl"
  - "GetEditControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEditControl method"
ms.assetid: 586a00c6-c64c-4d48-b488-1362e8c6922e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetEditControl
Retrieves the handle of the edit control used to edit a list view item's text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, a pointer to the [CEdit](../vs140/cedit-class.md) object that is used to edit the item text; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#14](../vs140/codesnippet/CPP/clistctrl--geteditcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::EditLabel](../vs140/clistctrl--editlabel.md)