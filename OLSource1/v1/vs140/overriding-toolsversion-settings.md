---
title: "Overriding ToolsVersion Settings"
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
  - "MSBuild, overriding ToolsVersion setting"
  - "MSBuild, building solutions with"
ms.assetid: ccd42c07-0fb6-4e8b-9ebb-a6a6db18aa2e
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overriding ToolsVersion Settings
You can change the Toolset for projects and solutions in one of three ways:  
  
1.  by using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> switch (or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, for short) when you build the project or solution from the command line  
  
2.  by setting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter on the MSBuild task  
  
3.  by setting the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property on a project within a solution. This lets you build a project in a solution with a Toolset version that differs from that of the other projects.  
  
## Override the ToolsVersion Settings of Projects and Solutions on Command Line Builds  
 Although Visual Studio projects typically build with the ToolsVersion specified in the project file, you can use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) switch on the command line to override that value and build all of the projects and their project-to-project dependencies with a different Toolset. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, all projects are built using ToolsVersion 12.0. (However, see the section "Order of Precedence" later in this topic.)  
  
 When using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> switch on the command line, you can optionally use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property in individual projects to build them with a different ToolsVersion value than the other projects in the solution.  
  
## Override the ToolsVersion Settings Using the ToolsVersion Parameter of the MSBuild Task  
 The MSBuild task is the primary means for one project to build another. To enable the MSBuild task to build a project with a different ToolsVersion than the one specified in the project, it provides an optional task parameter named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The following example demonstrates how to use this parameter:  
  
1.  Create a file that's named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and that contains the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Create another file that's named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and that contains the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Enter the following command at a command prompt:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  The following output appears. For <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> setting on the command line overrides the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> setting in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> tag.  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is called by a task in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. That task has <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, which overrides the other <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> settings for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Order of Precedence  
 The order of precedence, from highest to lowest, used to determine the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is:  
  
1.  The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute on the MSBuild task used to build the project, if any.  
  
2.  The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) switch that's used in the msbuild.exe command, if any.  
  
3.  If the environment variable <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is set, then use the current <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
4.  If the environment variable <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is set and the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> defined in the project file is greater than the current <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, use the current <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
5.  If the environment variable <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set, or if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not set, then the following steps are used:  
  
    1.  The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> attribute of the [Project](../vs140/project-element--msbuild-.md) element of the project file. If this attribute doesn’t exist, it is assumed to be the current version.  
  
    2.  The default tools version in the MSBuild.exe.config file.  
  
    3.  The default tools version in the registry. For more information, see [Standard and Custom Toolset Configurations](../vs140/standard-and-custom-toolset-configurations.md).  
  
6.  If the environment variable <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is not set, then the following steps are used:  
  
    1.  If the environment variable <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is set to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> that exists, use it.  
  
    2.  If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is set in MSBuild.exe.config, use it.  
  
    3.  If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is set in the registry, use it.  
  
    4.  Otherwise, use the current <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## See Also  
 [MSBuild Multitargeting Overview](../vs140/msbuild-multitargeting-overview.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild Toolset (ToolsVersion)](../vs140/msbuild-toolset--toolsversion-.md)   
 [Standard and Custom Toolset Configurations](../vs140/standard-and-custom-toolset-configurations.md)