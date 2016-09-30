---
title: "New File Command"
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
  - "file.newfile"
helpviewer_keywords: 
  - "File.NewFile command"
  - "New File command"
ms.assetid: 767868d6-a525-425b-a43b-2198f636ab6b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# New File Command
Creates a new file and opens it. The file appears under the Miscellaneous Files folder.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Name for the file. If no name is supplied, a default name is provided. If no template name is listed, a text file is created.  
  
## Switches  
 /t:<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. Specifies the type of file to be created.  
  
 The /t:<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument syntax mirrors the information found in the New File Dialog Box. Enter the category name followed by a backslash (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) and the template name, and enclose the entire string in quotation marks.  
  
 For example, to create a new [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] source file, you would enter the following for the /t:<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The example above indicates that the C++ File template is located under the Visual C++ category in the **New File** dialog box.  
  
 /e:<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. Name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.  
  
 The /e:<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument syntax uses the editor names as they appear in the Open With Dialog Box, enclosed in quotation marks.  
  
 For example, to open a file in the source code editor, you would enter the following for the /e:<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This example creates a new Web page "test1.htm" and opens it in the source code editor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Immediate Window](../vs140/immediate-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)