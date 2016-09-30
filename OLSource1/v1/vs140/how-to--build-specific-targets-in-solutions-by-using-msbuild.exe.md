---
title: "How to: Build Specific Targets in Solutions By Using MSBuild.exe"
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
  - "MSBuild, building specific targets in a solution"
  - "msbuild.exe, building specific targets in a solution"
  - "MSBuild, msbuild.exe"
ms.assetid: f46feb9b-4c16-4fec-b6e1-36a959692ba3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Build Specific Targets in Solutions By Using MSBuild.exe
You can use MSBuild.exe to build specific targets of specific projects in a solution.  
  
### To build a specific target of a specific project in a solution  
  
1.  At the command line, type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> corresponds to the file name of the solution that contains the target that you want to execute.  
  
2.  Specify the target after the **/t** switch in the format *ProjectName*:*TargetName*.  
  
## Example  
 The following example executes the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> target of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> project, and then executes the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> target of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> project, which is located in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> solution folder.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)