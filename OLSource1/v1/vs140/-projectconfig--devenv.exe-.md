---
title: "-ProjectConfig (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ProjectConfig (devenv.exe)"
helpviewer_keywords: 
  - "/projectconfig Devenv switch"
  - "configurations, rebuilding"
  - "deployment projects, creating"
  - "configurations, cleaning"
  - "deployment projects, specifying"
  - "deployment projects, adding"
  - "build configurations, specifying"
  - "Devenv, /projectconfig switch"
  - "projectconfig Devenv switch (/projectconfig)"
  - "projects [Visual Studio], build configuration"
  - "projects [Visual Studio], cleaning"
ms.assetid: 6b54ef59-ffed-4f62-a645-1279ede97ebf
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ProjectConfig (devenv.exe)
Specifies a project build configuration to be applied when you build, clean, rebuild, or deploy the project named in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 /build  
 Builds the project specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 /clean  
 Cleans all intermediary files and output directories created during a build.  
  
 /rebuild  
 Cleans then builds the project specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 /deploy  
 Specifies that the project be deployed after a build or rebuild.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. The name of the solution configuration that will be applied to the solution named in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Required. The full path and name of the solution file.  
  
 /project <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Optional. The path and name of a project file within the solution. You can enter a relative path from the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> folder to the project file, or the project's display name, or the full path and name of the project file.  
  
 /projectconfig <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Optional. The name of a project build configuration to be applied to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> named.  
  
## Remarks  
  
-   Must be used with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> switch as part of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, /<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> command.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> switch.  
  
## Example  
 This example builds the project <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> project build configuration within the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> solution configuration of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [/Project (devenv.exe)](../vs140/-project--devenv.exe-.md)   
 [/Build (devenv.exe)](../vs140/-build--devenv.exe-.md)   
 [/Clean (devenv.exe)](../vs140/-clean--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../vs140/-rebuild--devenv.exe-.md)   
 [/Deploy (devenv.exe)](../vs140/-deploy--devenv.exe-.md)   
 [/out (Visual Studio)](../vs140/-out--devenv.exe-.md)