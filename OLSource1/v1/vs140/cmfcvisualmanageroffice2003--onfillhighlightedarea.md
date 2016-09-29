---
title: "CMFCVisualManagerOffice2003::OnFillHighlightedArea"
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
  - "CMFCVisualManagerOffice2003.OnFillHighlightedArea"
  - "CMFCVisualManagerOffice2003::OnFillHighlightedArea"
  - "OnFillHighlightedArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillHighlightedArea method"
ms.assetid: 4581d373-29dc-485c-95d4-126787373c9a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillHighlightedArea
The framework calls this method when it fills the highlighted area of a toolbar button.  
  
## Syntax  
  
```  
virtual void OnFillHighlightedArea(  
   CDC* pDC,  
   CRect rect,  
   CBrush* pBrush,  
   CMFCToolBarButton* pButton  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `rect`  
 The bounding rectangle of the highlighted area to fill.  
  
 [in] `pBrush`  
 The brush to use in filling the highlighted area.  
  
 [in] `pButton`  
 Pointer to the [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object for which to fill the highlighted area.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)