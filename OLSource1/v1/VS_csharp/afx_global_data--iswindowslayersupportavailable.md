---
title: "AFX_GLOBAL_DATA::IsWindowsLayerSupportAvailable"
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
  - "GLOBAL_DATA::IsWindowsLayerSupportAvailable"
  - "GLOBAL_DATA.IsWindowsLayerSupportAvailable"
  - "IsWindowsLayerSupportAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsWindowsLayerSupportAvailable method"
  - "GLOBAL_DATA structure, members"
ms.assetid: 4734cee5-9fba-4f99-8315-b67d3da3b6d3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::IsWindowsLayerSupportAvailable
Indicates whether the operating system supports layered windows.  
  
## Syntax  
  
```  
BOOL IsWindowsLayerSupportAvailable() const;  
```  
  
## Return Value  
 `TRUE` if layered windows are supported; otherwise, `FALSE`.  
  
## Remarks  
 If layered windows are supported, *smart docking* markers use layered windows.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../VS_csharp/afx_global_data-structure.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)