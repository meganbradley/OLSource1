---
title: "CMFCVisualManagerOffice2003::OnDrawSeparator"
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
  - "OnDrawSeparator"
  - "CMFCVisualManagerOffice2003.OnDrawSeparator"
  - "CMFCVisualManagerOffice2003::OnDrawSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSeparator method"
ms.assetid: 1cf3fb96-1fdc-438f-b3e2-261bffe5e3fa
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawSeparator
The framework calls this method when it draws a separator.  
  
## Syntax  
  
```  
virtual void OnDrawSeparator(  
   CDC* pDC,  
   CBasePane* pBar,  
   CRect rect,  
   BOOL bIsHoriz  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for a control bar.  
  
 [in] `pBar`  
 A pointer to a pane that contains the separator.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the separator.  
  
 [in] `bIsHoriz`  
 `TRUE` if the pane is docked horizontally, or `FALSE` if the pane is docked vertically.  
  
## Remarks  
 Separators are used on control bars to separate groups of related icons. The default implementation for this method displays the standard separator. Override this method in a derived visual manager to customize the appearance of the separator.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)