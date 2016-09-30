---
title: "MSBuild Reserved and Well-Known Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "MSBuild Reserved and Well-Known Properties"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, reserved properties"
ms.assetid: 99333e61-83c9-4804-84e3-eda297c2478d
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Reserved and Well-Known Properties
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] provides a set of predefined properties that store information about the project file and the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] binaries. These properties are evaluated in the same manner as other [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] properties. For example, to use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property, you type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 MSBuild uses the values in the following table to predefine reserved and well-known properties. Reserved properties cannot be overridden, but well-known properties can be overridden by using identically named environment properties, global properties, or properties that are declared in the project file.  
  
## Reserved and Well-Known Properties  
 The following table describes the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] predefined properties.  
  
|Property|Description|Reserved or Well-Known|  
|--------------|-----------------|-----------------------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The absolute path of the folder where the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] binaries that are currently being used are located (for example, C:\Windows\Microsoft.Net\Framework\\*versionNumber*). This property is useful if you have to refer to files in the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] directory.\<br />\<br /> Do not include the final backslash on this property.|Reserved|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Introduced in the .NET Framework 4: there is no difference between the default values of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You can set the environment variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to a non-null value to enable the behavior of the default value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in earlier versions.\<br />\<br /> In the .NET Framework 3.5 and earlier, the default value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> points to the path of the MSBuild subfolder under the \Program Files\ or \Program Files (x86) folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the \Program Files (x86) folder. For a 64-bit process on a 64-bit machine, this property points to the \Program Files folder.\<br />\<br /> Do not include the final backslash on this property.\<br />\<br /> This location is a useful place to put custom target files. For example, your target files could be installed at \Program Files\MSBuild\MyFiles\Northwind.targets and then imported in project files by using this XML code:\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Well-Known|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The path of the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] subfolder under the \Program Files or \Program Files (x86) folder. This path always points to the 32-bit \Program Files folder on a 32-bit machine and \Program Files (x86) on a 64-bit machine. See also <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.\<br />\<br /> Do not include the final backslash on this property.|Well-Known|  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The path of the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] subfolder under the \Program Files folder. For a 64-bit machine, this path always points to the \Program Files folder. For a 32-bit machine, this path is blank. See also <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.\<br />\<br /> Do not include the final backslash on this property.|Well-Known|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if the previous task completed without any errors (even if there were warnings), or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, except in these scenarios:\<br />\<br /> - When the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute of the [Task Element (MSBuild)](../vs140/task-element--msbuild-.md) is set to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.\<br />\<br /> - When the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> has an [OnError Element (MSBuild)](../vs140/onerror-element--msbuild-.md) as a child element.|Reserved|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The maximum number of concurrent processes that are used when building. This is the value that you specified for **/maxcpucount** on the command line. If you specified **/maxcpucount** without specifying a value, then <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> specifies the number of processors in the computer. For more information, see [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md) and [Building Multiple Projects in Parallel with MSBuild](../vs140/building-multiple-projects-in-parallel-with-msbuild.md).|Reserved|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The location of the 32-bit program folder; for example, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.\<br />\<br /> Do not include the final backslash on this property.|Reserved|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|The complete list of targets that are specified in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element. For example, the following <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> element would have an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> property value of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>:\<br />\<br /> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Reserved|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The absolute path of the directory where the project file is located, for example <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.\<br />\<br /> Do not include the final backslash on this property.|Reserved|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The value of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> property, excluding the root drive.\<br />\<br /> Do not include the final backslash on this property.|Reserved|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The file name extension of the project file, including the period; for example, .proj.|Reserved|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The complete file name of the project file, including the file name extension; for example, MyApp.proj.|Reserved|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|The absolute path and complete file name of the project file, including the file name extension; for example, C:\MyCompany\MyProduct\MyApp.proj.|Reserved|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|The file name of the project file without the file name extension; for example, MyApp.|Reserved|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The absolute path of the folder where [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] is called. By using this property, you can build everything below a specific point in a project tree without creating dirs.proj files in every directory. Instead, you have just one project—for example, c:\traversal.proj, as shown here:\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<br />\<br /> To build at any point in the tree, type:\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\<br />\<br /> Do not include the final backslash on this property.|Reserved|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|The file name and file extension portion of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|Reserved|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|The directory portion of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.\<br />\<br /> Include the final backslash in the path.|Reserved|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The directory portion of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, excluding the root drive.\<br />\<br /> Include the final backslash in the path.|Reserved|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|The file name extension portion of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.|Reserved|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The absolute path of the project or targets file that contains the target that is running.\<br />\<br /> Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file.|Reserved|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|The file name portion of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, without the file name extension.|Reserved|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|The installation path of the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] version that's associated with the value of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.\<br />\<br /> Do not include the final backslash in the path.\<br />\<br /> This property cannot be overridden.|Reserved|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|The version of the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] Toolset that is used to build the project.\<br />\<br /> Note: An [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as csc.exe and vbc.exe. For more information, see [MSBuild Toolset (ToolsVersion)](../vs140/msbuild-toolset--toolsversion-.md), and [Standard and Custom Toolset Configurations](../vs140/standard-and-custom-toolset-configurations.md).|Reserved|  
  
## See Also  
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Properties](../vs140/msbuild-properties.md)