---
title: "How to: Configure Targets and Tasks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 92814100-392a-471d-96fd-e26f637d6cc2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Configure Targets and Tasks
Selected MSBuild tasks can be set to run in the environment they target, regardless of the environment of the development computer. For example, when you use a 64-bit computer to build an application that targets a 32-bit architecture, selected tasks are run in a 32-bit process.  
  
> [!NOTE]
>  If a build task is written in a .NET language, such as Visual C# or Visual Basic, and does not use native resources or tools, then it will run in any target context without adaptation.  
  
## UsingTask Attributes and Task Parameters  
 The following <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attributes affect all operations of a task in a particular build process:  
  
-   The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute, if present, sets the common language runtime (CLR) version, and can take any one of these values: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (any runtime).  
  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute, if present, sets the platform and bitness, and can take any one of these values: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (any architecture).  
  
-   The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute, if present, sets the task factory that creates and runs the task instance, and takes only the value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see the Task Factories section later in this document.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameters to set the target context of an individual task.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Before MSBuild runs a task, it looks for a matching <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that has the same target context.  Parameters that are specified in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> but not in the corresponding task are considered to be matched.  Parameters that specified in the task but not in the corresponding <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are also considered to be matched. If parameter values are not specified in either the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or the task, the values default to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (any parameter).  
  
> [!WARNING]
>  If more than one <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> exists and all have matching <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attributes, the last one to be evaluated replaces the others.  
  
 If parameters are set on the task, MSBuild attempts to find a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> that matches these parameters or, at least, is not in conflict with them.  More than one <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> can specify the target context of the same task.  For example, a task that has different executables for different target environments might resemble this one:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Task Factories  
 Before it runs a task, MSBuild checks to see whether it is designated to run in the current software context.  If the task is so designated, MSBuild passes it to the AssemblyTaskFactory, which runs it in the current process; otherwise, MSBuild passes the task to the TaskHostFactory, which runs the task in a process that matches the target context. Even if the current context and the target context match, you can force a task to run out-of-process (for isolation, security, or other reasons) by setting <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Phantom Task Parameters  
 Like any other task parameters, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> can be set from build properties.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Unlike other task parameters, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> are not apparent to the task itself.  To write a task that is aware of the context in which it runs, you must either test the context by calling the .NET Framework, or use build properties to pass the context information through other task parameters.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> attributes can be set from toolset and environment properties.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameters provide the most flexible way to set the target context, but also the most limited in scope.  On the one hand, because they are set on the task instance itself and are not evaluated until the task is about to run, they can derive their value from the full scope of properties available at both evaluation-time and build-time.  On the other hand, these parameters only apply to a particular instance of a task in a particular target.  
  
> [!NOTE]
>  Task parameters are evaluated in the context of the parent node, not in the context of the task host.Environment variables that are runtime- or architecture- dependent (such as the Program files location) will evaluate to the value that matches the parent node.  However, if the same environment variable is read directly by the task, it will correctly be evaluated in the context of the task host.  
  
## See Also  
 [Configuring Targets and Tasks](../vs140/configuring-targets-and-tasks.md)