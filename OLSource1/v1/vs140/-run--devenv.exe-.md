---
title: "-Run (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Run (devenv.exe)"
helpviewer_keywords: 
  - "/run Devenv"
  - "run Devenv switch"
  - "applications [Visual Studio], running"
  - "/r Devenv switch"
  - "Devenv, /run switch"
  - "r Devenv switch (/r)"
ms.assetid: b1f22f9d-39a5-4918-8a2a-4b5c1e872665
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Run (devenv.exe)
Compiles and runs the specified project or solution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The full path and name of a solution file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The full path and name of a project file.  
  
## Remarks  
 Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch launches the integrated development environment (IDE) and leaves it active after the project or solution has completed running.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example runs the solution <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> using the active deployment configuration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/Runexit (devenv.exe)](../vs140/-runexit--devenv.exe-.md)   
 [/build](../vs140/-build--devenv.exe-.md)   
 [/rebuild (Visual Studio)](../vs140/-rebuild--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)