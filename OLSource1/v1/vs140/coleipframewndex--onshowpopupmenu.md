---
title: "COleIPFrameWndEx::OnShowPopupMenu"
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
  - "OnShowPopupMenu"
  - "COleIPFrameWndEx::OnShowPopupMenu"
  - "COleIPFrameWndEx.OnShowPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPopupMenu method"
ms.assetid: de233229-b493-458c-a71f-be1de7ff6350
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::OnShowPopupMenu
Called by the framework when a pop-up menu is displayed.  
  
## Syntax  
  
```  
virtual BOOL OnShowPopupMenu(  
   CMFCPopupMenu* pMenuPopup  
);  
```  
  
#### Parameters  
 `[in] pMenuPopup`  
 Pointer to the pop-up menu to be displayed.  
  
## Return Value  
 The default implementation does nothing and returns a non-zero value. Your implementation should return `FALSE` if the pop-up menu cannot be displayed.  
  
## Remarks  
 Override this method to customize the display of a pop-up menu. For example, you could change the menu buttons to color menu buttons or initialize tear-off bars.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)