---
title: "CMFCToolBar::SetHotBorder"
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
  - "CMFCToolBar.SetHotBorder"
  - "CMFCToolBar::SetHotBorder"
  - "SetHotBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHotBorder method"
ms.assetid: 8a9ec3b3-04a9-4aec-b74a-2c5d04b73136
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetHotBorder
Specifies whether toolbar buttons are hot-tracked.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to hot-track toolbar buttons. If this parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the toolbar hot-tracks its buttons. Otherwise, the toolbar does not hot-track its buttons.  
  
## Remarks  
 If a button is hot-tracked, the framework highlights the button when the mouse moves across it. By default, each toolbar hot-tracks its buttons.  
  
 Call the [CMFCToolBar::GetHotBorder](../vs140/cmfctoolbar--gethotborder.md) method to determine whether the toolbar hot-tracks its buttons.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetHotBorder](../vs140/cmfctoolbar--gethotborder.md)