---
title: "_CrtIsValidPointer"
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
  - "_CrtIsValidPointer"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtlsValidPointer"
  - "_CrtIsValidPointer"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtIsValidPointer function"
  - "_CrtIsValidPointer function"
ms.assetid: 91c35590-ea5e-450f-a15d-ad8d62ade1fa
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtIsValidPointer
Verifies that a pointer is not null. In versions of the C run-time library before Visual Studio 2010, verifies that a specified memory range is valid for reading and writing (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 address  
 Points to the beginning of the memory range to test for validity.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Size of the specified memory range (in bytes).  
  
 access  
 Read/write accessibility to determine for the memory range.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns TRUE if the specified pointer is not null. In CRT library versions before Visual Studio 2010, returns TRUE if the memory range is valid for the specified operation or operations. Otherwise, the function returns FALSE.  
  
## Remarks  
 Starting with the CRT library in Visual Studio 2010, the size and access parameters are ignored, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> only verifies that the specified address is not null. Because this test is easy to perform yourself, we do not recommend you use this function. In versions before Visual Studio 2010, the function verifies that the memory range beginning at <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and extending for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bytes is valid for the specified accessibility operation or operations. When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to TRUE, the memory range is verified for both reading and writing. When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is FALSE, the memory range is only validated for reading. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 Because this function returns TRUE or FALSE, it can be passed to one of the [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) macros to create a simple debugging error handling mechanism. The following example causes an assertion failure if the memory range is not valid for both reading and writing operations:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about how <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be used with other debug functions and macros, see [Macros for Reporting](../vs140/macros-for-reporting.md). For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a Microsoft extension. For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 See the example for the [_CrtIsValidHeapPointer](../vs140/_crtisvalidheappointer.md) topic.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)