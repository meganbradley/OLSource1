---
title: "CMFCRibbonBar::OnRTLChanged"
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
  - "CMFCRibbonBar::OnRTLChanged"
  - "CMFCRibbonBar.OnRTLChanged"
  - "OnRTLChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRTLChanged method"
ms.assetid: be9adbc2-c277-4db3-88c1-b8aeac89df58
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::OnRTLChanged
Called by the framework when the layout changes direction.  
  
## Syntax  
  
```  
virtual void OnRTLChanged(  
   BOOL bIsRTL  
);  
```  
  
#### Parameters  
 [in] `bIsRTL`  
 `TRUE` if the layout is right-to-left; `FALSE` if the layout is left-to-right.  
  
## Remarks  
 This method adjusts the layout of all controls on the ribbon bar for the new layout direction.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)