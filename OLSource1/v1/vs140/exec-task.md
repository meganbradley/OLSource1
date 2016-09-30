---
title: "Exec Task"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Exec"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Exec task [MSBuild]"
  - "MSBuild, Exec task"
ms.assetid: c9b7525a-b1c9-40fc-8bce-77a5b8f960d8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exec Task
Runs the specified program or command by using the specified arguments.  
  
## Parameters  
 The following table describes the parameters for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> The command(s) to run. These can be system commands, such as attrib, or an executable, such as program.exe, runprogram.bat, or setup.msi.\<br />\<br /> This parameter can contain multiple lines of commands. Alternatively, you can put multiple commands in a batch file and run it by using this parameter.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a regular expression that is used to spot error lines in the tool output. This is useful for tools that produce unusually formatted output.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a regular expression that is used to spot warning lines in the tool output. This is useful for tools that produce unusually formatted output.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> output read-only parameter.\<br />\<br /> Specifies the exit code that is provided by the executed command.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the task ignores the exit code that is provided by the executed command. Otherwise, the task returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if the executed command returns a non-zero exit code.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, selects lines in the output that match the standard error/warning format, and logs them as errors/warnings. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, disable this behavior.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>19\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the output items from the task. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> task does not set these itself. Instead, you can provide them as if it did set them, so that they can be used later in the project.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the encoding of the captured task standard error stream. The default is the current console output encoding.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the encoding of the captured task standard output stream. The default is the current console output encoding.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the directory in which the command will run.|  
  
## Remarks  
 This task is useful when a specific [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task for the job that you want to perform is not available. However, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> task, unlike a more specific task, cannot gather output from the tool or command that it runs.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> task calls cmd.exe instead of directly invoking a process.  
  
 In addition to the parameters listed in this document, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.ToolTask*> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../vs140/tooltaskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> task to run a command.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)