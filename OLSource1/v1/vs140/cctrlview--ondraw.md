---
title: "CCtrlView::OnDraw"
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
  - "CCtrlView.OnDraw"
  - "CCtrlView::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: c51891a5-7382-4ecc-ac0f-3d564ec343ad
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCtrlView::OnDraw
Called by the framework to draw the contents of the `CCtrlView` object using the specified device context.  
  
## Syntax  
  
```  
  
      virtual void OnDraw(  
CDC* pDC  
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to the device context in which the drawing occurs.  
  
## Remarks  
 `OnDraw` is typically called for screen display, passing a screen device context specified by `pDC`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCtrlView Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)