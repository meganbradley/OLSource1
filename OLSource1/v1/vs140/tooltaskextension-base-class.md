---
title: "ToolTaskExtension Base Class"
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
  - "MSBuild.ToolTask.ToolCommandFailed"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 258ae433-f68a-49f1-b276-da20e3472e68
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ToolTaskExtension Base Class
Many tasks inherit from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which inherits from the \<xref:Microsoft.Build.Utilities.ToolTask*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. This inheritance chain adds several parameters to the tasks that derive from them. These parameters are listed in this document.  
  
## Parameters  
 The following table describes the parameters of the base classes.  
  
|Parameter|Description|  
|---------------|-----------------|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine*> parameter.\<br />\<br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine2*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine2*> parameter.\<br />\<br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.\<br />\<br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine3*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine3*> parameter.\<br />\<br /> Specifies the build engine interface provided by the host.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.EchoOff*>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> When set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, this task passes **/Q** to the cmd.exe command line such that the command line does not get copied to stdout.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables*>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array parameter.\<br />\<br /> Array of pairs of environment variables, separated by equal signs. These variables are passed to the spawned executable in addition to, or selectively overriding, the regular environment block.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.ExitCode*>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> output read-only parameter.\<br />\<br /> Specifies the exit code that is provided by the executed command. If the task logged any errors, but the process had an exit code of 0 (success), this is set to -1.|  
|\<xref:Microsoft.Build.Utilities.Task.HostObject*>|Optional \<xref:Microsoft.Build.Framework.ITaskHost*> parameter.\<br />\<br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task.|  
|\<xref:Microsoft.Build.Tasks.ToolTaskExtension.Log*>|Optional \<xref:Microsoft.Build.Utilities.TaskLoggingHelper*> read-only parameter.\<br />\<br /> Gets an instance of a \<xref:Microsoft.Build.Tasks.TaskLoggingHelperExtension*> class that contains task logging methods.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.LogStandardErrorAsError*>|Option <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, all messages received on the standard error stream are logged as errors.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.StandardErrorImportance*>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> Importance with which to log text from the standard out stream.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.StandardOutputImportance*>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> Importance with which to log text from the standard out stream.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.Timeout*>|Virtual optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, indicating that there is no time out period.Time-out is in milliseconds.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.ToolExe*>|Virtual optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.\<br />\<br /> Projects may implement this to override a ToolName. Tasks may override this to preserve the ToolName.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.ToolPath*>|Optional <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the location from where the task loads the underlying executable file. If this parameter is not specified, the task uses the SDK installation path that corresponds to the version of the framework that is running [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)].|  
|\<xref:Microsoft.Build.Utilities.ToolTask.UseCommandProcessor*>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.\<br />\<br /> When set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, this task creates a batch file for the command line and executes it by using the command-processor instead of executing the command directly.|  
|\<xref:Microsoft.Build.Utilities.ToolTask.YieldDuringToolExecution*>|Optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.\<br />\<br /> When set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, this task yields the node when its task is executing.|  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)