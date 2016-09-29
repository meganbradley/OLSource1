---
title: "CMFCToolBar::CanHandleSiblings"
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
  - "CanHandleSiblings"
  - "CMFCToolBar::CanHandleSiblings"
  - "CMFCToolBar.CanHandleSiblings"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanHandleSiblings method"
ms.assetid: be68cd37-07a3-4986-a5b5-f73f1238c7c7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CanHandleSiblings
Determines whether the toolbar and its sibling are positioned on the same pane.  
  
## Syntax  
  
```  
BOOL CanHandleSiblings();  
```  
  
## Return Value  
 `TRUE` if the toolbar has a sibling and the toolbar and its sibling are positioned on the same pane; otherwise `FALSE`.  
  
## Remarks  
 The internal CMFCCustomizeButton::CreatePopupMenu method calls this method to determine how to show the **Customize** pop-up menu. If this method returns `TRUE`, the framework displays the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons.  
  
 You typically do not have to use this method. To enable the **Customize** button that appears on the toolbar, call the [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md) method. To enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons, call [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCustomizeButton::CreatePopupMenu](assetId:///e501083e-f78e-4d8d-900c-40bd6e2bb7f8)   
 [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md)   
 [CMFCToolBar::IsOneRowWithSibling](../vs140/cmfctoolbar--isonerowwithsibling.md)   
 [CMFCToolBar::SetOneRowWithSibling](../vs140/cmfctoolbar--setonerowwithsibling.md)   
 [CMFCToolBar::SetTwoRowsWithSibling](../vs140/cmfctoolbar--settworowswithsibling.md)   
 [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md)