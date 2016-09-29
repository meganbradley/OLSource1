---
title: "AFX_GLOBAL_DATA::Is32BitIcons"
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
  - "Is32BitIcons"
  - "AFX_GLOBAL_DATA::Is32BitIcons"
  - "AFX_GLOBAL_DATA.Is32BitIcons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Is32BitIcons method"
  - "AFX_GLOBAL_DATA::Is32BitIcons"
ms.assetid: ce80667c-87b4-498f-8b3f-ef07b69d3072
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::Is32BitIcons
Indicates whether predefined 32-bit icons are supported.  
  
## Syntax  
  
```  
BOOL Is32BitIcons() const;  
```  
  
## Return Value  
 `TRUE` if predefined 32-bit icons are supported; otherwise, `FALSE`.  
  
## Remarks  
 This method returns `TRUE` if the framework supports 32-bit built-in icons, and if the operating system supports 16 bits per pixel or more, and if images are not displayed in high contrast.  
  
## Requirements  
 **Header:**  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)