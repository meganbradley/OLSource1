---
title: "Visual Studio Commands"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio, commands"
  - "commands, Visual Studio"
  - "command syntax"
ms.assetid: 76ffa394-ee89-4629-aba9-1a62b72e6cc1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio Commands
Visual Studio commands allow you to invoke a command from the **Command** window, **Immediate** window, or **Find/Command** box. In each case, the greater than sign (`>`) is used to indicate that a command rather than a search or debug operation is to follow.  
  
 You can find a complete list of commands and their syntax in the **Keyboard, Environment Options** dialog box.  
  
 The escape character for Visual Studio commands is a caret (^) character, which means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example,  
  
```  
>Edit.Find ^^t /regex  
```  
  
 A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored.  
  
 In localized versions of the IDE, command names can be entered either in the native language of the IDE or in English. For example, you can type either `File.NewFile` or `Fichier.NouveauFichier` in the French IDE to execute the same command.  
  
 Many commands have aliases. For a list of command aliases, see [Visual Studio Command Aliases](../VS_csharp/visual-studio-command-aliases.md).  
  
 The following commands take arguments and/or switches.  
  
|Command Name|Description|  
|------------------|-----------------|  
|[Add Existing Item](../VS_csharp/add-existing-item-command.md)|Adds an existing file to the current solution and opens it.|  
|[Add Existing Project](../VS_csharp/add-existing-project-command.md)|Adds an existing project to the current solution.|  
|[Add New Item](../VS_csharp/add-new-item-command.md)|Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.|  
|[Alias](../VS_csharp/alias-command.md)|Creates a new alias for a complete command, complete command and arguments, or even another alias.|  
|[Evaluate Statement](../VS_csharp/evaluate-statement-command.md)|Evaluates and displays the given statement.|  
|[Find](../VS_csharp/find-command.md)|Searches files using a subset of the options available on the **Find and Replace** control.|  
|[Find in Files](../VS_csharp/find-in-files-command.md)|Searches files using a subset of the options available on the [Find in Files Tab, Find and Replace Window](../VS_csharp/find-in-files.md).|  
|[Go To](../VS_csharp/go-to-command.md)|Moves the cursor to the specified line.|  
|[List Call Stack](../VS_csharp/list-call-stack-command.md)|Displays the current call stack.|  
|[List Disassembly](../VS_csharp/list-disassembly-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[List Memory](../VS_csharp/list-memory-command.md)|Displays the contents of the specified range of memory.|  
|[List Modules](../VS_csharp/list-modules-command.md)|Lists the modules for the current process.|  
|[List Registers](../VS_csharp/list-registers-command.md)|Displays a list of registers.|  
|[List Source](../VS_csharp/list-source-command.md)|Displays the specified lines of source code.|  
|[List Threads](../VS_csharp/list-threads-command.md)|Displays a list of the threads in the current program.|  
|[Log Command Window Output](../VS_csharp/log-command-window-output-command.md)|Copies all input and output from the Command window into a file.|  
|[New File](../VS_csharp/new-file-command.md)|Creates a new file and adds it to the currently selected project.|  
|[Open File](../VS_csharp/open-file-command.md)|Opens an existing file and allows you to specify an editor.|  
|[Open Project](../VS_csharp/open-project-command.md)|Opens an existing project and allows you to add the project to the current solution.|  
|[Open Solution](../VS_csharp/open-solution-command.md)|Opens an existing solution.|  
|[Print](../VS_csharp/print-command.md)|Evaluates the expression and displays the results or the specified text.|  
|[Quick Watch Command](../VS_csharp/quick-watch-command.md)|Displays the selected or specified text in the **Expression** field of the **Quick Watch** dialog box.|  
|[Replace](../VS_csharp/replace-command.md)|Replaces text in files using a subset of the options available on the **Find and Replace** control.|  
|[Replace in Files](../VS_csharp/replace-in-files-command.md)|Replaces text in files using a subset of the options available in the [Replace in Files Tab, Find and Replace Window](../VS_csharp/replace-in-files.md).|  
|[Set Current Stack Frame](../VS_csharp/set-current-stack-frame-command.md)|Allows you to view a particular stack frame.|  
|[Set Current Thread](../VS_csharp/set-current-thread-command.md)|Allows you to view a particular thread.|  
|[Set Radix](../VS_csharp/set-radix-command.md)|Determines the number of bytes to view.|  
|[Shell](../VS_csharp/shell-command.md)|Launches programs from within [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] as though the command has been executed from the command prompt.|  
|[ShowWebBrowser Command](../VS_csharp/showwebbrowser-command.md)|Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.|  
|[Start](../VS_csharp/start-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[Path](../VS_csharp/symbol-path-command.md)|Sets the list of directories for the debugger to search for symbols.|  
|[Toggle Breakpoint](../VS_csharp/toggle-breakpoint-command.md)|Turns the breakpoint either on or off, depending on its current state, at the current location in the file.|  
|[WatchN Command](../VS_csharp/watch-command.md)|Creates and opens a specified instance of a **Watch** window.|  
  
## See Also  
 [Command Window](../VS_csharp/command-window.md)   
 [Find/Command Box](../VS_csharp/find-command-box.md)   
 [Visual Studio Command Aliases](../VS_csharp/visual-studio-command-aliases.md)