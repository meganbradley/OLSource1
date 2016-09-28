---
title: "CMFCRibbonPanel::Insert"
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
  - "CMFCRibbonPanel.Insert"
  - "CMFCRibbonPanel::Insert"
  - "Insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Insert method"
ms.assetid: 93198ca4-1aa4-414d-8a25-45e40877f83c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::Insert
Inserts the specified ribbon element at the specified position in the array of ribbon elements that is contained in the ribbon panel.  
  
## Syntax  
  
```  
virtual BOOL Insert(  
    CMFCRibbonBaseElement* pElem,  
    int nIndex   
);  
```  
  
#### Parameters  
 [in, out] `pElem`  
 Pointer to a ribbon element.  
  
 [in] `nIndex`  
 Zero-based value, ranging from -1 to the number of ribbon elements that are contained in the array.  
  
## Return Value  
 `TRUE` if the ribbon element was inserted successfully; otherwise `FALSE`.  
  
## Remarks  
 If the value of `nIndex` is -1, or if `nIndex` equals the number of ribbon elements in the array, the specified ribbon element is added to the end of the array. If the value of `nIndex` is out of range, the method will fail.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)