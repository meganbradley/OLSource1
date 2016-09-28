---
title: "CMFCRibbonBar::IsShowGroupBorder"
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
  - "IsShowGroupBorder"
  - "CMFCRibbonBar.IsShowGroupBorder"
  - "CMFCRibbonBar::IsShowGroupBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsShowGroupBorder method"
ms.assetid: 1bca7431-70f2-4587-b1fd-f042e115937e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::IsShowGroupBorder
Indicates whether button groups located on the ribbon bar display a group border.  
  
## Syntax  
  
```  
virtual BOOL IsShowGroupBorder(  
    CMFCRibbonButtonsGroup* pGroup  
) const;  
```  
  
#### Parameters  
 [in] `pGroup`  
 This parameter is not used.  
  
## Return Value  
 Always returns `FALSE`.  
  
## Remarks  
 By default this method always returns `FALSE`. Override this method to indicate whether button groups located on the ribbon bar display a group border.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)