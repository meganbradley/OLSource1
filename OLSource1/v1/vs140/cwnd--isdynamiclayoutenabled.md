---
title: "CWnd::IsDynamicLayoutEnabled"
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
ms.assetid: 4d318e34-3ecb-41d1-bd10-850f93525d67
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::IsDynamicLayoutEnabled
Determines whether dynamic layout is enabled on this window. If dynamic layout is enabled, the position and size of child windows can change when the user resizes the parent window.  
  
## Syntax  
  
```  
  
BOOL IsDynamicLayoutEnabled() const;  
  
```  
  
## Return Value  
 TRUE if dynamic layout is enabled; otherwise FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableDynamicLayout](../vs140/cwnd--enabledynamiclayout.md)   
 [CWnd::GetDynamicLayout](../vs140/cwnd--getdynamiclayout.md)