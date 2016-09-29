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
author: ""
ms.author: ""
manager: ""
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
  
 Many commands have aliases. For a list of command aliases, see [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md).  
  
 The following commands take arguments and/or switches.  
  
|Command Name|Description|  
|------------------|-----------------|  
|[Add Existing Item](../vs140/add-existing-item-command.md)|Adds an existing file to the current solution and opens it.|  
|[Add Existing Project](../vs140/add-existing-project-command.md)|Adds an existing project to the current solution.|  
|[Add New Item](../vs140/add-new-item-command.md)|Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.|  
|[Alias](../vs140/alias-command.md)|Creates a new alias for a complete command, complete command and arguments, or even another alias.|  
|[Evaluate Statement](../vs140/evaluate-statement-command.md)|Evaluates and displays the given statement.|  
|[Find](../vs140/find-command.md)|Searches files using a subset of the options available on the **Find and Replace** control.|  
|[Find in Files](../vs140/find-in-files-command.md)|Searches files using a subset of the options available on the [Find in Files Tab, Find and Replace Window](../vs140/find-in-files.md).|  
|[Go To](../vs140/go-to-command.md)|Moves the cursor to the specified line.|  
|[List Call Stack](../vs140/list-call-stack-command.md)|Displays the current call stack.|  
|[List Disassembly](../vs140/list-disassembly-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[List Memory](../vs140/list-memory-command.md)|Displays the contents of the specified range of memory.|  
|[List Modules](../vs140/list-modules-command.md)|Lists the modules for the current process.|  
|[List Registers](../vs140/list-registers-command.md)|Displays a list of registers.|  
|[List Source](../vs140/list-source-command.md)|Displays the specified lines of source code.|  
|[List Threads](../vs140/list-threads-command.md)|Displays a list of the threads in the current program.|  
|[Log Command Window Output](../vs140/log-command-window-output-command.md)|Copies all input and output from the Command window into a file.|  
|[New File](../vs140/new-file-command.md)|Creates a new file and adds it to the currently selected project.|  
|[Open File](../vs140/open-file-command.md)|Opens an existing file and allows you to specify an editor.|  
|[Open Project](../vs140/open-project-command.md)|Opens an existing project and allows you to add the project to the current solution.|  
|[Open Solution](../vs140/open-solution-command.md)|Opens an existing solution.|  
|[Print](../vs140/print-command.md)|Evaluates the expression and displays the results or the specified text.|  
|[Quick Watch Command](../vs140/quick-watch-command.md)|Displays the selected or specified text in the **Expression** field of the **Quick Watch** dialog box.|  
|[Replace](../vs140/replace-command.md)|Replaces text in files using a subset of the options available on the **Find and Replace** control.|  
|[Replace in Files](../vs140/replace-in-files-command.md)|Replaces text in files using a subset of the options available in the [Replace in Files Tab, Find and Replace Window](../vs140/replace-in-files.md).|  
|[Set Current Stack Frame](../vs140/set-current-stack-frame-command.md)|Allows you to view a particular stack frame.|  
|[Set Current Thread](../vs140/set-current-thread-command.md)|Allows you to view a particular thread.|  
|[Set Radix](../vs140/set-radix-command.md)|Determines the number of bytes to view.|  
|[Shell](../vs140/shell-command.md)|Launches programs from within [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] as though the command has been executed from the command prompt.|  
|[ShowWebBrowser Command](../vs140/showwebbrowser-command.md)|Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.|  
|[Start](../vs140/start-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[Path](../vs140/symbol-path-command.md)|Sets the list of directories for the debugger to search for symbols.|  
|[Toggle Breakpoint](../vs140/toggle-breakpoint-command.md)|Turns the breakpoint either on or off, depending on its current state, at the current location in the file.|  
|[WatchN Command](../vs140/watch-command.md)|Creates and opens a specified instance of a **Watch** window.|  
  
## See Also  
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)