---
title: "CMFCRibbonPanel::GetElement"
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
  - "CMFCRibbonPanel.GetElement"
  - "GetElement"
  - "CMFCRibbonPanel::GetElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElement method"
ms.assetid: f221203d-75cb-4268-ab85-23eea1f67de7
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::GetElement
Returns the ribbon element located at a specified index.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* GetElement(  
    int nIndex   
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the zero-based index of the element to retrieve.  
  
## Return Value  
 A valid pointer to the base ribbon element located at position `nIndex` in the ribbon panel, or `NULL` if there is no element at the specified index.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)