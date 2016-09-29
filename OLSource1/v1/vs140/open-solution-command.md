---
title: "Open Solution Command"
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
  - "file.opensolution"
helpviewer_keywords: 
  - "Open Solution command"
  - "File.OpenSolution command"
ms.assetid: 61de76c8-69d7-4cdb-b605-e132f45d05d9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Open Solution Command
Opens an existing solution, closing any other open solutions.  
  
## Syntax  
  
```  
File.OpenSolution filename  
```  
  
## Arguments  
 `Filename`  
 Required. The full path and file name of the solution to open.  
  
 The syntax for the `filename` argument requires that paths containing spaces use quotation marks.  
  
## Remarks  
 Auto completion tries to locate the correct path and file name as you type.  
  
## Example  
 This example opens the solution, Test1.sln.  
  
```  
>File.OpenSolution "c:\MySolutions\Test1\Test1.sln"  
```  
  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)