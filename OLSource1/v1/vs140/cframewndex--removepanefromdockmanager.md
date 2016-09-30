---
title: "CFrameWndEx::RemovePaneFromDockManager"
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
  - "CFrameWndEx.RemovePaneFromDockManager"
  - "RemovePaneFromDockManager"
  - "CFrameWndEx::RemovePaneFromDockManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePaneFromDockManager method"
ms.assetid: 3462a0eb-78ac-4805-9b11-d3176f4b1194
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::RemovePaneFromDockManager
Unregisters a pane and removes it from the docking manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the control bar pane to remove.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to destroy the control bar after removing it; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to adjust the docking layout; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the control bar is in auto-hide mode; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
## Remarks  
 Use this method to remove a control bar from the docking layout of the frame window.  
  
 The [CDockingManager Class](../vs140/cdockingmanager-class.md) handles the layout of control bars. You must register each control bar with the docking manager by using the [CFrameWndEx::AddPane](../vs140/cframewndex--addpane.md) method or the [CFrameWndEx::InsertPane](../vs140/cframewndex--insertpane.md) method.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)