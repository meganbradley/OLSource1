---
title: "SetNotificationForWaitCompletion Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "SetNotificationForWaitCompletion method, Task class [.NET Framework debug engines]"
ms.assetid: da149c9a-20f4-4543-a29e-429c8c1d2e19
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SetNotificationForWaitCompletion Method
Sets or clears the TASK_STATE_WAIT_COMPLETION_NOTIFICATION state bit.  
  
 **Namespace:** \<xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to set the bit; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to unset the bit.  
  
## Exceptions  
  
## Remarks  
 The debugger sets this bit to help step out of an async method body. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, this method must be called only on a task that has not yet been completed. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, this method may be called on completed tasks. In either event, it should only be used for promise-style tasks.  
  
## Requirements  
  
## See Also  
 [Task Class - Internal Members](../vs140/task-class---internal-members.md)