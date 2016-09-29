---
title: "CWnd::GetDynamicLayout"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: 3bd0e1ab-ee0a-4b8d-9422-bec8745fd5cd
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDynamicLayout
Retrieves a pointer to the dynamic layout manager object.  
  
## Syntax  
  
```  
  
CMFCDynamicLayout* GetDynamicLayout();  
  
```  
  
## Return Value  
 A pointer to the dynamic layout manager object, or NULL if dynamic layout is not enabled.  
  
## Remarks  
 The window object owns and manages the lifetime of the returned pointer, so it should only be used to access the object; do not delete the pointer or store the pointer permanently.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CWnd::IsDynamicLayoutEnabled](../vs140/cwnd--isdynamiclayoutenabled.md)   
 [CWnd::EnableDynamicLayout](../vs140/cwnd--enabledynamiclayout.md)