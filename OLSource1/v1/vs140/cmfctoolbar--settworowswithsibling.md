---
title: "CMFCToolBar::SetTwoRowsWithSibling"
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
  - "CMFCToolBar::SetTwoRowsWithSibling"
  - "SetTwoRowsWithSibling"
  - "CMFCToolBar.SetTwoRowsWithSibling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTwoRowsWithSibling method"
ms.assetid: 264d889b-0c45-46d4-8800-a986e84e814a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetTwoRowsWithSibling
Positions the toolbar and its sibling on separate rows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework calls this method when the user clicks the **Show Buttons on Two Rows** button.  
  
 Call the [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md) method to enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons. If you call [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md) for this toolbar, the sibling toolbar is moved to a separate row. Otherwise, this toolbar is moved to a separate row.  
  
 The framework calls the [CMFCToolBar::SetOneRowWithSibling](../vs140/cmfctoolbar--setonerowwithsibling.md) method when the user clicks the **Show Buttons on One Row** button.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md)   
 [CMFCToolBar::SetOneRowWithSibling](../vs140/cmfctoolbar--setonerowwithsibling.md)