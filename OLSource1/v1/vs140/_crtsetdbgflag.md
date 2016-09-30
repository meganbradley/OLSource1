---
title: "_CrtSetDbgFlag"
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
  - "_CrtSetDbgFlag"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CRTDBG_REPORT_FLAG"
  - "_CRTDBG_CHECK_EVERY_16_DF"
  - "_CRTDBG_CHECK_DEFAULT_DF"
  - "CRTDBG_CHECK_DEFAULT_DF"
  - "CRTDBG_CHECK_EVERY_128_DF"
  - "CRTDBG_CHECK_EVERY_1024_DF"
  - "_CRTDBG_CHECK_EVERY_128_DF"
  - "CrtSetDbgFlag"
  - "CRTDBG_CHECK_EVERY_16_DF"
  - "_CRTDBG_CHECK_EVERY_1024_DF"
  - "_CrtSetDbgFlag"
  - "CRTDBG_REPORT_FLAG"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CRTDBG_CHECK_EVERY_16_DF macro"
  - "CRTDBG_CHECK_EVERY_16_DF macro"
  - "_CRTDBG_CHECK_ALWAYS_DF macro"
  - "_CRTDBG_CHECK_DEFAULT_DF macro"
  - "CRTDBG_ALLOC_MEM_DF macro"
  - "CRTDBG_CHECK_ALWAYS_DF macro"
  - "_CRTDBG_ALLOC_MEM_DF macro"
  - "_CRTDBG_REPORT_FLAG macro"
  - "_CRTDBG_CHECK_EVERY_128_DF macro"
  - "CRTDBG_REPORT_FLAG macro"
  - "_CRTDBG_CHECK_EVERY_1024_DF macro"
  - "CRTDBG_CHECK_DEFAULT_DF macro"
  - "CRTDBG_CHECK_EVERY_1024_DF macro"
  - "_CrtSetDbgFlag function"
  - "CrtSetDbgFlag function"
  - "_CRTDBG_DELAY_FREE_MEM_DF macro"
  - "CRTDBG_CHECK_EVERY_128_DF macro"
  - "CRTDBG_DELAY_FREE_MEM_DF macro"
  - "CRTDBG_CHECK_CRT_DF macro"
  - "_CRTDBG_CHECK_CRT_DF macro"
ms.assetid: b5657ffb-6178-4cbf-9886-1af904ede94c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetDbgFlag
Retrieves or modifies the state of the **_crtDbgFlag** flag to control the allocation behavior of the debug heap manager (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New state for **_crtDbgFlag**.  
  
## Return Value  
 Returns the previous state of **_crtDbgFlag**.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function allows the application to control how the debug heap manager tracks memory allocations by modifying the bit fields of the **_crtDbgFlag** flag. By setting the bits (turning on), the application can instruct the debug heap manager to perform special debugging operations, including checking for memory leaks when the application exits and reporting if any are found, simulating low-memory conditions by specifying that freed memory blocks should remain in the heap's linked list, and verifying the integrity of the heap by inspecting each memory block at every allocation request. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 The following table lists the bit fields for **_crtDbgFlag** and describes their behavior. Because setting the bits results in increased diagnostic output and reduced program execution speed, these bits are not set (turned off) by default. For more information about these bit fields, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions).  
  
|Bit field|Default|Description|  
|---------------|-------------|-----------------|  
|**_CRTDBG_ALLOC_MEM_DF**|ON|ON: Enable debug heap allocations and use of memory block type identifiers, such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. OFF: Add new allocations to heap's linked list, but set block type to **_IGNORE_BLOCK**.\<br />\<br /> Can also be combined with any of the heap-frequency check macros.|  
|**_CRTDBG_CHECK_ALWAYS_DF**|OFF|ON: Call [_CrtCheckMemory](../vs140/_crtcheckmemory.md) at every allocation and deallocation request. OFF: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be called explicitly.\<br />\<br /> Heap-frequency check macros have no effect when this flag is set.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|OFF|ON: Include <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> types in leak detection and memory state difference operations. OFF: Memory used internally by the run-time library is ignored by these operations.\<br />\<br /> Can also be combined with any of the heap-frequency check macros.|  
|**_CRTDBG_DELAY_FREE_MEM_DF**|OFF|ON: Keep freed memory blocks in the heap's linked list, assign them the **_FREE_BLOCK** type, and fill them with the byte value 0xDD. OFF: Do not keep freed blocks in the heap's linked list.\<br />\<br /> Can also be combined with any of the heap-frequency check macros.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|OFF|ON: Perform automatic leak checking at program exit through a call to [_CrtDumpMemoryLeaks](../vs140/_crtdumpmemoryleaks.md) and generate an error report if the application failed to free all the memory it allocated. OFF: Do not automatically perform leak checking at program exit.\<br />\<br /> Can also be combined with any of the heap-frequency check macros.|  
  
 **Heap-Check Frequency Macros**  
  
 You can specify how often the C run-time library performs validation of the debug heap (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) based on the number of calls to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, **free**, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> then inspects the upper 16 bits of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter for a value. The value specified is the number of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, **free**, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> calls between <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> calls. Four predefined macros are provided for this purpose.  
  
|Macro|Number of malloc, realloc, free, and _msize calls between calls to _CrtCheckMemory|  
|-----------|------------------------------------------------------------------------------------------|  
|_CRTDBG_CHECK_EVERY_16_DF|16|  
|_CRTDBG_CHECK_EVERY_128_DF|128|  
|_CRTDBG_CHECK_EVERY_1024_DF|1024|  
|_CRTDBG_CHECK_DEFAULT_DF|0 (by default, no heap checks)|  
  
 By default, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is called once every 1,024 times you call <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, **free**, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 For example, you could specify a heap check every 16 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, **free**, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> operations with the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The upper 16 bits of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter are ignored when _CRTDBG_CHECK_ALWAYS_DF is specified. In this case, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is called each time you call <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, **free**, and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is the new state to apply to the **_crtDbgFlag** and is a combination of the values for each of the bit fields.  
  
### To change one or more of these bit fields and create a new state for the flag  
  
1.  Call <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> equal to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to obtain the current **_crtDbgFlag** state and store the returned value in a temporary variable.  
  
2.  Turn on any bits by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>-ing the temporary variable with the corresponding bitmasks (represented in the application code by manifest constants).  
  
3.  Turn off the other bits by **AND**-ing the variable with a bitwise **NOT** of the appropriate bitmasks.  
  
4.  Call <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> equal to the value stored in the temporary variable to set the new state for **_crtDbgFlag**.  
  
 The following code demonstrates how to simulate low-memory conditions by keeping freed memory blocks in the heap's linked list and prevent <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> from being called at every allocation request:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For an overview of memory management and the debug heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
 To disable a flag with the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function, you should **AND** the variable with the bitwise **NOT** of the bitmask.  
  
 If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is not a valid value, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and returns the previous state of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_crtDbgFlag](../vs140/_crtdbgflag.md)   
 [_CrtCheckMemory](../vs140/_crtcheckmemory.md)