---
title: "_getdcwd_dbg, _wgetdcwd_dbg"
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
  - "_getdcwd_dbg"
  - "_wgetdcwd_dbg"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getdcwd_dbg"
  - "getdcwd_dbg"
  - "_wgetdcwd_dbg"
  - "wgetdcwd_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "working directory"
  - "_getdcwd_dbg function"
  - "wgetdcwd_dbg function"
  - "current working directory"
  - "getdcwd_dbg function"
  - "_wgetdcwd_dbg function"
  - "directories [C++], current working"
ms.assetid: 266bf6f0-0417-497f-963d-2e0f306d9385
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getdcwd_dbg, _wgetdcwd_dbg
Debug versions of the [_getdcwd, _wgetdcwd](../vs140/_getdcwd--_wgetdcwd.md) functions (only available during debug).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the disk drive.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for the path.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum length of the path in characters: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Requested type of the memory block: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the allocation operation or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Line number in the source file where the allocation operation was requested or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a pointer to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> return value indicates an error, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set either to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, indicating that there is insufficient memory to allocate <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bytes (when a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument is given as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>), or to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, indicating that the path is longer than <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> characters. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> functions are identical to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> except that, when <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is defined, these functions use the debug version of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to allocate memory if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is passed as the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter. For more information, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> flag. When <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is defined, calls to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> are remapped to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<crtdbg.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 \<xref:System.Environment.CurrentDirectory*?displayProperty=fullName>  
  
## See Also  
 [_getdcwd, _wgetdcwd](../vs140/_getdcwd--_wgetdcwd.md)   
 [Directory Control](../vs140/directory-control.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)