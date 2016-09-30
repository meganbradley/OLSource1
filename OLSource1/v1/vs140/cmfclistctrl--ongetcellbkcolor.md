---
title: "CMFCListCtrl::OnGetCellBkColor"
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
  - "OnGetCellBkColor"
  - "CMFCListCtrl::OnGetCellBkColor"
  - "CMFCListCtrl.OnGetCellBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetCellBkColor method"
ms.assetid: bbcc477e-d70d-42bf-a47a-d9762d0bcd8f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCListCtrl::OnGetCellBkColor
The framework calls this method when it must determine the background color of an individual cell.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The row of the cell in question.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The column of the cell in question.  
  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value that specifies the background color of the cell.  
  
## Remarks  
 The default implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not use the supplied input parameters and instead simply calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Therefore, by default, the whole list control will have the same background color. You can override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in a derived class to mark individual cells with a separate background color.  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)