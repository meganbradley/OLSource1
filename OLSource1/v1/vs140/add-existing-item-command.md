---
title: "Add Existing Item Command"
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
  - "project.addexistingitem"
helpviewer_keywords: 
  - "File.AddExistingItem command"
  - "Add Existing Item command"
ms.assetid: 41f56131-d4c7-4f81-83b7-bdac713ea870
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Add Existing Item Command
Adds an existing file to the current solution and opens it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The full path and file name, with extension, of the item to add to the current solution. If the file path or file name contains spaces, enclose the entire path in quotation marks.  
  
## Switches  
 /e: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.  
  
 The /e:<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument syntax uses the editor names as they appear in the **Open With Dialog Box**, enclosed in quotation marks. For example, to open a style sheet in the source code editor, you would enter the following for the /e:<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 Autocompletion tries to locate the correct path and file name as you type.  
  
## Example  
 This example adds the file, Form1.frm, to the current solution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)