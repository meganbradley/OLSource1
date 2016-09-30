---
title: "-Rebuild (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Rebuild (devenv.exe)"
helpviewer_keywords: 
  - "Devenv, /rebuild switch"
  - "rebuild Devenv switch (/rebuild)"
  - "projects [Visual Studio], rebuilding"
  - "/rebuild Devenv switch"
  - "applications [Visual Studio], rebuilding"
ms.assetid: c5a8a4bf-0e2b-46eb-a44a-8aeb29b92c32
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Rebuild (devenv.exe)
Cleans and then builds the specified solution configuration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The name of the solution configuration that will be used to rebuild the solution named in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The full path and name of the solution file.  
  
 /project <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The path and name of a project file within the solution. You can enter a relative path from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> folder to the project file, or the project's display name, or the full path and name of the project file.  
  
 /projectconfig <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. The name of a project build configuration to be used when rebuilding the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> named.  
  
## Remarks  
  
-   This switch performs the same function as the **Rebuild Solution** menu command within the integrated development environment (IDE).  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example cleans and rebuilds the project <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> project build configuration within the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> solution configuration of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/build](../vs140/-build--devenv.exe-.md)   
 [/Clean (devenv.exe)](../vs140/-clean--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)