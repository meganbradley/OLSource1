---
title: "CMFCRibbonPanel::SetJustifyColumns"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonPanel.SetJustifyColumns
  - CMFCRibbonPanel::SetJustifyColumns
  - SetJustifyColumns
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetJustifyColumns method
ms.assetid: 347decfa-e9bf-4b1d-be0a-8982d1fa964f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonPanel::SetJustifyColumns
Enables or disables the adjustment of the width of ribbon elements in the same column.  
  
## Syntax  
  
```  
void SetJustifyColumns(  
    BOOL bSet = TRUE  
);  
```  
  
#### Parameters  
 [in] `bSet`  
 `TRUE` to adjust the width of ribbon elements in the same column to the width of the largest ribbon element in the column; `FALSE` to disable this width adjustment.  
  
## Remarks  
 When this feature is enabled in a ribbon panel, the widths of ribbon elements in the same column are adjusted to the width of the largest ribbon element in the same column.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)