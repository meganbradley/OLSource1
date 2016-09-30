---
title: "Add Existing Project Command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "file.addexistingproject"
helpviewer_keywords: 
  - "Add Existing Project command"
  - "File.AddExistingProject"
ms.assetid: 71cf3e31-c76b-405b-ad6a-1b1bc654bd40
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Add Existing Project Command
Adds an existing project to the current solution.  
  
## Syntax  
  
```  
File.AddExistingProject filename  
```  
  
## Arguments  
 `filename`  
 Optional. The full path and project name, with extension, of the project to add to the solution.  
  
 If the `filename` argument includes spaces, it must be enclosed in quotation marks.  
  
 If no filename is specified, the command will open the file dialog so that user can pick a project.  
  
## Remarks  
 Auto completion tries to locate the correct path and file name as you type.  
  
## Example  
 This example adds the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project, TestProject1, to the current solution.  
  
```  
>File.AddExistingProject "c:\visual studio projects\TestProject1.vbproj"  
```  
  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)