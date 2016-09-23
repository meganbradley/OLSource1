---
title: "AFX_GLOBAL_DATA::m_bUseBuiltIn32BitIcons"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - GLOBAL_DATA.m_bUseBuiltIn32BitIcons
  - m_bUseBuiltIn32BitIcons
  - GLOBAL_DATA::m_bUseBuiltIn32BitIcons
dev_langs: 
  - C++
helpviewer_keywords: 
  - GLOBAL_DATA structure, data members
  - m_bUseBuiltIn32BitIcons
ms.assetid: 43b074ff-7761-4a82-bc0e-0e9f98119ea6
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AFX_GLOBAL_DATA::m_bUseBuiltIn32BitIcons
Indicates whether the framework uses predefined 32-bit color icons or icons of a lower resolution.  
  
## Syntax  
  
```  
BOOL  m_bUseBuiltIn32BitIcons;  
```  
  
## Remarks  
 `TRUE` specifies that the framework use 32-bit color icons; `FALSE` specifies lower resolution icons. The `AFX_GLOBAL_DATA::AFX_GLOBAL_DATA` constructor initializes this member to `TRUE`.  
  
 This member must be set at application startup.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)