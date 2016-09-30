---
title: "_fullpath_dbg, _wfullpath_dbg"
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
  - "_wfullpath_dbg"
  - "_fullpath_dbg"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wfullpath_dbg"
  - "_wfullpath_dbg"
  - "_fullpath_dbg"
  - "fullpath_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fullpath_dbg function"
  - "relative file paths"
  - "absolute paths"
  - "fullpath_dbg function"
  - "_wfullpath_dbg function"
  - "wfullpath_dbg function"
ms.assetid: 81f72f85-07da-4f5c-866a-598e0fb03f6b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fullpath_dbg, _wfullpath_dbg
Versions of [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md) that use the debug version of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to allocate memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a buffer containing the absolute or full path name, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Relative path name.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Maximum length of the absolute path name buffer (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). This length is in bytes for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> but in wide characters (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Requested type of memory block: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested allocation operation or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Line number in the source file where the allocation operation was requested or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Return Value  
 Each function returns a pointer to a buffer containing the absolute path name (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). If there is an error (for example, if the value passed in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> includes a drive letter that is not valid or cannot be found, or if the length of the created absolute path name (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) is greater than <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) the function returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> functions are identical to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> except that, when **_**<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>is defined, these functions use the debug version of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, to allocate memory if NULL is passed as the first parameter. For information on the debugging features of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> flag. When <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>is defined, calls to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>are remapped to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<crtdbg.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 \<xref:System.IO.File.Create*>  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)