---
title: "AFX_GLOBAL_DATA::GetNonClientMetrics"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX_GLOBAL_DATA::GetNonClientMetrics"
  - "AFX_GLOBAL_DATA.GetNonClientMetrics"
  - "GetNonClientMetrics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNonClientMetrics method"
  - "AFX_GLOBAL_DATA::GetNonClientMetrics"
ms.assetid: b42f4640-b6ab-47ce-8171-556d46d199cd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::GetNonClientMetrics
Retrieves the metrics associated with the nonclient area of nonminimized windows.  
  
## Syntax  
  
```  
BOOL GetNonClientMetrics(  
   NONCLIENTMETRICS& info  
);  
```  
  
#### Parameters  
 [in, out] `info`  
 A [NONCLIENTMETRICS](http://msdn.microsoft.com/library/windows/desktop/ff729175) structure that contains the scalable metrics associated with the nonclient area of a nonminimized window.  
  
## Return Value  
 `TRUE` if this method succeeds; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [NONCLIENTMETRICS Structure](http://msdn.microsoft.com/library/windows/desktop/ff729175)