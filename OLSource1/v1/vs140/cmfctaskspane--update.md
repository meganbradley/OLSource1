---
title: "CMFCTasksPane::Update"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMFCTasksPane::Update"
  - "CMFCTasksPane.Update"
  - "Update"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Update method"
ms.assetid: dfd58f4c-e084-465d-941d-61ee1ae2b848
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::Update
Refreshes all of the controls in a task pane.  
  
## Syntax  
  
```  
virtual void Update();  
```  
  
## Remarks  
 This method updates the task pane caption, adjusts the scroll bar, repositions all tasks, and redraws all of the task pane controls.  
  
 Override this method in a derived class to execute custom code when the framework refreshes the task pane.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)