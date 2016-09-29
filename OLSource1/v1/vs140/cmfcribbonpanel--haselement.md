---
title: "CMFCRibbonPanel::HasElement"
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
  - "CMFCRibbonPanel::HasElement"
  - "CMFCRibbonPanel.HasElement"
  - "HasElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasElement method"
ms.assetid: ef84b9f3-4451-4bac-aa62-3ded2eb52b78
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::HasElement
Indicates whether the ribbon panel contains the specified ribbon element.  
  
## Syntax  
  
```  
BOOL HasElement(  
   const CMFCRibbonBaseElement* pElem  
) const;  
```  
  
#### Parameters  
 [in] `pElem`  
 Pointer to a ribbon element.  
  
## Return Value  
 `TRUE` if the ribbon panel contains the specified ribbon element; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)