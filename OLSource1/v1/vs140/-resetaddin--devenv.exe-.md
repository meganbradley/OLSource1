---
title: "-ResetAddin (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ResetAddin (devenv.exe)"
helpviewer_keywords: 
  - "disable addin"
  - "addin state"
  - "reset addin"
ms.assetid: 9e339c8d-d768-4d86-8f45-2f479fc8255b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ResetAddin (devenv.exe)
Removes commands and command UI associated with the specified Add-in.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. The command name of the Add-in.  
  
## Remarks  
 By default, the command name of the add-in is equal to *\<AddInSolutionName>*.Connect*.\<AddInSolutionName>*, and appears in Connect.cs as the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method. You can also verify the command name by starting to type the name of the add-in into the Commands window in Visual Studio, and using Intellisense to fill in the rest.  
  
## Example  
 The following example starts Visual Studio and prevents the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> add-in from running at startup.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3)   
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)