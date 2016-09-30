---
title: "CMFCToolBar::WrapToolBar"
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
  - "CMFCToolBar::WrapToolBar"
  - "CMFCToolBar.WrapToolBar"
  - "WrapToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WrapToolBar method"
ms.assetid: 037ace4d-b57c-4402-9855-39d1f52110c0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::WrapToolBar
Repositions toolbar buttons within the given dimensions.  
  
## Syntax  
  
```  
int WrapToolBar(  
   int nWidth,  
   int nHeight = 32767,  
   CDC* pDC = NULL,  
   int nColumnWidth = -1,  
   int nRowHeight = -1  
);  
```  
  
#### Parameters  
 [in] `nWidth`  
 Maximum width of the toolbar.  
  
 [in] `nHeight`  
 Maximum height of the toolbar. Not used if the toolbar is floating.  
  
 [in] `pDC`  
 Pointer to a device context. If NULL, the device context for the toolbar is used.  
  
 [in] `nColumnWidth`  
 Button width. If -1, the current width is used.  
  
 [in] m`nRowHeight`  
 Button height. If -1, the current height is used.  
  
## Return Value  
 The number of rows of buttons on the toolbar.  
  
## Remarks  
 This method repositions buttons within the toolbar, wrapping buttons to additional rows if necessary.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)