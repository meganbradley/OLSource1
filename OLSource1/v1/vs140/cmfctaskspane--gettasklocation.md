---
title: "CMFCTasksPane::GetTaskLocation"
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
  - "CMFCTasksPane::GetTaskLocation"
  - "CMFCTasksPane.GetTaskLocation"
  - "GetTaskLocation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTaskLocation method"
ms.assetid: db167269-e4da-41fc-b3c1-7841582395a8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::GetTaskLocation
Returns the group and the index for a specified task.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the command ID of the task to find.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the group index of the task.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the index of the task in the task group.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the window associated with the task.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the task to find.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the task location was found; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the specified task does not exist.  
  
## Remarks  
 This method retrieves the group index and task index for the specified task. If the method returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are set to -1.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)