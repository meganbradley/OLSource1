---
title: "_tempnam_dbg, _wtempnam_dbg"
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
  - "_wtempnam_dbg"
  - "_tempnam_dbg"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wtempnam_dbg"
  - "tempnam_dbg"
  - "_tempnam_dbg"
  - "_wtempnam_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file names [C++], creating temporary"
  - "tempnam_dbg function"
  - "temporary files, creating"
  - "file names [C++], temporary"
  - "wtempnam_dbg function"
  - "_tempnam_dbg function"
  - "_wtempnam_dbg function"
ms.assetid: e3760bb4-bb01-4808-b689-2c45af56a170
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _tempnam_dbg, _wtempnam_dbg
Function versions of [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md) that use the debug version of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The path used in the file name if there is no TMP environment variable, or if TMP is not a valid directory.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string that will be pre-pended to names returned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Requested type of memory block: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to name of source file that requested allocation operation or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Line number in source file where allocation operation was requested or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Return Value  
 Each function returns a pointer to the name generated or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if there is a failure. Failure can occur if there is an invalid directory name specified in the TMP environment variable and in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) does need to be called for pointers allocated by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>functions are identical to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>except that, when <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>is defined, these functions use the debug version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, to allocate memory if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is passed as the first parameter. For more information, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the flag <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is defined, calls to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are remapped to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)