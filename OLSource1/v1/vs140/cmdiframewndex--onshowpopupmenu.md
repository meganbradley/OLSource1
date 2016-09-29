---
title: "CMDIFrameWndEx::OnShowPopupMenu"
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
  - "CMDIFrameWndEx.OnShowPopupMenu"
  - "OnShowPopupMenu"
  - "CMDIFrameWndEx::OnShowPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPopupMenu method"
ms.assetid: 25bb7710-5056-4638-a58a-c3de92c727bb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnShowPopupMenu
Called by the framework when it opens a pop-up menu.  
  
## Syntax  
  
```  
virtual BOOL OnShowPopupMenu(  
   CMFCPopupMenu*    
);  
```  
  
## Return Value  
 `TRUE` if the pop-up menu is to be displayed. Otherwise, `FALSE`. The default implementation returns `TRUE`.  
  
## Remarks  
 Override this method if you want to implement special processing upon pop-up menu activation. For example, if you want to change regular menu items to color menu buttons, set up tear-off bars, and so on.  
  
 The default implementation does nothing.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)