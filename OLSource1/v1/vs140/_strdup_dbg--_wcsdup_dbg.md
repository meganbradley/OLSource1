---
title: "_strdup_dbg, _wcsdup_dbg"
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
  - "_strdup_dbg"
  - "_wcsdup_dbg"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wcsdup_dbg"
  - "strdup_dbg"
  - "_strdup_dbg"
  - "wcsdup_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcsdup_dbg function"
  - "stdup_dbg function"
  - "copying strings"
  - "duplicating strings"
  - "strings [C++], copying"
  - "strings [C++], duplicating"
  - "_strdup_dbg function"
  - "wcsdup_dbg function"
ms.assetid: 681db70c-d124-43ab-b83e-5eeea9035097
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strdup_dbg, _wcsdup_dbg
Versions of [_strdup and _wcsdup](../vs140/_strdup--_wcsdup--_mbsdup.md) that use the debug version of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated source string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Requested type of memory block: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to name of source file that requested allocation operation or NULL.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Line number in source file where allocation operation was requested or NULL.  
  
## Return Value  
 Each of these functions returns a pointer to the storage location for the copied string or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if storage cannot be allocated.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> functions are identical to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> except that, when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is defined, these functions use the debug version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, to allocate memory for the duplicated string. For information on the debugging features of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the flag <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is defined, calls to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are remapped to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, respectively, with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For more information on block types, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All debug versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 [System::String::Clone](https://msdn.microsoft.com/en-us/library/system.string.clone.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_strdup, _wcsdup, _mbsdup](../vs140/_strdup--_wcsdup--_mbsdup.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)