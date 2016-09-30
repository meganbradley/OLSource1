---
title: "_CrtIsValidHeapPointer"
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
  - "_CrtIsValidHeapPointer"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtlsValidHeapPointer"
  - "_CrtIsValidHeapPointer"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtIsValidHeapPointer function"
  - "CrtIsValidHeapPointer function"
ms.assetid: caf597ce-1b05-4764-9f37-0197a982bec5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtIsValidHeapPointer
Verifies that a specified pointer is in a heap allocated by some C run-time library, but not necessarily by the caller's CRT library. In versions of the CRT before Visual Studio 2010, this verifies that the specified pointer is in the local heap (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the beginning of an allocated memory block.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns TRUE if the specified pointer is in the heap shared by all CRT library instances. In versions of the CRT before Visual Studio 2010, this returns TRUE if the specified pointer is in the local heap. Otherwise, the function returns FALSE.  
  
## Remarks  
 We do not recommend that you use this function. Starting with the Visual Studio 2010 CRT library, all CRT libraries share one OS heap, the *process heap*. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function reports whether the pointer was allocated in a CRT heap, but not that it was allocated by the caller's CRT library. For example, consider a block allocated by using the Visual Studio 2010 version of the CRT library. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function exported by the Visual Studio 2012 version of the CRT library tests the pointer, it returns TRUE. This is no longer a useful test. In versions of the CRT library before Visual Studio 2010, the function is used to ensure that a specific memory address is within the local heap. The local heap refers to the heap created and managed by a particular instance of the C run-time library. If a dynamic-link library (DLL) contains a static link to the run-time library, it has its own instance of the run-time heap, and therefore its own heap, independent of the application's local heap. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 Because this function returns TRUE or FALSE, it can be passed to one of the [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) macros to create a simple debugging error handling mechanism. The following example causes an assertion failure if the specified address is not located within the local heap:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about how <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can be used with other debug functions and macros, see [Macros for Reporting](../vs140/macros-for-reporting.md). For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 The following example demonstrates how to test whether memory is valid when it is used with C run-time libraries before Visual Studio 2010. This example is provided for users of legacy CRT library code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)