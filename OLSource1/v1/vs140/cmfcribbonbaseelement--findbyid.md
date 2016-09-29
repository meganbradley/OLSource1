---
title: "CMFCRibbonBaseElement::FindByID"
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
  - "FindByID"
  - "CMFCRibbonBaseElement.FindByID"
  - "CMFCRibbonBaseElement::FindByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByID method"
ms.assetid: 835db8d0-b48d-4142-ae40-344aa4a17c91
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::FindByID
Retrieves a pointer to the ribbon element if that element is identified by the specified command ID.  
  
## Syntax  
  
```  
virtual CMFCRibbonBaseElement* FindByID(  
   UINT uiCmdID  
);  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 Command ID for a ribbon element.  
  
## Return Value  
 A pointer to the ribbon element if that element is identified by the specified command ID; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)