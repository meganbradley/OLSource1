---
title: "CDockingManager::BringBarsToTop"
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
  - "CDockingManager::BringBarsToTop"
  - "BringBarsToTop"
  - "CDockingManager.BringBarsToTop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BringBarsToTop method"
ms.assetid: 993ce238-766d-4967-a0d4-443c231196d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::BringBarsToTop
Brings the docked bars that have the specified alignment to the top.  
  
## Syntax  
  
```  
void BringBarsToTop(  
   DWORD dwAlignment = 0,  
   BOOL bExcludeDockedBars = TRUE  
);  
```  
  
#### Parameters  
 [in] `dwAlignment`  
 The alignment of the dock bars that are brought to the top of other windows.  
  
 [in] `bExcludeDockedBars`  
 `TRUE` to exclude the docked bars from being on top; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)