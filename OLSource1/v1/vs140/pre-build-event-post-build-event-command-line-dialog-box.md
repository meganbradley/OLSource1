---
title: "Pre-build Event-Post-build Event Command Line Dialog Box"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Pre-build Event/Post-build Event Command Line Dialog Box"
f1_keywords: 
  - "cs.ProjectPropertiesBuildEventsBuilder"
  - "vb.ProjectPropertiesBuildEventsBuilder"
helpviewer_keywords: 
  - "$(SolutionExt)"
  - "$(ProjectDir)"
  - "$(TargetPath)"
  - "$(ProjectExt)"
  - "$(TargetFileName)"
  - "$(PlatformName)"
  - "$(SolutionName)"
  - "macros, build events"
  - "$(SolutionPath)"
  - "$(ProjectPath)"
  - "$(ProjectFileName)"
  - "$(DevEnvDir)"
  - "$(TargetName)"
  - "$(TargetDir)"
  - "$(SolutionDir)"
  - "$(TargetExt)"
  - "$(OutDir)"
  - "$(ConfigurationName)"
  - "$(SolutionFileName)"
  - "$(ProjectName)"
  - "build events, macros"
ms.assetid: d49b2c57-24bf-4fb2-8351-5c4b6cca938f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pre-build Event-Post-build Event Command Line Dialog Box
You can type pre- or post-build events for the [Build Events Pane](../vs140/build-events-page--project-designer--csharp-.md) directly in the edit box, or you can select pre- and post-build macros from a list of available macros.  
  
> [!NOTE]
>  Pre-build events do not run if the project is up to date and no build is triggered.  
  
## UI Element List  
 **Command line edit box**  
 Contains the events to run either for pre-build or post-build.  
  
> [!NOTE]
>  Add a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement before all post-build commands that run .bat files. For example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **Macros**  
 Expands the edit box to display a list of macros to insert in the command line edit box.  
  
 **Macro table**  
 Lists the available macros and its value. See Macros below for a description of each. You can select only one macro at a time to insert into the command line edit box.  
  
 **Insert**  
 Inserts into the command line edit box the macro selected in the macro table.  
  
### Macros  
 You can use any of these macros to specify locations for files, or to get the actual name of the input file in the case of multiple selections. These macros are not case-sensitive.  
  
|Macro|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The name of the current project configuration, for example, "Debug".|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Path to the output file directory, relative to the project directory. This resolves to the value for the Output Directory property. It includes the trailing backslash '\\'.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The installation directory of Visual Studio (defined with drive and path); includes the trailing backslash '\\'.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The name of the currently targeted platform. For example, "AnyCPU".|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The directory of the project (defined with drive and path); includes the trailing backslash '\\'.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The absolute path name of the project (defined with drive, path, base name, and file extension).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The base name of the project.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The file name of the project (defined with base name and file extension).|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The file extension of the project. It includes the '.' before the file extension.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The directory of the solution (defined with drive and path); includes the trailing backslash '\\'.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The absolute path name of the solution (defined with drive, path, base name, and file extension).|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The base name of the solution.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The file name of the solution (defined with base name and file extension).|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The file extension of the solution. It includes the '.' before the file extension.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The directory of the primary output file for the build (defined with drive and path). It includes the trailing backslash '\\'.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The absolute path name of the primary output file for the build (defined with drive, path, base name, and file extension).|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The base name of the primary output file for the build.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The file name of the primary output file for the build (defined as base name and file extension).|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The file extension of the primary output file for the build. It includes the '.' before the file extension.|  
  
## See Also  
 [Specifying Custom Build Events](../vs140/specifying-custom-build-events-in-visual-studio.md)   
 [Build Events Pane, Project Designer (C#)](../vs140/build-events-page--project-designer--csharp-.md)   
 [How to: Specify Build Events](../vs140/how-to--specify-build-events--visual-basic-.md)   
 [How To: Specify Build Events (C#)](../vs140/how-to--specify-build-events--csharp-.md)