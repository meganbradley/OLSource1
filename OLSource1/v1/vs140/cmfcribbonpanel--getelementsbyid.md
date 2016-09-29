---
title: "CMFCRibbonPanel::GetElementsByID"
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
  - "GetElementsByID"
  - "CMFCRibbonPanel.GetElementsByID"
  - "CMFCRibbonPanel::GetElementsByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElementsByID method"
ms.assetid: b36e9b83-7785-4b83-93bc-af9b4b85ee7b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::GetElementsByID
Adds ribbon elements that have the specified command ID to the specified array.  
  
## Syntax  
  
```  
void GetElementsByID(  
   UINT uiCmdID,  
   CArray<CMFCRibbonBaseElement*, CMFCRibbonBaseElement*>& arElements  
);  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 Command ID for a ribbon element.  
  
 [in] `arElements`  
 Array of ribbon elements.  
  
## Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)