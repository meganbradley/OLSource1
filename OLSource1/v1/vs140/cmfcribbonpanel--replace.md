---
title: "CMFCRibbonPanel::Replace"
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
  - "CMFCRibbonPanel::Replace"
  - "Replace"
  - "CMFCRibbonPanel.Replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace method"
ms.assetid: 42d85eee-af40-4582-a9ed-d3e1ea665dfa
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::Replace
Replaces one element with another based on their index value.  
  
## Syntax  
  
```  
BOOL Replace(  
    int nIndex,  
    CMFCRibbonBaseElement* pElem  
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the zero-based index of the element to replace.  
  
 [in] [out] `pElem`  
 A valid pointer to the element that replaces the original element.  
  
## Return Value  
 `TRUE` if the original ribbon element has been replaced successfully by the new ribbon element; `FALSE` if the ribbon element was not replaced or if there is no element at the specified index.  
  
## Remarks  
 To replace a ribbon element by command ID, call [CMFCRibbonPanel::ReplaceByID](../vs140/cmfcribbonpanel--replacebyid.md).  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)