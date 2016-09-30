---
title: "CMFCRibbonPanel::Remove"
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
  - "Remove"
  - "CMFCRibbonPanel::Remove"
  - "CMFCRibbonPanel.Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: 22ce53bf-3c4e-4e1e-bb25-70d1cce94241
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::Remove
Removes and optionally deletes an element located at the specified index.  
  
## Syntax  
  
```  
BOOL Remove(  
    int nIndex,  
    BOOL bDelete = TRUE  
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the zero-based index of the element that is removed from the ribbon panel.  
  
 [in] `bDelete`  
 `TRUE` to delete the element being removed; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the element has been removed and deleted (if `bDelete` is `TRUE`); `FALSE` if the element was not removed or if there is no ribbon element located at `nIndex`.  
  
## Remarks  
 Call this method to remove an element from the ribbon panel.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)