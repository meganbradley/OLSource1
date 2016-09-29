---
title: "CMFCRibbonCategory::FindByData"
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
  - "CMFCRibbonCategory::FindByData"
  - "FindByData"
  - "CMFCRibbonCategory.FindByData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindByData method"
ms.assetid: b83c8a86-1955-4d22-994f-0dde29bf62d2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::FindByData
Retrieves the ribbon element associated with the specified data.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* FindByData(  
   DWORD_PTR dwData,  
   BOOL bVisibleOnly = TRUE  
) const;  
```  
  
#### Parameters  
 [in] `dwData`  
 The data associated with a ribbon element.  
  
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