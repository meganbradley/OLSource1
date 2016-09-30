---
title: "AspNetCompiler Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#AspNetCompiler"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, AspNetCompiler task"
  - "AspNetCompiler task [MSBuild]"
ms.assetid: f811c019-a67b-4d54-82e6-e29549496f6e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AspNetCompiler Task
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task wraps aspnet_compiler.exe, a utility to precompile [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] applications.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> If this parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,, the strong-name assembly will allow partially trusted callers.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter\<br />\<br /> If this parameter is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the precompiled application will be built clean. Any previously compiled components will be recompiled. The default value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This parameter corresponds to the **-c** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> If this parameter is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, debug information (.PDB file) is emitted during compilation. The default value is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This parameter corresponds to the **-d** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.\<br />\<br /> If this parameter is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the assembly is not fully signed when created.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.\<br />\<br /> If this parameter is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the compiled assemblies will be given fixed names..|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter\<br />\<br /> If this parameter is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the task will overwrite the target directory if it already exists. Existing contents are lost. The default value is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. This parameter corresponds to the **-f** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a strong name key container.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the physical path to the strong name key file..|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the full IIS metabase path of the application. This parameter cannot be combined with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> parameters. This parameter corresponds to the **-m** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the physical path of the application to be compiled. If this parameter is missing, the IIS metabase is used to locate the application. This parameter corresponds to the **-p** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the TargetFrameworkMoniker indicating which .NET Framework version of aspnet_compiler.exe should be used. Only accepts .NET Framework monikers.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the physical path to which the application is compiled. If not specified, the application is precompiled in-place.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter.\<br />\<br /> If this parameter is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the precompiled application will be updateable.  The default value is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. This parameter corresponds to the **-u** switch on aspnet_compiler.exe.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter.\<br />\<br /> The virtual path of the application to be compiled. If <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> specified, the physical path is used to locate the application. Otherwise, the IIS metabase is used, and the application is assumed to be in the default site. This parameter corresponds to the **-v** switch on aspnet_compiler.exe.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.ToolTask*> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../vs140/tooltaskextension-base-class.md).  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> task to precompile an [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] application.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)