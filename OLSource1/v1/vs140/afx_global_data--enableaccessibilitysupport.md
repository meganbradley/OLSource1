---
title: "AFX_GLOBAL_DATA::EnableAccessibilitySupport"
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
  - "GLOBAL_DATA::EnableAccessibilitySupport"
  - "GLOBAL_DATA.EnableAccessibilitySupport"
  - "EnableAccessibilitySupport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAccessibilitySupport method"
  - "GLOBAL_DATA structure, members"
ms.assetid: 1b6af440-dc77-4da8-90fd-cadc842fdf16
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::EnableAccessibilitySupport
Enables or disables Microsoft Active Accessibility support.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable accessibility support; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to disable accessibility support. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Active Accessibility is a COM-based technology that improves the way programs and the Windows operating system work together with assistive technology products. It provides reliable methods for exposing information about user interface elements. However, a newer accessibility model called Microsoft UI Automation is now available. For a comparison of the two technologies, see [UI Automation and Microsoft Active Accessibility](assetId:///87bee662-0a3e-4232-a421-20e7a5968321).  
  
 Use the [AFX_GLOBAL_DATA::IsAccessibilitySupport](../vs140/afx_global_data--isaccessibilitysupport.md) method to determine whether Microsoft Active Accessibility support is enabled.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [UI Automation and Microsoft Active Accessibility](assetId:///87bee662-0a3e-4232-a421-20e7a5968321)   
 [AFX_GLOBAL_DATA::IsAccessibilitySupport](../vs140/afx_global_data--isaccessibilitysupport.md)