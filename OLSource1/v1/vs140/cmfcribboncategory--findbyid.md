---
title: "CMFCRibbonCategory::FindByID"
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
  - "CMFCRibbonCategory.FindByID"
  - "CMFCRibbonCategory::FindByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByID method"
ms.assetid: 5758c04f-1cfe-43f4-afac-2d69abb11201
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::FindByID
Retrieves the ribbon element associated with the specified command ID.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* FindByID(  
   UINT uiCmdID,  
   BOOL bVisibleOnly = TRUE  
) const;  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 Command ID associated with a ribbon element.  
  
 [in] `bVisibleOnly`  
 `TRUE` to include quick access ribbon elements in the search; `FALSE` to exclude quick access ribbon elements in the search.  
  
## Return Value  
 Pointer to a ribbon element if the method was successful; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)