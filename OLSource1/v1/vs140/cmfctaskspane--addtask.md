---
title: "CMFCTasksPane::AddTask"
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
  - "CMFCTasksPane::AddTask"
  - "CMFCTasksPane.AddTask"
  - "AddTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTask method"
ms.assetid: d8428e5c-9051-4f2e-8431-8e7cabdc77a9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::AddTask
Adds a task to the specified task group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the group index where the task is added.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the name of the task.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the icon to display next to the task. The framework stores icons in a list of images. This parameter is an index into that list.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the command ID of the command to execute when the user clicks the task. The task is treated as a label if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the user-defined data to be associated with the task.  
  
## Return Value  
 The zero-based index of the group where the task was added, or -1 if the group specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not exist.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)