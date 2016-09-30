---
title: "CMFCToolBar::IsOneRowWithSibling"
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
  - "CMFCToolBar::IsOneRowWithSibling"
  - "IsOneRowWithSibling"
  - "CMFCToolBar.IsOneRowWithSibling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOneRowWithSibling method"
ms.assetid: 63bc2fce-a22b-4a61-8ec7-afedabeea80b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsOneRowWithSibling
Determines whether the toolbar and its sibling toolbar are positioned on the same row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the toolbar and its sibling are positioned on the same row; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The [CMFCCustomizeButton::CreatePopupMenu](assetId:///e501083e-f78e-4d8d-900c-40bd6e2bb7f8) method calls this method to determine how to show the **Customize** pop-up menu. If this method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the framework displays the **Show Buttons on One Row** button. Otherwise, the framework displays the **Show Buttons on Two Rows** button.  
  
 You typically do not have to use this method. To enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons, call [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCustomizeButton::CreatePopupMenu](assetId:///e501083e-f78e-4d8d-900c-40bd6e2bb7f8)   
 [CMFCToolBar::SetSiblingToolBar](../vs140/cmfctoolbar--setsiblingtoolbar.md)