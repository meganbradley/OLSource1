---
title: "Visual C# Code Snippets"
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
  - "snippets [C#], default snippets"
  - "snippets [C#], Code Snippet Inserter"
  - "Code Snippet Inserter [J#]"
  - "Code Snippet Inserter [C#]"
  - "Visual C#, default snippets"
ms.assetid: dbea3dd6-e650-4190-b874-c9f097d7de6e
caps.latest.revision: 37
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual C# Code Snippets
Code snippets are ready-made snippets of code you can quickly insert into your code. For example, the `for` code snippet creates an empty `for` loop. Some code snippets are surround-with code snippets, which enable you to select lines of code, and then choose a code snippet which incorporates the selected lines of code. For example, when you select lines of code and then activate the `for` code snippet, it creates a `for` loop with those lines of code inside the loop block. Code snippets can make writing program code quicker, easier, and more reliable.  
  
 You can insert a code snippet at the cursor location, or insert a surround-with code snippet around the currently selected code. The Code Snippet Inserter is invoked through the **Insert Code Snippet** or **Surround With** commands on the **IntelliSense** menu, or by using the keyboard shortcuts CTRL+K and then X or CTRL+K and then S respectively.  
  
 The Code Snippet Inserter displays the code snippet name for all available code snippets. The Code Snippet Inserter also includes an input dialog box where you can type the name of the code snippet, or part of the code snippet name. The Code Snippet Inserter highlights the closest match to a code snippet name. Pressing TAB at any time will dismiss the Code Snippet Inserter and insert the currently selected code snippet. Typing ESC or clicking the mouse in the Code Editor will dismiss the Code Snippet Inserter without inserting a code snippet.  
  
## Default Code Snippets  
 By default the following code snippets are included in Visual Studio.  
  
|Name (or shortcut)|Description|Valid locations to insert snippet|  
|--------------------------|-----------------|---------------------------------------|  
|#if|Creates a [#if](../vs140/sharpif--csharp-reference-.md) directive and a [#endif](../vs140/sharpendif--csharp-reference-.md) directive.|Anywhere.|  
|#region|Creates a [#region](../vs140/sharpregion--csharp-reference-.md) directive and a [#endregion](../vs140/sharpendregion--csharp-reference-.md) directive.|Anywhere.|  
|~|Creates a destructor for the containing class.|Inside a class.|  
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute*>.|Inside a namespace (including the global namespace), a class, or a struct.|  
|checked|Creates a [checked](../vs140/checked--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|ctor|Creates a constructor for the containing class.|Inside a class.|  
|cw|Creates a call to <xref:System.Console.WriteLine*>.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|do|Creates a [do](../vs140/do--csharp-reference-.md)`while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|else|Creates an [else](../vs140/if-else--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|enum|Creates an [enum](../vs140/enum--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|equals|Creates a method declaration that overrides the [Equals](assetId:///M:System.Object.Equals(System.Object)?qualifyHint=False&autoUpgrade=True) method defined in the <xref:System.Object*> class.|Inside a class or a struct.|  
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception*> by default).|Inside a namespace (including the global namespace), a class, or a struct.|  
|for|Creates a [for](../vs140/for--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|foreach|Creates a [foreach](../vs140/foreach--in--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|forr|Creates a [for](../vs140/for--csharp-reference-.md) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|if|Creates an [if](../vs140/if-else--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|indexer|Creates an indexer declaration.|Inside a class or a struct.|  
|interface|Creates an [interface](../vs140/interface--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|iterator|Creates an iterator.|Inside a class or a struct.|  
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|  
|lock|Creates a [lock](../vs140/lock-statement--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show*?displayProperty=fullName>. You may have to add a reference to System.Windows.Forms.dll.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|namespace|Creates a [namespace](../vs140/namespace--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace).|  
|prop|Creates an [auto-implemented property](../vs140/auto-implemented-properties--csharp-programming-guide-.md) declaration.|Inside a class or a struct.|  
ropfull|Creates a property declaration with get and set accessors.|Inside a class or a struct.|  
|propg|Creates a read-only [auto-implemented property](../vs140/auto-implemented-properties--csharp-programming-guide-.md) with a private "set" accessor.|Inside a class or a struct.|  
|sim|Creates a [static](../vs140/static--csharp-reference-.md)[int](../vs140/int--csharp-reference-.md) Main method declaration.|Inside a class or a struct.|  
|struct|Creates a [struct](../vs140/struct--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|svm|Creates a [static](../vs140/static--csharp-reference-.md)[void](../vs140/void--csharp-reference-.md) Main method declaration.|Inside a class or a struct.|  
|switch|Creates a [switch](../vs140/switch--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|try|Creates a [try-catch](../vs140/try-catch--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|tryf|Creates a [try-finally](../vs140/try-finally--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unchecked|Creates an [unchecked](../vs140/unchecked--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unsafe|Creates an [unsafe](../vs140/unsafe--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|using|Creates a [using](../vs140/using-directive--csharp-reference-.md) directive.|Inside a namespace (including the global namespace).|  
|while|Creates a [while](../vs140/while--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
  
## See Also  
 [Code Snippet Functions](../vs140/code-snippet-functions.md)   
 [Creating and Using Intellisense Code](../vs140/code-snippets.md)   
 [How to: Create a New Snippet with Replacements](assetId:///8d56d43c-097a-475b-aa85-cae1554b6338)   
 [Template Parameters](../vs140/template-parameters.md)   
 [How To: Use Surround-with Code Snippets](../vs140/how-to--use-surround-with-code-snippets.md)   
 [How to: Restore C# Refactoring Snippets](../vs140/how-to--restore-csharp-refactoring-snippets.md)