---
title: "CMFCColorBar::CreateControl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCColorBar::CreateControl
  - CMFCColorBar.CreateControl
  - CreateControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateControl method
ms.assetid: efd84d0d-43c8-46c1-b54c-f56acac87a61
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCColorBar::CreateControl
Creates a color bar control window, attaches it to the `CMFCColorBar` object, and resizes the control window to contain the specified palette of colors.  
  
## Syntax  
  
```  
virtual BOOL CreateControl(  
   CWnd* pParentWnd,  
   const CRect& rect,  
   UINT nID,  
   int nColumns=-1,  
   CPalette* pPalette=NULL   
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 Pointer to the parent window. Cannot be `NULL`.  
  
 [in] `rect`  
 A bounding rectangle that specifies where to draw the color bar control.  
  
 [in] `nID`  
 The control ID.  
  
 [in] `nColumns`  
 The ideal number of columns in the color bar control. This method modifies that number to fit the specified palette of colors. The default is -1, which means this parameter is not specified.  
  
 [in] `pPalette`  
 Pointer to a palette of colors, or `NULL`. If this parameter is `NULL`, this method calculates the size of the color bar control as if 20 colors were specified. The default is `NULL`.  
  
## Return Value  
 `TRUE` if this method succeeds; otherwise `FALSE`.  
  
## Remarks  
 This method uses the `rect`, `nColumns`, and `pPalette` parameters to calculate the appropriate number or rows and columns in the color bar control, and then calls the [CMFCColorBar::Create](../vs140/cmfccolorbar--create.md) method.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorBar::Create](../vs140/cmfccolorbar--create.md)