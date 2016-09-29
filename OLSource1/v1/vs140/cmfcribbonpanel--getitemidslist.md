---
title: "CMFCRibbonPanel::GetItemIDsList"
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
  - "CMFCRibbonPanel.GetItemIDsList"
  - "CMFCRibbonPanel::GetItemIDsList"
  - "GetItemIDsList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemIDsList method"
ms.assetid: a25d9a15-4ba9-4b6c-99b6-1868389cbdb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::GetItemIDsList
Retrieves the command IDs for all ribbon elements in the ribbon panel.  
  
## Syntax  
  
```  
void GetItemIDsList(  
    CList<UINT, UINT>& lstItems  
) const;  
```  
  
#### Parameters  
 [out] `lstItems`  
 The list of command IDs for ribbon elements that are contained in the ribbon panel.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonpanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)