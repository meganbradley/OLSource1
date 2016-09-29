---
title: "CMFCRibbonPanel::HitTest"
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
  - "HitTest"
  - "CMFCRibbonPanel.HitTest"
  - "CMFCRibbonPanel::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 79d0c2d8-fcbc-4a60-8d87-866918d576f1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::HitTest
Retrieves a ribbon element if the specified point is located in it.  
  
## Syntax  
  
```  
virtual CMFCRibbonBaseElement* HitTest(  
   CPoint point,  
   BOOL bCheckPanelCaption = FALSE  
);  
```  
  
#### Parameters  
 [in] `point`  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
 [in] `bCheckPanelCaption`  
 `TRUE` to test the ribbon panel caption; otherwise `FALSE`.  
  
## Return Value  
 Pointer to a ribbon element if the specified point is located in it; otherwise `NULL`.  
  
## Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)