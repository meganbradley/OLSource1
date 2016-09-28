---
title: "CMFCRibbonBar::GetCategory"
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
  - "CMFCRibbonBar.GetCategory"
  - "CMFCRibbonBar::GetCategory"
  - "GetCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCategory method"
ms.assetid: 8c428039-b539-4be4-9a94-cf0a01ab2875
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetCategory
Retrieves a pointer to the ribbon category at the specified index.  
  
## Syntax  
  
```  
CMFCRibbonCategory* GetCategory(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 The zero-based index of a ribbon category in the list of ribbon categories that is contained in the ribbon bar.  
  
## Return Value  
 A pointer to the ribbon category at the specified index; otherwise, `NULL` if `nIndex` was out of range.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)