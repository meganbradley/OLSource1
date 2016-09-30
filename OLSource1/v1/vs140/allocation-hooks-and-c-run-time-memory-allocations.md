---
title: "Allocation Hooks and C Run-Time Memory Allocations"
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
  - "vs.debug.hooks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], hook functions"
  - "memory allocation, troubleshooting allocation hooks"
  - "allocation hooks"
  - "hooks, allocation"
ms.assetid: cc34ee96-3d91-41bd-a019-aa3759139e7e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Allocation Hooks and C Run-Time Memory Allocations
A very important restriction on allocation hook functions is that they must explicitly ignore <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> blocks (the memory allocations made internally by C run-time library functions) if they make any calls to C run-time library functions that allocate internal memory. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks can be ignored by including code such as the following at the beginning of your allocation hook function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If your allocation hook does not ignore <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks, then any C run-time library function called in your hook can trap the program in an endless loop. For example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> makes an internal allocation. If your hook code calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, then the resulting allocation will cause your hook to be called again, which will call **printf** again, and so on until the stack overflows. If you need to report <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> allocation operations, one way to circumvent this restriction is to use Windows API functions, rather than C run-time functions, for formatting and output. Because the Windows APIs do not use the C run-time library heap, they will not trap your allocation hook in an endless loop.  
  
 If you examine the run-time library source files, you will see that the default allocation hook function, **CrtDefaultAllocHook** (which simply returns **TRUE**), is located in a separate file of its own, DBGHOOK.C. If you want your allocation hook to be called even for the allocations made by the run-time startup code that is executed before your application's **main** function, you can replace this default function with one of your own, instead of using [_CrtSetAllocHook](../vs140/_crtsetallochook.md).  
  
## See Also  
 [Debug Hook Function Writing](../vs140/debug-hook-function-writing.md)   
 [crt_dbg2 Sample](assetId:///21e1346a-6a17-4f57-b275-c76813089167)