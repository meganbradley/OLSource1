---
title: "_getcwd_dbg, _wgetcwd_dbg"
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
  - "_wgetcwd_dbg"
  - "_getcwd_dbg"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getcwd_dbg"
  - "_wgetcwd_dbg"
  - "getcwd_dbg"
  - "wgetcwd_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wgetcwd_dbg function"
  - "working directory"
  - "_getcwd_dbg function"
  - "getcwd_dbg function"
  - "current working directory"
  - "_wgetcwd_dbg function"
  - "directories [C++], current working"
ms.assetid: 8d5d151f-d844-4aa6-a28c-1c11a22dc00d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getcwd_dbg, _wgetcwd_dbg
Debug versions of the [_getcwd, _wgetcwd](../vs140/_getcwd--_wgetcwd.md) functions (only available during debug).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Storage location for the path.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Maximum length of the path in characters: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Requested type of the memory block: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the allocation operation or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Line number in the source file where the allocation operation was requested or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a pointer to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return value indicates an error, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set either to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, indicating that there is insufficient memory to allocate <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> bytes (when a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument is given as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), or to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, indicating that the path is longer than <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> characters.  
  
 For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> functions are identical to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> except that, when _<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is defined, these functions use the debug version of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to allocate memory if <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is passed as the first parameter. For more information, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> flag. When <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is defined, calls to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>are remapped to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
## Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<crtdbg.h>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 \<xref:System.Environment.CurrentDirectory*>  
  
## See Also  
 [_getcwd, _wgetcwd](../vs140/_getcwd--_wgetcwd.md)   
 [Directory Control](../vs140/directory-control.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)