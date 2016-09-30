---
title: "AFX_GLOBAL_DATA::IsDwmCompositionEnabled"
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
  - "AFX_GLOBAL_DATA.IsDwmCompositionEnabled"
  - "IsDwmCompositionEnabled"
  - "AFX_GLOBAL_DATA::IsDwmCompositionEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_GLOBAL_DATA::IsDwmCompositionEnabled"
  - "IsDwmCompositionEnabled method"
ms.assetid: 09d1e8af-fdb7-44ec-8d31-662ca240a73f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::IsDwmCompositionEnabled
Provides a simple way to call the Windows [DwmIsCompositionEnabled](http://msdn.microsoft.com/library/windows/desktop/aa969518) method.  
  
## Syntax  
  
```  
BOOL IsDwmCompositionEnabled();  
```  
  
## Return Value  
 `TRUE` if [Desktop Window Manager](http://msdn.microsoft.com/library/windows/desktop/aa969540) (DWM) composition is enabled; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Desktop Window Manager](http://msdn.microsoft.com/library/windows/desktop/aa969540)   
 [Enable and Control DWM Composition](http://msdn.microsoft.com/library/windows/desktop/aa969538)