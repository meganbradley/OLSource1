---
title: "CWnd::EnableDynamicLayout"
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
ms.assetid: 42d7d663-ea8e-49cf-ba4b-c42c85188f34
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableDynamicLayout
Enables or disables the dynamic layout manager. When dynamic layout is enabled, the position and size of child windows can adjust dynamically when the user resizes the window.  
  
## Syntax  
  
```  
void EnableDynamicLayout(  
    BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 `bEnable`  
 TRUE to enable dynamic layout; FALSE to disable dynamic layout.  
  
## Remarks  
 If you want to enable dynamic layout, you have to do more than just call this method. You also have to provide dynamic layout information which species how the controls in the window respond to size changes. You can specify this information in the resource editor, or programmatically, for each control. See [Dynamic Layout](../vs140/dynamic-layout.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::IsDynamicLayoutEnabled](../vs140/cwnd--isdynamiclayoutenabled.md)   
 [CWnd::GetDynamicLayout](../vs140/cwnd--getdynamiclayout.md)