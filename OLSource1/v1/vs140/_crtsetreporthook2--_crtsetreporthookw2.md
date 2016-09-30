---
title: "_CrtSetReportHook2, _CrtSetReportHookW2"
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
  - "_CrtSetReportHook2"
  - "_CrtSetReportHookW2"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtSetReportHookW2"
  - "CrtSetReportHook2"
  - "_CrtSetReportHookW2"
  - "_CrtSetReportHook2"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtSetReportHook2 function"
  - "_CrtSetReportHook2 function"
  - "_CrtSetReportHookW2 function"
  - "CrtSetReportHookW2 function"
ms.assetid: 12e5f68d-c8a7-4b1a-9a75-72ba4a8592d0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetReportHook2, _CrtSetReportHookW2
Installs or uninstalls a client-defined reporting function by hooking it into the C run-time debug reporting process (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The action to take: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Report hook to install or remove in the narrow-character version of this function.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Report hook to install or remove in the wide-character version of this function.  
  
## Return Value  
 -1 if an error was encountered, with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> set; otherwise returns the reference count of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> after the call.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> let you hook or unhook a function, whereas [_CrtSetReportHook](../vs140/_crtsetreporthook.md) only lets you hook a function.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> should be used instead of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> when the hook call is made in a DLL and when multiple DLLs might be loaded and setting their own hook functions. In such a situation, DLLs can be unloaded in a different order than they were loaded and the hook function can be left pointing at an unloaded DLL. Any debug output crashes the process if the hook functions were added with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Any hook functions added with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are called if there are no hook functions added with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or if all hook functions added with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The wide-character version of this function is available. The report hook functions take a string whose type (wide or narrow characters) must match the version of this function used. Use the following function prototype for the report hooks used with the wide-character version of this function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Use the following prototype for the narrow-character report hooks:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 These functions validate their parameters. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is invalid, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and return -1.  
  
> [!NOTE]
>  If your application is compiled with <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the reporting function is called after the application has exited main, the CLR will throw an exception if the reporting function calls any CRT functions.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<crtdbg.h>|\<errno.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<crtdbg.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)