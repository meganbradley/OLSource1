---
title: "Open File Command"
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
  - "file.openfile"
helpviewer_keywords: 
  - "Open File command"
  - "File.OpenFile command"
  - "of command"
ms.assetid: a51a83fc-e3c6-4fa2-8882-8b7b6c0a6406
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Open File Command
Opens an existing file and allows you to specify an editor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The full or partial path and file name of the file to open. Paths containing spaces must be enclosed in quotation marks.  
  
## Switches  
 /e:<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.  
  
 The /e:<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument syntax uses the editor names as they appear in the Open With Dialog Box, enclosed in quotation marks.  
  
 For example, to open a file in the source code editor, you would enter the following for the /e:<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 As you enter a path, auto completion tries to locate the correct path and file name.  
  
## Example  
 This example opens the style file "Test1.css" in the source code editor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Immediate Window](../vs140/immediate-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)