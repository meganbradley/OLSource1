---
title: "Add New Item Command"
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
  - "project.addnewitem"
helpviewer_keywords: 
  - "Add New Item command"
  - "File.AddNewItem command"
ms.assetid: 63b7df32-db83-463b-bbe7-7ff011fe5298
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Add New Item Command
Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. The path and file name of the item to add to the solution.  
  
## Switches  
 /t: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. Specifies the type of file to be created. If no template name is given, a text file is created by default.  
  
 The /t:<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument syntax mirrors the information found in the **Add New Solution Item** dialog box. You must enter the complete category followed by the file type, separating the category name from the file type by a backslash (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) and enclosing the entire string in quotation marks.  
  
 For example, to create a new text file, you would enter the following for the /t:<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 /e: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. The name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.  
  
 The /e:<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument syntax uses the editor names as they appear in the **Open With Dialog Box**, enclosed in quotation marks.  
  
 For example, to open a style sheet in the source code editor, you would enter the following for the /e:<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This example adds a new solution item, MyHTMLpg, to the current solution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)