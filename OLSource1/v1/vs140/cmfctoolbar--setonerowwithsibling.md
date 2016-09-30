---
title: "CMFCToolBar::SetOneRowWithSibling"
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
  - "CMFCToolBar::SetOneRowWithSibling"
  - "CMFCToolBar.SetOneRowWithSibling"
  - "SetOneRowWithSibling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOneRowWithSibling method"
ms.assetid: 81459d59-5e0d-4e8d-9030-57fd7db945b3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetOneRowWithSibling
Positions the toolbar and its sibling on the same row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework calls this method when the user clicks the **Show Buttons on One Row** button.  
  
 Call the [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md) method to enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons. If you call [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md) for this toolbar, the sibling toolbar is moved to the row of this toolbar. Otherwise, this toolbar is moved to the row of the sibling.  
  
 The framework calls the [CMFCToolBar::SetTwoRowsWithSibling](../vs140/cmfctoolbar--settworowswithsibling.md) method when the user clicks the **Show Buttons on Two Rows** button.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md)   
 [CMFCToolBar::SetTwoRowsWithSibling](../vs140/cmfctoolbar--settworowswithsibling.md)