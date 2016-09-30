---
title: "Task Writing"
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
  - "MSBuild, writing tasks"
  - "tasks, creating for MSBuild"
  - "MSBuild, creating tasks"
ms.assetid: 3ebc5f87-8f00-46fc-82a1-228f35a6823b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Task Writing
Tasks provide the code that runs during the build process. Tasks are contained in targets. A library of typical tasks is included with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)], and you can also create your own tasks. For more information about the library of tasks that are included with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)], see [MSBuild Task Reference](../vs140/msbuild-task-reference.md).  
  
## Tasks  
 Examples of tasks include [Copy](../vs140/copy-task.md), which copies one or more files, [MakeDir](../vs140/makedir-task.md), which creates a directory, and [Csc](../vs140/csc-task.md), which compiles [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] source code files. Each task is implemented as a .NET class that implements the \<xref:Microsoft.Build.Framework.ITask*> interface, which is defined in the Microsoft.Build.Framework.dll assembly.  
  
 There are two approaches you can use when implementing a task:  
  
-   Implement the \<xref:Microsoft.Build.Framework.ITask*> interface directly.  
  
-   Derive your class from the helper class, \<xref:Microsoft.Build.Utilities.Task*>, which is defined in the Microsoft.Build.Utilities.dll assembly. Task implements ITask and provides default implementations of some ITask members. Additionally, logging is easier.  
  
 In both cases, you must add to your class a method named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is the method that is called when the task runs. This method takes no parameters and returns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the task succeeded or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if it failed. The following example shows a task that performs no action and returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following project file runs this task:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When tasks run, they can also receive inputs from the project file if you create .NET properties on the task class. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] sets these properties immediately before calling the task's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method. To create a string property, use task code such as:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following project file runs this task and sets <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the given value:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Registering Tasks  
 If a project is going to run a task, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] must know how to locate the assembly that contains the task class. Tasks are registered using the [UsingTask Element (MSBuild)](../vs140/usingtask-element--msbuild-.md).  
  
 The [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] file Microsoft.Common.Tasks is a project file that contains a list of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> elements that register all the tasks that are supplied with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]. This file is automatically included when building every project. If a task that is registered in Microsoft.Common.Tasks is also registered in the current project file, the current project file takes precedence; that is, you can override a default task with your own task that has the same name.  
  
> [!TIP]
>  You can see a list of the tasks that are supplied with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] by viewing the contents of Microsoft.Common.Tasks.  
  
## Raising Events from a Task  
 If your task derives from the \<xref:Microsoft.Build.Utilities.Task*> helper class, you can use any of the following helper methods on the \<xref:Microsoft.Build.Utilities.Task*> class to raise events that will be caught and displayed by any registered loggers:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If your task implements \<xref:Microsoft.Build.Framework.ITask*> directly, you can still raise such events but you must use the IBuildEngine interface. The following example shows a task that implements ITask and raises a custom event:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Requiring Task Parameters to be Set  
 You can mark certain task properties as "required" so that any project file that runs the task must set values for these properties or the build fails. Apply the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute to the .NET property in your task as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute is defined by \<xref:Microsoft.Build.Framework.RequiredAttribute*> in the \<xref:Microsoft.Build.Framework*> namespace.  
  
## Example  
  
### Description  
 This following [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] class demonstrates a task deriving from the \<xref:Microsoft.Build.Utilities.Task*> helper class. This task returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, indicating that it succeeded.  
  
### Code  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This following [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] class demonstrates a task implementing the \<xref:Microsoft.Build.Framework.ITask*> interface. This task returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, indicating that it succeeded.  
  
### Code  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] class demonstrates a task that derives from the \<xref:Microsoft.Build.Utilities.Task*> helper class. It has a required string property, and raises an event that is displayed by all registered loggers.  
  
### Code  
 [!code[msbuild_SimpleTask3#1](../vs140/codesnippet/CSharp/task-writing_1.cs)]  
  
## Example  
  
### Description  
 The following example shows a project file invoking the previous example task, SimpleTask3.  
  
### Code  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-task-reference.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)