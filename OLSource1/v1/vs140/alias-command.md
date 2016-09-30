---
title: "Alias Command"
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
  - "tools.alias"
helpviewer_keywords: 
  - "aliases, Visual Studio commands"
  - "commands, aliases"
  - "Tools.Alias command"
  - "command aliases"
  - "alias command"
ms.assetid: bdf857df-b5d5-450f-8c10-a6fd4dccc130
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Alias Command
Creates a new alias for a complete command, complete command and arguments, or another alias.  
  
> [!TIP]
>  Typing <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> without any arguments displays the current list of aliases and their definitions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The name for the new alias. If no value is supplied for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, a list of the current aliases and their definitions appears.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. The complete command name or existing alias and any parameters that you want to create as an alias. If no value is supplied for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the alias name and alias string for the specified alias displays.  
  
## Switches  
 /delete or /del or /d  
 Optional. Deletes the specified alias, removing it from autocompletion.  
  
 /reset  
 Optional. Resets the list of pre-defined aliases to its original settings. That is, it restores all pre-defined aliases and removes all user-defined aliases.  
  
## Remarks  
 Since aliases represent commands, they must be located at the beginning of the command line.  
  
 When issuing this command, you should include the switches immediately after the command, not after the aliases, otherwise the switch itself will be included as part of the alias string.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> switch asks for a confirmation before the aliases are restored. There is no short form of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Examples  
 This example creates a new alias, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, for the complete command Edit.MakeUpperCase.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example deletes the alias, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example displays a list of all current aliases and definitions.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)