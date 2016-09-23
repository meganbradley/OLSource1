---
title: "CMFCTasksPane::OnPressHomeButton"
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
  - CMFCTasksPane.OnPressHomeButton
  - OnPressHomeButton
  - CMFCTasksPane::OnPressHomeButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPressHomeButton method
ms.assetid: bdd8c35b-d0b7-4b08-8f18-a17fc16aebe0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::OnPressHomeButton
Called by the framework when the user clicks the home navigation button.  
  
## Syntax  
  
```  
virtual void OnPressHomeButton();  
```  
  
## Remarks  
 By default, the framework displays the default page for the task group.  
  
 Override this method in a derived class to execute custom code when the user clicks the home navigation button.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)