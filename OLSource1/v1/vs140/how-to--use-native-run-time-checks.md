---
title: "How to: Use Native Run-Time Checks"
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
  - "c.runtime.errorchecks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "/RTC compiler option [C++], /O compiler option"
  - "run-time checks, native"
  - "stack, pointer corruption"
  - "stack pointers, corruption"
  - "/O compiler option, /RTC option"
  - "run-time errors, error checks"
  - "O compiler option, /RTC option"
  - "debugger, runtime errors"
  - "variables [debugger], loss of data"
  - "runtime_checks pragma"
  - "variables [debugger], catching dependencies on uninitialized local variables"
  - "run-time errors, debugging"
  - "debugger, native run-time checks"
  - "optimized build option"
  - "RTC compiler option, /O compiler option"
  - "native run-time checks"
  - "run-time checks"
  - "debugging arrays"
  - "stack pointers"
  - "arrays [Visual Studio], debugging"
ms.assetid: dc7b2f1e-5ff6-42e0-89b3-dc9dead83ee1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Native Run-Time Checks
In Visual C++, you can use native [runtime checks](../vs140/runtime_checks.md) to catch common run-time errors such as:  
  
-   Stack pointer corruption.  
  
-   Overruns of local arrays.  
  
-   Stack corruption.  
  
-   Dependencies on uninitialized local variables.  
  
-   Loss of data on an assignment to a shorter variable.  
  
 If you use **/RTC** with an optimized (**/O**) build, a compiler error results. If you use a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> pragma in an optimized build, the pragma has no effect.  
  
 When you debug a program that has run-time checks enabled, the default action is for the program to stop and break to the debugger when a run-time error occurs. You can change this default behavior for any run-time check. For more information, see [Exception Handling (Debugging)](../vs140/managing-exceptions-with-the-debugger.md).  
  
 The following procedures describe how to enable native run-time checks in a debug build, and how to modify native run-time check behavior.  
  
 Other topics in this section provide information about:  
  
-   [Customizing Run-Time Checks with the C Run-Time Library](../vs140/native-run-time-checks-customization.md)  
  
-   [Using Run-Time Checks without the C Run-Time Library](../vs140/using-run-time-checks-without-the-c-run-time-library.md)  
  
### To enable native run-time checks in a debug build  
  
-   Use the **/RTC** option and link with the debug version of a C run-time library (/MDd, for example).  
  
### To modify native run-time check behavior  
  
-   Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pragma.  
  
## See Also  
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)   
 [runtime_checks](../vs140/runtime_checks.md)   
 [Run-Time Error Checking](../vs140/run-time-error-checking.md)