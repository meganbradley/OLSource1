---
title: "AFX_GLOBAL_DATA::IsAccessibilitySupport"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAccessibilitySupport method"
  - "GLOBAL_DATA structure, members"
ms.assetid: 59241f9d-2e07-4e7f-8c95-43f645f22136
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::IsAccessibilitySupport
Indicates whether Microsoft Active Accessibility support is enabled.  
  
## Syntax  
  
```  
BOOL IsAccessibilitySupport() const;  
```  
  
## Return Value  
 `TRUE` if accessibility support is enabled; otherwise, `FALSE`.  
  
## Remarks  
 Microsoft Active Accessibility was the earlier solution for making applications accessible. Microsoft UI Automation is the new accessibility model for Microsoft Windows and is intended to address the needs of assistive technology products and automated testing tools. For more information, see [UI Automation and Microsoft Active Accessibility](assetId:///87bee662-0a3e-4232-a421-20e7a5968321).  
  
 Use the [AFX_GLOBAL_DATA::EnableAccessibilitySupport](../vs140/afx_global_data--enableaccessibilitysupport.md) method to enable or disable Active Accessibility support.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AFX_GLOBAL_DATA::EnableAccessibilitySupport](../vs140/afx_global_data--enableaccessibilitysupport.md)   
 [UI Automation and Microsoft Active Accessibility](assetId:///87bee662-0a3e-4232-a421-20e7a5968321)