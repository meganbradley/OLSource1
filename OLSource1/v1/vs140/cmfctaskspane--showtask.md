---
title: "CMFCTasksPane::ShowTask"
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
  - "ShowTask"
  - "CMFCTasksPane::ShowTask"
  - "CMFCTasksPane.ShowTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTask method"
ms.assetid: a3dc34cf-64db-433c-8c7e-26e6c98b8458
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::ShowTask
Shows or hides a task.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the group.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the task to show or hide.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to show the task; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to hide the task.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to redraw the task pane; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the task was successfully shown or hidden; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the specified group or task does not exist.  
  
## Remarks  
 Use [CMFCTasksPane::ShowTaskByCmdId](../vs140/cmfctaskspane--showtaskbycmdid.md) to show or hide a task based on its command ID.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)