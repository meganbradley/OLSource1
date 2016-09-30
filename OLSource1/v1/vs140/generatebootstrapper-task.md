---
title: "GenerateBootstrapper Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#GenerateBootstrapper"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, GenerateBootstrapper task"
  - "GenerateBootstrapper task [MSBuild]"
ms.assetid: ca3ba2c6-d2ea-41f2-b7e3-0fc2b0730460
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GenerateBootstrapper Task
Provides an automated way to detect, download, and install an application and its prerequisites. It serves as a single installer that integrates the separate installers for all the components making up an application.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
     Specifies the file the bootstrapper will use to begin the installation of the application after all prerequisites have been installed. A build error will result if neither the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> nor the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is specified.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
     Specifies the name of the application that the bootstrapper will install. This name will appear in the UI the bootstrapper uses during installation.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
     If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the component runs with elevated permissions when it is installed on a target computer.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.  
  
     Specifies the Web location that is hosting the application’s installer.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> output parameter.  
  
     Specifies the built location of bootstrapper package files.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter.  
  
     Specifies the products to build into the bootstrapper. The items passed to this parameter should have the following syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute is used to represent the name of a prerequisite which should be installed. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> item metadata is optional, and will be used by the build engine as a user-friendly name in case the package cannot be found. These items are not required [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] input parameters unless no <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is specified. You should include one item for every prerequisite which must be installed for your application.  
  
     A build error will result if neither the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> nor the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter is specified.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> output parameter.  
  
     Specifies the built location of setup.exe  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter.  
  
     Specifies a location for the bootstrapper to look for installation prerequisites to install. This parameter can have the following values::  
  
    -   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>: Indicates that the prerequisite is being hosted by the component vendor.  
  
    -   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>: Indicates that the preqrequisite is at the same location of the application.  
  
    -   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>: Indicates that all components are to be found at a centralized URL. This value should be used in conjunction with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> input parameter.  
  
     If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is not specified, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is used by default.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter.  
  
     Specifies the URL containing the installation prerequisites.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.  
  
     If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the bootstrapper copies all output files to the path specified in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter. The values of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter should all be based on this path. If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the files are not copied, and the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> values are based on the value of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter.  The default value of this parameter is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> parameter.  
  
     Specifies the culture to use for the bootstrapper UI and installation prerequisites. If the specified culture is unavailabe, the task uses the value of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter.  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter.  
  
     Specifies the secondary culture to use for the bootstraper UI and installation prerequisites.  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> parameter.  
  
     Specifies the location to copy setup.exe and all package files.  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> parameter.  
  
     Specifies the location of all available prerequisite packages.  
  
-   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> parameter.  
  
     Specifies the URL to provide should the bootstrapper installation fail  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
     Optional <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> parameter.  
  
     If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, the bootstrapper performs XSD validation on the specified input bootstrapper items. The default value of this parameter is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> task to install an application that must have the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] installed as a prerequisite.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)