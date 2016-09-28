---
title: "CMFCToolBar::DrawSeparator"
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
  - "DrawSeparator"
  - "CMFCToolBar.DrawSeparator"
  - "CMFCToolBar::DrawSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawSeparator method"
ms.assetid: 386c51a2-f073-41db-ab52-c09fd2585cd3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::DrawSeparator
Repaints a separator on a toolbar.  
  
## Syntax  
  
```  
virtual void DrawSeparator(  
   CDC* pDC,  
   const CRect& rect,  
   BOOL bHorz   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 The bounding rectangle of the location where the separator is drawn, in pixels.  
  
 [in] `bHorz`  
 `TRUE` if the separator is horizontal, `FALSE` if the separator is vertical.  
  
## Remarks  
 [CMFCToolBar::DoPaint](../vs140/cmfctoolbar--dopaint.md) calls this method for each [CMFCToolBar::DrawSeparator](../vs140/cmfctoolbar--drawseparator.md) object that has the `TBBS_SEPARATOR` style, instead of calling [CMFCToolBar::DrawButton](../vs140/cmfctoolbar--drawbutton.md) for those buttons.  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to customize the appearance of separators on the toolbar. The default implementation calls [CMFCVisualManager::OnDrawSeparator](../vs140/cmfcvisualmanager--ondrawseparator.md) to draw a separator whose appearance is determined by the current visual manager.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)