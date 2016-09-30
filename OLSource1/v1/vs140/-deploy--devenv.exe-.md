---
title: "-Deploy (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Deploy (devenv.exe)"
helpviewer_keywords: 
  - "Devenv, /deploy switch"
  - "deploy Devenv switch"
  - "deploying applications [Visual Studio], after build"
  - "/deploy Devenv switch"
ms.assetid: e47c8723-df08-4645-aa2d-0c956e7ccca2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Deploy (devenv.exe)
Deploys a solution after a build or rebuild. Applies to managed code projects only.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The name of the solution configuration that will be used to build the solution named in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The full path and name of the solution file.  
  
 /project <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The path and name of a project file within the solution. You can enter a relative path from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> folder to the project file, or the project's display name, or the full path and name of the project file.  
  
 /projectconfig <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. The name of a project build configuration to be used when building the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> named.  
  
## Remarks  
 The specified project must be a deployment project. If the specified project is not a deployment project, when the project that has been built is passed to be deployed, it fails with an error.  
  
 Enclose strings that include spaces in double quotation marks.  
  
 Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example deploys the project <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> project build configuration within the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> solution configuration of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/Project (devenv.exe)](../vs140/-project--devenv.exe-.md)   
 [/Build (devenv.exe)](../vs140/-build--devenv.exe-.md)   
 [/Clean (devenv.exe)](../vs140/-clean--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../vs140/-rebuild--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)