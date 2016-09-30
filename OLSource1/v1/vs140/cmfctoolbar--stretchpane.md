---
title: "CMFCToolBar::StretchPane"
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
  - "CMFCToolBar.StretchPane"
  - "StretchPane"
  - "CMFCToolBar::StretchPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StretchPane method"
ms.assetid: 9b0b359e-839b-47ca-b172-1ed37b952dfd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::StretchPane
Stretches the toolbar vertically or horizontally, and repositions the buttons if necessary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The amount, in pixels, by which to stretch the pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, stretches the pane vertically. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, stretches the pane horizontally.  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that specifies the size of the toolbar client area.  
  
## Remarks  
 This method calls [CMFCToolBar::WrapToolBar](../vs140/cmfctoolbar--wraptoolbar.md) to reposition the buttons within the stretched toolbar.  
  
 The return value is determined by calling [CMFCToolBar::CalcSize](../vs140/cmfctoolbar--calcsize.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)