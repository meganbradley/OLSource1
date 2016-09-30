---
title: "_CrtIsMemoryBlock"
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
  - "_CrtIsMemoryBlock"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtlsMemoryBlock"
  - "_CrtIsMemoryBlock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtIsMemoryBlock function"
  - "CrtIsMemoryBlock function"
ms.assetid: f7cbbc60-3690-4da0-a07b-68fd7f250273
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtIsMemoryBlock
Verifies that a specified memory block is in the local heap and that it has a valid debug heap block type identifier (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the beginning of the memory block to verify.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the specified block (in bytes).  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the allocation number of the block or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the block or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to the line number in the source file or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the specified memory block is located within the local heap and has a valid debug heap block type identifier; otherwise, the function returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function verifies that a specified memory block is located within the application's local heap and that it has a valid block type identifier. This function can also be used to obtain the object allocation order number and the source file name/line number where the memory block allocation was originally requested. Passing non-NULL values for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameters causes <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to set these parameters to the values in the memory block's debug header, if it finds the block in the local heap. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> fails, it returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the output parameters are initialized to default values: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are set to 0 and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 Because this function returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, it can be passed to one of the [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) macros to create a simple debugging error handling mechanism. The following example causes an assertion failure if the specified address is not located within the local heap:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about how <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> can be used with other debug functions and macros, see [Macros for Reporting](../vs140/macros-for-reporting.md). For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 See the example for the [_CrtIsValidHeapPointer](../vs140/_crtisvalidheappointer.md) topic.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)