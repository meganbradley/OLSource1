---
title: "How to: Build a Project That Has Resources"
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
  - "resource files, compiling with MSBuild"
  - "resources [Visual Studio], compiling with MSBuild"
  - "projects [.NET Framework], building"
  - "MSBuild, building a project with resources"
ms.assetid: d07ac73f-2c2d-4e9a-812a-6dcb632bafe2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Build a Project That Has Resources
If you are building localized versions of a project, all user interface elements must be separated into resource files for the different languages. If the project uses only strings, the resource files can use text files. Alternatively, you can use .resx files as the resource files.  
  
## Compiling Resources with MSBuild  
 The library of common tasks that is provided with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] includes a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task that you can use to compile resources in either .resx or text files. This task includes the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter to specify which resource files to compile and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter to specify names for the output resource files. For more information on the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> task, see [GenerateResource Task](../vs140/generateresource-task.md).  
  
#### To compile resources with MSBuild  
  
1.  Identify the project's resource files and pass them to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task, either as item lists, or as file names.  
  
2.  Specify the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> task, which allows you to set the names for the output resource files.  
  
3.  Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element of the task to store the value of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter in an item.  
  
4.  Use the item created from the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element as an input into another task.  
  
## Example  
 The following code example shows how the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element specifies that the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task will contain the compiled resource files <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and that those two files will be placed inside the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> item list. By identifying those .resources files as a collection of items of the same name, you can easily use them as inputs for another task, such as the [Csc](../vs140/csc-task.md) task.  
  
 This task is equivalent to using the **/compile** switch for [Resgen.exe](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4):  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example project contains two tasks: the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> task to compile resources and the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> task to compile both the source code files and the compiled resources files. The resource files compiled by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> task are stored in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> item and passed to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> task.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [GenerateResource Task](../vs140/generateresource-task.md)   
 [Csc Task](../vs140/csc-task.md)   
 [Resource File Generator (Resgen.exe)](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4)