---
title: "CToolBarCtrl::SetButtonSize"
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
  - "CToolBarCtrl.SetButtonSize"
  - "CToolBarCtrl::SetButtonSize"
  - "SetButtonSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonSize method"
ms.assetid: cf57d423-f7fe-496e-8514-f9fc31d3c426
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetButtonSize
Sets the size of the buttons in the toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Width and height, in pixels, of the buttons.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The button size must always be at least as large as the bitmap size it encloses. This function must be called only before adding any bitmaps to the toolbar. If the application does not explicitly set the button size, it defaults to 24 by 22 pixels.  
  
## Example  
 See the example for [CToolBar::GetToolBarCtrl](../vs140/ctoolbar--gettoolbarctrl.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetBitmapSize](../vs140/ctoolbarctrl--setbitmapsize.md)   
 [CToolBarCtrl::GetItemRect](../vs140/ctoolbarctrl--getitemrect.md)