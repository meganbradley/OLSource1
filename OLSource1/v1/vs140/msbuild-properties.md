---
title: "MSBuild Properties"
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
  - "MSBuild, properties"
ms.assetid: 962912ac-8931-49bf-a88c-0200b6e37362
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Properties
Properties are name-value pairs that can be used to configure builds. Properties are useful for passing values to tasks, evaluating conditions, and storing values that will be referenced throughout the project file.  
  
## Defining and Referencing Properties in a Project File  
 Properties are declared by creating an element that has the name of the property as a child of a [PropertyGroup](../vs140/propertygroup-element--msbuild-.md) element. For example, the following XML creates a property named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that has a value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Throughout the project file, properties are referenced by using the syntax $(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). For example, the property in the previous example is referenced by using $(BuildDir).  
  
 Property values can be changed by redefining the property. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property can be given a new value by using this XML:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Properties are evaluated in the order in which they appear in the project file. The new value for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be declared after the old value is assigned.  
  
## Reserved Properties  
 MSBuild reserves some property names to store information about the project file and the MSBuild binaries. These properties are referenced by using the $ notation, just like any other property. For example, $(MSBuildProjectFile) returns the complete file name of the project file, including the file name extension.  
  
 For more information, see [How To: Reference the Name or Location of the Project File](../vs140/how-to--reference-the-name-or-location-of-the-project-file.md) and [MSBuild Reserved Properties](../vs140/msbuild-reserved-and-well-known-properties.md).  
  
## Environment Properties  
 You can reference environment variables in project files just as you reference reserved properties. For example, to use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> environment variable in your project file, use $(Path). If the project contains a property definition that has the same name as an environment property, the property in the project overrides the value of the environment variable.  
  
 Each MSBuild project has an isolated environment block: it only sees reads and writes to its own block.  MSBuild only reads environment variables when it initializes the property collection, before the project file is evaluated or built. After that, environment properties are static, that is, each spawned tool starts with the same names and values.  
  
 To get the current value of environment variables from within a spawned tool, use the [property function](../vs140/property-functions.md) System.Environment.GetEnvironmentVariable. The preferred method, however, is to use the task parameter \<xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables*>. Environment properties set in this string array can be passed to the spawned tool without affecting the system environment variables.  
  
> [!TIP]
>  Not all environment variables are read in to become initial properties. Any environment variable whose name is not a valid MSBuild property names, such as "386", is ignored.  
  
 For more information, see [How To: Use Environment Variables in a Build](../vs140/how-to--use-environment-variables-in-a-build.md).  
  
## Registry Properties  
 You can read system registry values by using the following syntax, where <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the registry hive (for example, HKEY_LOCAL_MACHINE ), <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is the key name, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the subkey name, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the value of the subkey.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To get the default subkey value, omit the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This registry value can be used to initialize a build property. For example, to create a build property that represents the Visual Studio web browser home page, use this code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Global Properties  
 MSBuild lets you set properties on the command line by using the **/property** (or **/p**) switch. These global property values override property values that are set in the project file. This includes environment properties, but does not include reserved properties, which cannot be changed.  
  
 The following example sets the global <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Global properties can also be set or modified for child projects in a multi-project build by using the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute of the MSBuild task. For more information, see [MSBuild task](../vs140/msbuild-task.md).  
  
 If you specify a property by using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute in a project tag, that global property value doesn't override the property value that's set in the project file. For more information, see [Project Element (MSBuild)](../vs140/project-element--msbuild-.md) and [How to: Build the Same Source Files with Different Options](../vs140/how-to--build-the-same-source-files-with-different-options.md).  
  
## Property Functions  
 Starting in .NET Framework version 4, you can use property functions to evaluate your MSBuild scripts. You can read the system time, compare strings, match regular expressions, and perform many other actions within your build script without using MSBuild tasks.  
  
 You can use string (instance) methods to operate on any property value, and you can call the static methods of many system classes. For example, you can set a build property to today's date as follows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information, and a list of property functions, see [Property Functions](../vs140/property-functions.md).  
  
## Creating Properties During Execution  
 Properties positioned outside <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, properties can be created or modified as follows:  
  
-   A property can be emitted by any task. To emit a property, the [Task](../vs140/task-element--msbuild-.md) element must have a child [Output](../vs140/output-element--msbuild-.md) element that has a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute.  
  
-   A property can be emitted by the [CreateProperty](../vs140/createproperty-task.md) task. This usage is deprecated.  
  
-   Starting in the .NET Framework 3.5, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> elements may contain <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> elements that may contain property declarations.  
  
## Storing XML in Properties  
 Properties can contain arbitrary XML, which can help in passing values to tasks or displaying logging information. The following example shows the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> property, which has a value that contains XML and other property references. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] replaces the property references by using their respective property values. Property values are assigned in the order in which they appear. Therefore, in this example, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> should have already been defined.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild](../vs140/msbuild.md)   
 [How To: Use Environment Variables in a Build](../vs140/how-to--use-environment-variables-in-a-build.md)   
 [How To: Reference the Name or Location of the Project File](../vs140/how-to--reference-the-name-or-location-of-the-project-file.md)   
 [How to: Build the Same Source Files with Different Options](../vs140/how-to--build-the-same-source-files-with-different-options.md)   
 [MSBuild Reserved Properties](../vs140/msbuild-reserved-and-well-known-properties.md)   
 [Property Element (MSBuild)](../vs140/property-element--msbuild-.md)