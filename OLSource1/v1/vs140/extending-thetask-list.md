---
title: "Extending theTask List"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Task List"
ms.assetid: 9d84c9c4-7796-4fa1-86f8-22d077b79f7e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extending theTask List
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Task List** lets users add custom programming tasks, view task comments that link to lines in the code, and create and view custom categories for task messages.  
  
 Tasks are handled through a service named \<xref:Microsoft.VisualStudio.Shell.Interop.SVsTaskList*>, which implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList2*>. To use basic **Task List** functionality, you must create a task provider by implementing \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider*>.  
  
 Register your task provider with the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsTaskList*> service by calling \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList.RegisterTaskProvider*>, which returns a cookie value that must be used to uniquely identify the task provider in all subsequent transactions.  
  
 Every task provider implementation is responsible for maintaining an internal list of tasks. The task provider can call \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList.RefreshTasks*> on **Task List** to update the displayed list of tasks. When this occurs:  
  
1.  The service calls back into the task provider by using the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider.EnumTaskItems*> method.  
  
2.  The task provider implementation of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider.EnumTaskItems*> returns an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumTaskItems*> object.  
  
3.  The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumTaskItems*> object iterates over a collection of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskItem*> objects.  
  
4.  The \<xref:Microsoft.VisualStudio.Shell.Interop.SVsTaskList*> service then updates the **Task List** display.  
  
 Additional functionality is available. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider3*> interface enables every task provider to supply its own custom set of columns.  
  
## Example  
 The following code example shows an implementation of a task provider.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Creating Custom Task List Views](../vs140/creating-custom-task-list-views.md)   
 [How to: Create Custom Categories of Task Lists](../vs140/how-to--create-custom-categories-of-task-lists.md)