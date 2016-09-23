---
title: "CPane::AllowShowOnPaneMenu"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPane::AllowShowOnPaneMenu
  - CPane.AllowShowOnPaneMenu
  - AllowShowOnPaneMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - AllowShowOnPaneMenu method
ms.assetid: 05869842-3b05-4640-9957-18603c25476b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::AllowShowOnPaneMenu
Specifies whether the pane is listed in the runtime-generated list of panes for the application.  
  
## Syntax  
  
```  
virtual BOOL AllowShowOnPaneMenu() const;  
```  
  
## Return Value  
 `TRUE` if the pane is displayed in the list; otherwise, `FALSE`. The base implementation always returns `TRUE`.  
  
## Remarks  
 The AppWizard-generated application contains a menu option that lists panes that it contains. This method determines whether the pane is displayed in the list.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)