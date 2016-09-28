---
title: "Options, Text Editor, C-C++, Formatting"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Options, Text Editor, C/C++, Formatting"
f1_keywords: 
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Formatting.General"
  - "VS.ToolsOptionsPages.Text_Editor.C%2fC%2b%2b.Formatting.General"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Text Editor Options dialog box, formatting"
ms.assetid: cb6f1cbb-5305-48da-a8e8-33fd70775d46
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Options, Text Editor, C-C++, Formatting
Lets you change the default behavior of the Code Editor when you are programming in C or C++.  
  
 To access this page, in the **Options** dialog box, in the left pane, expand **Text Editor**, expand **C/C++**, and then click **Formatting**.  
  
> [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## C/C++ Options  
 **Enable automatic Quick Info ToolTips**  
 Enables or disables the Quick Info IntelliSense feature.  
  
## Inactive Code  
 **Show Inactive Code Blocks**  
 Code that is inactive due to `#ifdef` declarations are colorized differently to help you identify it.  
  
 **Disable Inactive Code Opacity**  
 Inactive code can be identified by using color instead of transparency.  
  
 **Inactive Code Opacity Percent**  
 The degree of opacity for inactive code blocks can be customized.  
  
## Indentation  
 **Indent Braces**  
 You can configure how braces are aligned when you press ENTER after you begin a code block, for example, a function or a `for` loop. The braces can either be aligned with the first character of the code block or indented.  
  
 **Automatic Indentation On Tab**  
 You can configure what happens on the current code line when you press TAB. Either the line is indented or a tab is inserted.  
  
## Miscellaneous  
 **Enumerate the comments in the Task List window**  
 The editor can scan open source files for preset words in the comments. It creates an entry in the **Task List** window for any keywords that it finds.  
  
 **Highlight Matching Tokens**  
 When the cursor is next to a brace, the editor can highlight the matching brace so that you can more easily see the contained code.  
  
## Outlining  
 **Enter outlining mode when files open**  
 When you bring a file into the text editor, you can enable the outlining feature. For more information, see [Outlining](../vs140/outlining.md). When this option is selected, the outlining feature is enabled when you open a file.  
  
 **Automatic outlining of #pragma region blocks**  
 When this option is selected, automatic outlining for [pragma directives](../vs140/pragma-directives-and-the-__pragma-keyword.md) is enabled. This lets you expand or collapse pragma region blocks in outlining mode.  
  
 **Automatic outlining of statement blocks**  
 When this option is selected, automatic outlining is enabled for the following statement constructs:  
  
-   [if-else](../vs140/if-else--csharp-reference-.md)  
  
-   [The switch Statement](../vs140/switch-statement--c---.md)  
  
-   [The while Statement](../vs140/while-statement--c---.md)  
  
## See Also  
 [General, Environment, Options Dialog Box](../vs140/general--environment--options-dialog-box.md)   
 [Using IntelliSense](../vs140/using-intellisense.md)