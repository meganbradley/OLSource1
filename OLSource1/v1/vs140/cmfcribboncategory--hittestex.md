---
title: "CMFCRibbonCategory::HitTestEx"
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
  - "HitTestEx"
  - "CMFCRibbonCategory.HitTestEx"
  - "CMFCRibbonCategory::HitTestEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTestEx method"
ms.assetid: 9e23b670-e303-494f-8343-0eede994849a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::HitTestEx
Retrieves the zero-based index of a ribbon element if the specified point is located in it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The x and y coordinates of the mouse pointer, relative to the upper-left corner of the window.  
  
## Return Value  
 Zero-based index of a ribbon element if the method was successful; otherwise -1.  
  
## Remarks  
 Only ribbon elements that are contained in the ribbon category are tested.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)