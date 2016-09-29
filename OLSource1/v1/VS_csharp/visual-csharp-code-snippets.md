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
|#if|Creates a [#if](../VS_csharp/sharpif--csharp-reference-.md) directive and a [#endif](../VS_csharp/sharpendif--csharp-reference-.md) directive.|Anywhere.|  
|#region|Creates a [#region](../VS_csharp/sharpregion--csharp-reference-.md) directive and a [#endregion](../VS_csharp/sharpendregion--csharp-reference-.md) directive.|Anywhere.|  
|~|Creates a destructor for the containing class.|Inside a class.|  
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute*>.|Inside a namespace (including the global namespace), a class, or a struct.|  
|checked|Creates a [checked](../VS_csharp/checked--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|ctor|Creates a constructor for the containing class.|Inside a class.|  
|cw|Creates a call to <xref:System.Console.WriteLine*>.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|do|Creates a [do](../VS_csharp/do--csharp-reference-.md)`while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|else|Creates an [else](../VS_csharp/if-else--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|enum|Creates an [enum](../VS_csharp/enum--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals*> method defined in the <xref:System.Object*> class.|Inside a class or a struct.|  
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception*> by default).|Inside a namespace (including the global namespace), a class, or a struct.|  
|for|Creates a [for](../VS_csharp/for--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|foreach|Creates a [foreach](../VS_csharp/foreach--in--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|forr|Creates a [for](../VS_csharp/for--csharp-reference-.md) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|if|Creates an [if](../VS_csharp/if-else--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|indexer|Creates an indexer declaration.|Inside a class or a struct.|  
|interface|Creates an [interface](../VS_csharp/interface--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|iterator|Creates an iterator.|Inside a class or a struct.|  
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|  
|lock|Creates a [lock](../VS_csharp/lock-statement--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show*?displayProperty=fullName>. You may have to add a reference to System.Windows.Forms.dll.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|namespace|Creates a [namespace](../VS_csharp/namespace--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace).|  
|prop|Creates an [auto-implemented property](../VS_csharp/auto-implemented-properties--csharp-programming-guide-.md) declaration.|Inside a class or a struct.|  
ropfull|Creates a property declaration with get and set accessors.|Inside a class or a struct.|  
|propg|Creates a read-only [auto-implemented property](../VS_csharp/auto-implemented-properties--csharp-programming-guide-.md) with a private "set" accessor.|Inside a class or a struct.|  
|sim|Creates a [static](../VS_csharp/static--csharp-reference-.md)[int](../VS_csharp/int--csharp-reference-.md) Main method declaration.|Inside a class or a struct.|  
|struct|Creates a [struct](../VS_csharp/struct--csharp-reference-.md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|svm|Creates a [static](../VS_csharp/static--csharp-reference-.md)[void](../VS_csharp/void--csharp-reference-.md) Main method declaration.|Inside a class or a struct.|  
|switch|Creates a [switch](../VS_csharp/switch--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|try|Creates a [try-catch](../VS_csharp/try-catch--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|tryf|Creates a [try-finally](../VS_csharp/try-finally--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unchecked|Creates an [unchecked](../VS_csharp/unchecked--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unsafe|Creates an [unsafe](../VS_csharp/unsafe--csharp-reference-.md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|using|Creates a [using](../VS_csharp/using-directive--csharp-reference-.md) directive.|Inside a namespace (including the global namespace).|  
|while|Creates a [while](../VS_csharp/while--csharp-reference-.md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
  
## See Also  
 [Code Snippet Functions](../VS_csharp/code-snippet-functions.md)   
 [Creating and Using Intellisense Code](../VS_csharp/code-snippets.md)   
 [How to: Create a New Snippet with Replacements](assetId:///8d56d43c-097a-475b-aa85-cae1554b6338)   
 [Template Parameters](../VS_csharp/template-parameters.md)   
 [How To: Use Surround-with Code Snippets](../VS_csharp/how-to--use-surround-with-code-snippets.md)   
 [How to: Restore C# Refactoring Snippets](../VS_csharp/how-to--restore-csharp-refactoring-snippets.md)