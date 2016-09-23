---
title: "Toggle Breakpoint Command"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - debug.togglebreakpoint
helpviewer_keywords: 
  - ToggleBreakpoint command
  - Debug.ToggleBreakPoint command
  - Toggle Breakpoint command
ms.assetid: d50dfadb-ce79-4d5e-9c09-1cfddd57876d
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Toggle Breakpoint Command
Turns the breakpoint either on or off, depending on its current state, at the current location in the file.  
  
## Syntax  
  
```  
Debug.ToggleBreakpoint [text]  
```  
  
## Arguments  
 `text`  
 Optional. If text is specified, the line is marked as a named breakpoint. Otherwise, the line is marked as an unnamed breakpoint, which is similar to what happens when you press F9.  
  
## Example  
 The following example toggles the current breakpoint.  
  
```  
>Debug.ToggleBreakpoint  
```  
  
## See Also  
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)