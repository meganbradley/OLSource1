---
title: "Resolve Ambiguity Dialog Box"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.Disambig"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Resolve Ambiguity dialog box"
  - "debugger, Resolve Ambiguity dialog box"
  - "debugging [C++], resolving ambiguity"
ms.assetid: d9f47455-a116-4c84-8bad-2dfbf4d77f74
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resolve Ambiguity Dialog Box
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> dialog box appears when the debugger cannot choose the location to display. For example, if you are using C++ templates, you can create multiple functions from a single function template. If the debugger stops at a source location in the template, and you choose <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the debugger has multiple options. Each function created from the template has its own disassembly code, and the debugger does not know which code you want to view. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> dialog box enables you to select the location you want from a list of all corresponding locations.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Lists all the locations corresponding to your command.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Shows the memory addresses for each function.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Shows the name of each function.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Shows the module (EXE or DLL) containing the object code for the function.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)