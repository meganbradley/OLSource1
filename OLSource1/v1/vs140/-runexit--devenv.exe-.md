---
title: "-Runexit (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Runexit (devenv.exe)"
helpviewer_keywords: 
  - "runexit Devenv switch"
  - "Devenv, /runexit switch"
  - "/runexit Devenv switch"
ms.assetid: bfc94875-5fc0-4110-b961-d59c0b403790
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Runexit (devenv.exe)
Compiles and runs the specified project or solution, and then closes the integrated development environment (IDE).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The full path and name of a solution file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The full path and name of a project file.  
  
## Remarks  
 Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch minimizes the IDE while the project or solution is run, and it closes the IDE after the project or solution has completed running.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example runs the solution <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in a minimized IDE using the active deployment configuration, and then closes the IDE.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/Run (devenv.exe)](../vs140/-run--devenv.exe-.md)   
 [/build](../vs140/-build--devenv.exe-.md)   
 [/rebuild (Visual Studio)](../vs140/-rebuild--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)