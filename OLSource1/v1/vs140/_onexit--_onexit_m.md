---
title: "_onexit, _onexit_m"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_onexit"
  - "_onexit_m"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_onexit"
  - "onexit_m"
  - "onexit"
  - "_onexit_m"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "onexit function"
  - "registry, registering exit routines"
  - "_onexit_m function"
  - "onexit_m function"
  - "_onexit function"
  - "registering exit routines"
  - "registering to be called on exit"
ms.assetid: 45743298-0e2f-46cf-966d-1ca44babb443
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _onexit, _onexit_m
Registers a routine to be called at exit time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a function to be called at exit.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a pointer to the function if successful or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there is no space to store the function pointer.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is passed the address of a function (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to be called when the program terminates normally. Successive calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> create a register of functions that are executed in LIFO (last-in-first-out) order. The functions passed to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> cannot take parameters.  
  
 In the case when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is called from within a DLL, routines registered with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> run on a DLL's unloading after <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called with DLL_PROCESS_DETACH.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a Microsoft extension. For ANSI portability, use [atexit](../vs140/atexit.md). The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> version of the function is for mixed mode use.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Diagnostics::Process::Exited](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.exited.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [atexit](../vs140/atexit.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [__dllonexit](../vs140/__dllonexit.md)