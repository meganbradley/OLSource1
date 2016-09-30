---
title: "-Clean (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Clean (devenv.exe)"
helpviewer_keywords: 
  - "builds [Team System], cleaning files"
  - "clean Devenv switch"
  - "/clean Devenv switch"
  - "Devenv, /clean switch"
ms.assetid: 79929dfd-22c9-4cec-a0d0-a16f15b8f7e4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Clean (devenv.exe)
Cleans all intermediary files and output directories.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The full path and name of the solution file or project file.  
  
 /project <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The path and name of a project file within the solution. You can enter a relative path from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> folder to the project file, or the project's display name, or the full path and name of the project file.  
  
 /projectconfig <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The name of a project build configuration to be used when cleaning the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> named.  
  
## Remarks  
 This switch performs the same function as the **Clean Solution** menu command within the integrated development environment (IDE).  
  
 Enclose strings that include spaces in double quotation marks.  
  
 Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> switch.  
  
## Example  
 The first example cleans the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> solution, using the default configuration specified in the solution file.  
  
 The second example cleans the project <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> project build configuration within the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> solution configuration of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/Build (devenv.exe)](../vs140/-build--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../vs140/-rebuild--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)