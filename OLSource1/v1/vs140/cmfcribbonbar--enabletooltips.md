---
title: "CMFCRibbonBar::EnableToolTips"
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
  - "CMFCRibbonBar.EnableToolTips"
  - "CMFCRibbonBar::EnableToolTips"
  - "EnableToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableToolTips method"
ms.assetid: 9be34e05-4db0-4009-beb6-a8ef70ae0d92
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::EnableToolTips
Enables or disables tooltips and optional tooltip descriptions on the ribbon bar.  
  
## Syntax  
  
```  
void EnableToolTips(  
   BOOL bEnable = TRUE,  
   BOOL bEnableDescr = TRUE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable tooltips on the ribbon bar; `FALSE` to disable tooltips on the ribbon bar.  
  
 [in] `bEnableDescr`  
 `TRUE` to enable tooltip descriptions on the tooltip; `FALSE` to disable tooltip descriptions on the tooltip.  
  
## Remarks  
 The `bEnable` parameter determines whether tooltips are displayed when the mouse hovers over a ribbon element. The `bEnableDescr` parameter determines whether additional descriptive text appears with the tooltip text.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)