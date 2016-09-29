---
title: "CMFCRibbonCategory::HitTest"
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
  - "CMFCRibbonCategory::HitTest"
  - "CMFCRibbonCategory.HitTest"
  - "HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 997c2fb8-d542-49ad-80f4-2405e41985ea
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::HitTest
Retrieves a pointer to a ribbon element if the specified point is located in it.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* HitTest(  
   CPoint point,  
   BOOL bCheckPanelCaption = FALSE  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 The x and y coordinates of the mouse pointer, relative to the upper-left corner of the window.  
  
 [in] `bCheckPanelCaption`  
 `TRUE` to test the ribbon panel caption; `FALSE` to exclude the ribbon panel caption.  
  
## Return Value  
 Pointer to a ribbon element if the method was successful; otherwise `NULL`.  
  
## Remarks  
 Only ribbon elements that are contained in the ribbon category are tested.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)