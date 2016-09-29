---
title: "Debug Routines"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.debug"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], using macros"
  - "macros, debugging with"
  - "debug routines"
  - "debug macros"
  - "debugging [CRT], run-time routines"
ms.assetid: cb4d2664-10f3-42f7-a516-595558075471
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debug Routines
The debug version of the C run-time library supplies many diagnostic services that make debugging programs easier and allow developers to:  
  
-   Step directly into run-time functions during debugging  
  
-   Resolve assertions, errors, and exceptions  
  
-   Trace heap allocations and prevent memory leaks  
  
-   Report debug messages to the user  
  
 To use these routines, the [_DEBUG](../VS_csharp/_debug.md) flag must be defined. All of these routines do nothing in a retail build of an application. For more information on how to use the new debug routines, see [CRT Debugging Techniques](../VS_csharp/crt-debugging-techniques.md).  
  
### Debug Versions of the C Run-Time Library Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_ASSERT](../VS_csharp/_assert--_asserte--_assert_expr-macros.md)|Evaluate an expression and generates a debug report when the result is FALSE|[System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)|  
|[_ASSERTE](../VS_csharp/_assert--_asserte--_assert_expr-macros.md)|Similar to `_ASSERT`, but includes the failed expression in the generated report|[System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)|  
|[_CrtCheckMemory](../VS_csharp/_crtcheckmemory.md)|Confirm the integrity of the memory blocks allocated on the debug heap|[System::Diagnostics::PerformanceCounter](https://msdn.microsoft.com/en-us/library/system.diagnostics.performancecounter.aspx)|  
|[_CrtDbgBreak](../VS_csharp/_crtdbgbreak.md)|Sets a break point.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtDbgReport, _CrtDbgReportW](../VS_csharp/_crtdbgreport--_crtdbgreportw.md)|Generate a debug report with a user message and send the report to three possible destinations|[System::Diagnostics::Debug::Write](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.write.aspx), [System::Diagnostics::Debug::Writeline](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writeline.aspx), [System::Diagnostics::Debug::WriteIf](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writeif.aspx), [System::Diagnostics::Debug::WriteLineIf](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writelineif.aspx)|  
|[_CrtDoForAllClientObjects](../VS_csharp/_crtdoforallclientobjects.md)|Call an application-supplied function for all `_CLIENT_BLOCK` types on the heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtDumpMemoryLeaks](../VS_csharp/_crtdumpmemoryleaks.md)|Dump all of the memory blocks on the debug heap when a significant memory leak has occurred|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtIsMemoryBlock](../VS_csharp/_crtismemoryblock.md)|Verify that a specified memory block is located within the local heap and that it has a valid debug heap block type identifier|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtIsValidHeapPointer](../VS_csharp/_crtisvalidheappointer.md)|Verifies that a specified pointer is in the local heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtIsValidPointer](../VS_csharp/_crtisvalidpointer.md)|Verify that a specified memory range is valid for reading and writing|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtMemCheckpoint](../VS_csharp/_crtmemcheckpoint.md)|Obtain the current state of the debug heap and store it in an application-supplied `_CrtMemState` structure|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtMemDifference](../VS_csharp/_crtmemdifference.md)|Compare two memory states for significant differences and return the results|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtMemDumpAllObjectsSince](../VS_csharp/_crtmemdumpallobjectssince.md)|Dump information about objects on the heap since a specified checkpoint was taken or from the start of program execution|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtMemDumpStatistics](../VS_csharp/_crtmemdumpstatistics.md)|Dump the debug header information for a specified memory state in a user-readable form|[System::Diagnostics::PerformanceCounter](https://msdn.microsoft.com/en-us/library/system.diagnostics.performancecounter.aspx)|  
|[_CrtReportBlockType](../VS_csharp/_crtreportblocktype.md)|Returns the block type/subtype associated with a given debug heap block pointer.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetAllocHook](../VS_csharp/_crtsetallochook.md)|Install a client-defined allocation function by hooking it into the C run-time debug memory allocation process|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetBreakAlloc](../VS_csharp/_crtsetbreakalloc.md)|Set a breakpoint on a specified object allocation order number|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetDbgFlag](../VS_csharp/_crtsetdbgflag.md)|Retrieve or modify the state of the `_crtDbgFlag` flag to control the allocation behavior of the debug heap manager|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetDumpClient](../VS_csharp/_crtsetdumpclient.md)|Install an application-defined function that is called every time a debug dump function is called to dump `_CLIENT_BLOCK` type memory blocks|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetReportFile](../VS_csharp/_crtsetreportfile.md)|Identify the file or stream to be used as a destination for a specific report type by `_CrtDbgReport`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetReportHook](../VS_csharp/_crtsetreporthook.md)|Install a client-defined reporting function by hooking it into the C run-time debug reporting process|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetReportHook2, _CrtSetReportHookW2](../VS_csharp/_crtsetreporthook2--_crtsetreporthookw2.md)|Installs or uninstalls a client-defined reporting function by hooking it into the C run-time debug reporting process.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_CrtSetReportMode](../VS_csharp/_crtsetreportmode.md)|Specify the general destination(s) for a specific report type generated by `_CrtDbgReport`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_RPT&#91;0,1,2,3,4&#93;](../VS_csharp/_rpt--_rptf--_rptw--_rptfw-macros.md)|Track the application's progress by generating a debug report by calling `_CrtDbgReport` with a format string and a variable number of arguments. Provides no source file and line number information.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_RPTF&#91;0,1,2,3,4&#93;](../VS_csharp/_rpt--_rptf--_rptw--_rptfw-macros.md)|Similar to the `_RPTn` macros, but provides the source file name and line number where the report request originated|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_calloc_dbg](../VS_csharp/_calloc_dbg.md)|Allocate a specified number of memory blocks on the heap with additional space for a debugging header and overwrite buffers|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_expand_dbg](../VS_csharp/_expand_dbg.md)|Resize a specified block of memory on the heap by expanding or contracting the block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_free_dbg](../VS_csharp/_free_dbg.md)|Free a block of memory on the heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_fullpath_dbg, _wfullpath_dbg](../VS_csharp/_fullpath_dbg--_wfullpath_dbg.md)|Create an absolute or full path name for the specified relative path name, using [_malloc_dbg](../VS_csharp/_malloc_dbg.md) to allocate memory.|[System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)|  
|[_getcwd_dbg, _wgetcwd_dbg](../VS_csharp/_getcwd_dbg--_wgetcwd_dbg.md)|Get the current working directory, using [_malloc_dbg](../VS_csharp/_malloc_dbg.md) to allocate memory.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_malloc_dbg](../VS_csharp/_malloc_dbg.md)|Allocate a block of memory on the heap with additional space for a debugging header and overwrite buffers|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_msize_dbg](../VS_csharp/_msize_dbg.md)|Calculate the size of a block of memory on the heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_realloc_dbg](../VS_csharp/_realloc_dbg.md)|Reallocate a specified block of memory on the heap by moving and/or resizing the block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_strdup_dbg, _wcsdup_dbg](../VS_csharp/_strdup_dbg--_wcsdup_dbg.md)|Duplicates a string, using [_malloc_dbg](../VS_csharp/_malloc_dbg.md) to allocate memory.|[System::String::Clone](https://msdn.microsoft.com/en-us/library/system.string.clone.aspx)|  
|[_tempnam_dbg, _wtempnam_dbg](../VS_csharp/_tempnam_dbg--_wtempnam_dbg.md)|Generate names you can use to create temporary files, using [_malloc_dbg](../VS_csharp/_malloc_dbg.md) to allocate memory.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
 The debug routines can be used to step through the source code for most of the other C run-time routines during the debugging process. However, Microsoft considers some technology to be proprietary and, therefore, does not provide the source code for these routines. Most of these routines belong to either the exception handling or floating-point processing groups, but a few others are included as well. The following table lists these routines.  
  
### C Run-Time Routines That Are Not Available in Source Code Form  
  
||||  
|-|-|-|  
|[acos, acosf](../VS_csharp/acos--acosf--acosl.md)|[_fpclass](../VS_csharp/_fpclass--_fpclassf.md)|[_nextafter](../VS_csharp/nextafter--nextafterf--nextafterl--_nextafter--_nextafterf--nexttoward--nexttowardf--nexttowardl.md)|  
|[asin](../VS_csharp/asin--asinf--asinl.md)|[_fpieee_flt](../VS_csharp/_fpieee_flt.md)|[pow](../VS_csharp/pow--powf--powl.md)|  
|[atan, atan2](../VS_csharp/atan--atanf--atanl--atan2--atan2f--atan2l.md)|[_fpreset](../VS_csharp/_fpreset.md)|[printf, wprintf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md), [printf_s, wprintf_s](../VS_csharp/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)*|  
|[_cabs](../VS_csharp/_cabs.md)|[frexp](../VS_csharp/frexp.md)|[_scalb](../VS_csharp/_scalb.md)|  
|[ceil](../VS_csharp/ceil--ceilf--ceill.md)|[_hypot](../VS_csharp/hypot--hypotf--hypotl--_hypot--_hypotf--_hypotl.md)|[scanf, wscanf](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md), [scanf_s, wscanf_s](../VS_csharp/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)*|  
|[_chgsign, _chgsignl](../VS_csharp/_chgsign--_chgsignf--_chgsignl.md)|[_isnan](../VS_csharp/isnan--_isnan--_isnanf.md)|[setjmp](../VS_csharp/setjmp.md)|  
|[_clear87, _clearfp](../VS_csharp/_clear87--_clearfp.md)|[_j0](../Topic/Bessel%20Functions:%20_j0,%20_j1,%20_jn.md)|[sin](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)|  
|[_control87, _controlfp, \__control87_2](../VS_csharp/_control87--_controlfp--__control87_2.md)|[_j1](../Topic/Bessel%20Functions:%20_j0,%20_j1,%20_jn.md)|[sinh](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)|  
|[_copysign, _copysignl](../VS_csharp/copysign--copysignf--copysignl--_copysign--_copysignf--_copysignl.md)|[_jn](../Topic/Bessel%20Functions:%20_j0,%20_j1,%20_jn.md)|[sqrt](../VS_csharp/sqrt--sqrtf--sqrtl.md)|  
|[cos](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)|[ldexp](../VS_csharp/ldexp.md)|[_status87, _statusfp](../VS_csharp/_status87--_statusfp--_statusfp2.md)|  
|[cosh](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)|[log](../VS_csharp/log--logf--log10--log10f.md)|[tan](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[Exp](../VS_csharp/exp--expf.md)|[log10](../VS_csharp/log--logf--log10--log10f.md)|[tanh](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[fabs](../VS_csharp/fabs--fabsf--fabsl.md)|[_logb](../VS_csharp/logb--logbf--logbl--_logb--_logbf.md)|[_y0](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn_deleted.md)|  
|[_finite](../VS_csharp/_finite--_finitef.md)|[longjmp](../VS_csharp/longjmp.md)|[_y1](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn_deleted.md)|  
|[floor](../VS_csharp/floor--floorf--floorl.md)|[_matherr](../VS_csharp/_matherr.md)|[_yn](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn_deleted.md)|  
|[fmod](../VS_csharp/fmod--fmodf.md)|[modf](../VS_csharp/modf--modff--modfl.md)||  
  
 \*   Although source code is available for most of this routine, it makes an internal call to another routine for which source code is not provided.  
  
 Some C run-time functions and C++ operators behave differently when called from a debug build of an application. (Note that a debug build of an application can be done by either defining the `_DEBUG` flag or by linking with a debug version of the C run-time library.) The behavioral differences usually consist of extra features or information provided by the routine to support the debugging process. The following table lists these routines.  
  
### Routines that Behave Differently in a Debug Build of an Application  
  
|||  
|-|-|  
|C [abort](../VS_csharp/abort.md) routine|C++ [delete](../VS_csharp/delete-operator--c---.md) operator|  
|C [assert](../VS_csharp/assert-macro--_assert--_wassert.md) routine|C++ [new](../VS_csharp/new-operator--c---.md) operator|  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)   
 [Run-Time Error Checking](../VS_csharp/run-time-error-checking.md)