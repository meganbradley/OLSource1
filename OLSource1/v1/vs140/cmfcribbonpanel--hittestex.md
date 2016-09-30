---
title: "CMFCRibbonPanel::HitTestEx"
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
  - "CMFCRibbonPanel.HitTestEx"
  - "HitTestEx"
  - "CMFCRibbonPanel::HitTestEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTestEx method"
ms.assetid: 816d1bea-eb20-4f7c-ab38-2defa9c0ee47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::HitTestEx
Retrieves the zero-based index of the ribbon element that has the specified point located in it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
## Return Value  
 The zero-based index of the ribbon element that has the specified point located in it; otherwise -1.  
  
## Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)