---
title: "CMFCTasksPane::OnClickTask"
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
  - "CMFCTasksPane::OnClickTask"
  - "CMFCTasksPane.OnClickTask"
  - "OnClickTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClickTask method"
ms.assetid: 25c26b67-e3dc-47eb-9c00-047a56614226
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::OnClickTask
Called by the framework when the user clicks an item in the task pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the group that contains the clicked task.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the clicked task.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the command ID associated with the task.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains user-defined data associated with the clicked task.  
  
## Remarks  
 The framework calls this method when a user clicks a task. By default, the framework checks the command ID associated with the clicked task and, if it is not zero, sends the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message to the owner of the task pane control.  
  
 Override this method in a derived class to execute custom code when a task is clicked.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)