---
title: "How to: Build the Same Source Files with Different Options"
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
  - "source files, building with different options"
  - "MSBuild, properties"
  - "project properties, modifying"
  - "Hello World example [Visual Studio]"
ms.assetid: d14f1212-ddd9-434f-b138-f840011b0fb2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Build the Same Source Files with Different Options
When you build projects, you frequently compile the same components with different build options. For example, you can create a debug build with symbol information or a release build with no symbol information but with optimizations enabled. Or you can build a project to run on a specific platform, such as x86 or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]. In all these cases, most of the build options stay the same; only a few options are changed to control the build configuration. With [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)], you use properties and conditions to create the different build configurations.  
  
## Using Properties to Modify Projects  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element defines a variable that is referenced several times in a project file, such as the location of a temporary directory, or to set the values for properties that are used in several configurations, such as a Debug build and a Release build. For more information about properties, see [MSBuild Properties](../vs140/msbuild-properties.md).  
  
 You can use properties to change the configuration of your build without having to change the project file. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element allows you to change the value of properties. For more information about [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] conditions, see [MSBuild Conditions](../vs140/msbuild-conditions.md).  
  
#### To set a group of properties based on another property  
  
-   Use a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute in a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element similar to the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### To define a property based on another property  
  
-   Use a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute in a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element similar to the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Specifying Properties on the Command Line  
 Once your project file is written to accept multiple configurations, you need to have the ability to change those configurations whenever you build your project. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] provides this ability by allowing properties to be specified on the command line using the **/property** or **/p** switch.  
  
#### To set a project property at the command line  
  
-   Use the **/property** switch with the property and property value. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To specify more than one project property at the command line  
  
-   Use the **/property** or **/p** switch multiple times with the property and property values, or use one **/property** or **/p** switch and separate multiple properties with semicolons (;). For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     - or-  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Environment variables are also treated as properties and are automatically incorporated by [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]. For more information about using environment variables, see [How To: Use Environment Variables in a Build](../vs140/how-to--use-environment-variables-in-a-build.md).  
  
 The property value that is specified on the command line takes precedence over any value that is set for the same property in the project file, and that value in the project file takes precedence over the value in an environment variable.  
  
 You can change this behavior by using the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute in a project tag. For property names that are listed with that attribute, the property value that's specified on the command line doesn't take precedence over the value in the project file. You can find an example later in this topic.  
  
## Example  
 The following code example, the "Hello World" project, contains two new property groups that can be used to create a Debug build and a Release build.  
  
 To build the debug version of this project, type:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To build the retail version of this project, type:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Example  
 The following example illustrates how to use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property has a value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in the project file and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in the command line. With <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the project tag, the command-line property (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) doesn't override the property that's defined in the project file (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>).  
  
 To build the project, enter the following command:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)