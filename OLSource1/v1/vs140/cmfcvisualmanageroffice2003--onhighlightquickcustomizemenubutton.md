---
title: "CMFCVisualManagerOffice2003::OnHighlightQuickCustomizeMenuButton"
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
  - "CMFCVisualManagerOffice2003::OnHighlightQuickCustomizeMenuButton"
  - "OnHighlightQuickCustomizeMenuButton"
  - "CMFCVisualManagerOffice2003.OnHighlightQuickCustomizeMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHighlightQuickCustomizeMenuButton method"
ms.assetid: 01a09259-2d5e-47f7-be05-8cc3117989e3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnHighlightQuickCustomizeMenuButton
The framework calls this method when it draws a highlighted quick-customize menu button.  
  
## Syntax  
  
```  
virtual void OnHighlightQuickCustomizeMenuButton(  
   CDC* pDC,  
   CMFCToolBarMenuButton* pButton,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for the button.  
  
 [in] `pButton`  
 A pointer to the button.  
  
 [in] `rect`  
 The bounding rectangle of the button.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)