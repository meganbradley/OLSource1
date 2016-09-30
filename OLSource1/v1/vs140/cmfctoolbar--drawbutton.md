---
title: "CMFCToolBar::DrawButton"
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
  - "CMFCToolBar.DrawButton"
  - "CMFCToolBar::DrawButton"
  - "DrawButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawButton method"
ms.assetid: 737d0e63-377c-453c-b494-097919e109ea
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::DrawButton
Repaints a toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a button to draw.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the toolbar images.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the button is highlighted; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if disabled buttons are dimmed; otherwise <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the button was repainted; <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the button is hidden.  
  
## Remarks  
 The [CMFCToolBar::DrawButton](../vs140/cmfctoolbar--drawbutton.md) method calls this method when a toolbar button must be repainted.  
  
 Override this method if you want to customize the appearance of buttons on your toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::DrawButton](../vs140/cmfctoolbar--drawbutton.md)