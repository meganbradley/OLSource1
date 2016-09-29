---
title: "CMFCRibbonPanel::FindByData"
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
  - "CMFCRibbonPanel::FindByData"
  - "CMFCRibbonPanel.FindByData"
  - "FindByData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByData method"
ms.assetid: e85a90f9-dccd-4a2e-8dcb-eeb7786cbe40
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::FindByData
Retrieves the ribbon element that is associated with the specified data.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* FindByData(  
   DWORD_PTR dwData  
) const;  
```  
  
#### Parameters  
 [in] `dwData`  
 The data associated with a ribbon element.  
  
## Return Value  
 Pointer to a ribbon element if the method was successful; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)