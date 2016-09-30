---
title: "-Project (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Project (devenv.exe)"
helpviewer_keywords: 
  - "/project Devenv switch"
  - "projects [Visual Studio], rebuilding"
  - "projects [Visual Studio], building"
  - "deployment projects, specifying"
  - "project Devenv switch (/project)"
  - "Devenv, /project switch"
  - "projects [Visual Studio], cleaning"
ms.assetid: 8b07859c-3439-436d-9b9a-a8ee744eee30
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Project (devenv.exe)
Identifies a single project within the specified solution configuration to build, clean, rebuild, or deploy.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 /build  
 Builds the project specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 /clean  
 Cleans all intermediary files and output directories created during a build.  
  
 /rebuild  
 Cleans then builds the project specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 /deploy  
 Specifies that the project be deployed after a build or rebuild.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required. The name of the solution configuration that will be applied to the solution named in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required. The full path and name of the solution file.  
  
 /project <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. The path and name of a project file within the solution. You can enter a relative path from the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> folder to the project file, or the project's display name, or the full path and name of the project file.  
  
 /projectconfig <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Optional. The name of a project build configuration to be applied to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> named.  
  
## Remarks  
  
-   Must be used part of a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, /<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> command.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example builds the project <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> project build configuration within the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> solution configuration of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/projectconfig](../vs140/-projectconfig--devenv.exe-.md)   
 [/Build (devenv.exe)](../vs140/-build--devenv.exe-.md)   
 [/Clean (devenv.exe)](../vs140/-clean--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../vs140/-rebuild--devenv.exe-.md)   
 [/Deploy (devenv.exe)](../vs140/-deploy--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)