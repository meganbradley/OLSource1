---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonCategoryTab"
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
  - "CMFCVisualManagerOffice2003.OnDrawRibbonCategoryTab"
  - "OnDrawRibbonCategoryTab"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonCategoryTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonCategoryTab method"
ms.assetid: 68750a57-3b22-4fae-9bd7-8e8233691fa8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonCategoryTab
The framework calls this method when it draws the tab for a ribbon category.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonCategoryTab(  
   CDC* pDC,  
   CMFCRibbonTab* pTab,  
   BOOL bIsActive  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pTab`  
 A pointer to a ribbon tab object. The framework draws this tab.  
  
 [in] `bIsActive`  
 `TRUE` if the tab is active, or `FALSE` if not.  
  
## Return Value  
 The color that is used for text on the ribbon category tab.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a ribbon category tab.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)