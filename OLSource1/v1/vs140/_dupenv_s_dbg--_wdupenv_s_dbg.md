---
title: "_dupenv_s_dbg, _wdupenv_s_dbg"
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
  - "_dupenv_s_dbg"
  - "_wdupenv_s_dbg"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tdupenv_s_dbg"
  - "_dupenv_s_dbg"
  - "_wdupenv_s_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tdupenv_s_dbg function"
  - "dupenv_s_dbg function"
  - "_wdupenv_s_dbg function"
  - "environment variables"
  - "tdupenv_s_dbg function"
  - "wdupenv_s_dbg function"
  - "_dupenv_s_dbg function"
ms.assetid: e3d81148-e24e-46d0-a21d-fd87b5e6256c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _dupenv_s_dbg, _wdupenv_s_dbg
Get a value from the current environment.  Versions of [_dupenv_s, _wdupenv_s](../vs140/_dupenv_s--_wdupenv_s.md) that allocate memory with [_malloc_dbg](../vs140/_malloc_dbg.md) to provide additional debugging information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Buffer to store the variable's value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Environment variable name.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Requested type of the memory block: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to the name of the source file or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Line number in source file or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 Zero on success, an error code on failure.  
  
 These functions validate their parameters; if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 If these functions cannot allocate enough memory, they set <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to 0, and return <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> functions are identical to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> except that, when <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is defined, these functions use the debug version of [malloc](../vs140/malloc.md), [_malloc_dbg](../vs140/_malloc_dbg.md), to allocate memory for the value of the environment variable. For information on the debugging features of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the flag <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is defined, calls to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> are remapped to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information on block types, see [Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<crtdbg.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Environment::GetEnvironmentVariable](https://msdn.microsoft.com/en-us/library/system.environment.getenvironmentvariable.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [Environmental Constants](../vs140/environmental-constants.md)   
 [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md)   
 [putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md)