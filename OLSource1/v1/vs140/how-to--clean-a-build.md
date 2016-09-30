---
title: "How to: Clean a Build"
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
  - "Exec task [MSBuild]"
  - "MSBuild, cleaning a build"
  - "directories [.NET Framework], for output items"
  - "output, removing items"
ms.assetid: 999ba473-b0c4-45c7-930a-63ea7a510509
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Clean a Build
When you clean a build, all intermediate and output files are deleted, leaving only the project and component files. From the project and component files, new instances of the intermediate and output files can then be built. The library of common tasks that is provided with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] includes an [Exec](../vs140/exec-task.md) task that you can use to run system commands. For more information on the library of tasks, see [MSBuild Task Reference](../vs140/msbuild-task-reference.md).  
  
## Creating a Directory for Output Items  
 By default, the .exe file that is created when you compile a project is placed in the same directory as the project and source files. Typically, however, output items are created in a separate directory.  
  
#### To create a directory for output items  
  
1.  Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element to define the location and name of the directory. For example, create a directory named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the directory that contains the project and source files:  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
2.  Use the [MakeDir](../vs140/makedir-task.md) task to create the directory if the directory does not exist. For example:  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Removing the Output Items  
 Prior to creating new instances of intermediate and output files, you may want to clear all previous instances of intermediate and output files. Use the [RemoveDir](../vs140/removedir-task.md) task to delete a directory and all files and directories that it contains from a disk.  
  
#### To remove a directory and all files contained in the directory  
  
-   Use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task to remove the directory. For example:  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Example  
 The following code example project contains a new target, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, that uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> task to delete a directory and all files and directories that it contains. Also in this example, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> target creates a separate directory for the output items that are deleted when the build is cleaned.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is defined as the default target and is therefore used automatically unless you specify a different target or targets. You use the command line switch **/target** to specify a different target. For example:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 The **/target** switch can be shortened to **/t** and can specify more than one target. For example, to use the target <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> then the target <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, type:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Exec Task](../vs140/exec-task.md)   
 [MakeDir Task](../vs140/makedir-task.md)   
 [RemoveDir Task](../vs140/removedir-task.md)   
 [Csc Task](../vs140/csc-task.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)