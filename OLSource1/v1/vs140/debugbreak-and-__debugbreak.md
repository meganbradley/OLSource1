---
title: "DebugBreak and __debugbreak"
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
  - "DebugBreak"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], DebugBreak function"
  - "DebugBreak function"
  - "breakpoints, DebugBreak function"
ms.assetid: 9787c795-df94-4f48-bc8d-3bf899b67421
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DebugBreak and __debugbreak
You can call the DebugBreak Win32 function or the [__debugbreak](../vs140/__debugbreak.md) intrinsic at any point in your code. <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> have the same effect as setting a breakpoint at that location.  
  
 Because <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a call to a system function, system debug symbols must be installed to ensure the correct call stack information is displayed after breaking. Otherwise, the call stack information displayed by the debugger may be off by one frame. If you use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, symbols are not required.  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Debugger Security](../vs140/debugger-security.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)   
 [Specify Symbol (.pdb) and Source Files in the Visual Studio Debugger](../vs140/specify-symbol--.pdb--and-source-files-in-the-visual-studio-debugger.md)