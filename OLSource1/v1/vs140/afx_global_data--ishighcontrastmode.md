---
title: "AFX_GLOBAL_DATA::IsHighContrastMode"
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
  - "AFX_GLOBAL_DATA.IsHighContrastMode"
  - "IsHighContrastMode"
  - "AFX_GLOBAL_DATA::IsHighContrastMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_GLOBAL_DATA::IsHighContrastMode"
  - "IsHighContrastMode method"
ms.assetid: b99912f3-ac1f-4042-baa8-44190c7f720c
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::IsHighContrastMode
Indicates whether images are currently displayed in high contrast.  
  
## Syntax  
  
```  
BOOL IsHighContrastMode() const;  
```  
  
## Return Value  
 `TRUE` if images are currently displayed in black or white high contrast mode; otherwise, `FALSE`.  
  
## Remarks  
 In black high contrast mode, edges facing the light are white and the background is black. In white high contrast mode, edges facing the light are black and the background is white.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)