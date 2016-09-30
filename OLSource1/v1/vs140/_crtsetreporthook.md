---
title: "_CrtSetReportHook"
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
  - "_CrtSetReportHook"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtSetReportHook"
  - "CrtSetReportHook"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtSetReportHook function"
  - "_CrtSetReportHook function"
ms.assetid: 1ae7c64f-8c84-4797-9574-b59f00f7a509
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetReportHook
Installs a client-defined reporting function by hooking it into the C run-time debug reporting process (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New client-defined reporting function to hook into the C run-time debug reporting process.  
  
## Return Value  
 Returns the previous client-defined reporting function.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> allows an application to use its own reporting function into the C run-time debug library reporting process. As a result, whenever [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md) is called to generate a debug report, the application's reporting function is called first. This functionality enables an application to perform operations such as filtering debug reports so it can focus on specific allocation types or send a report to destinations not available by using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 For a more robust version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, see [_CrtSetReportHook2](../vs140/_crtsetreporthook2--_crtsetreporthookw2.md).  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function installs the new client-defined reporting function specified in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and returns the previous client-defined hook. The following example demonstrates how a client-defined report hook should be prototyped:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the debug report type (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the fully assembled debug user message to be contained in the report, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the value specified by the client-defined reporting function that should be returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For a complete description of the available report types, see the [_CrtSetReportMode](../vs140/_crtsetreportmode.md) function.  
  
 If the client-defined reporting function completely handles the debug message such that no further reporting is required, then the function should return <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. When the function returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is called to generate the debug report using the current settings for the report type, mode, and file. In addition, by specifying the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> return value in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the application can also control whether a debug break occurs. For a complete description of how the debug report is configured and generated, see <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, [_CrtSetReportFile](../vs140/_crtsetreportfile.md), and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 For more information about using other hook-capable run-time functions and writing your own client-defined hook functions, see [Debug Hook Function Writing](../vs140/debug-hook-function-writing.md).  
  
> [!NOTE]
>  If your application is compiled with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and the reporting function is called after the application has exited main, the CLR will throw an exception if the reporting function calls any CRT functions.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtGetReportHook](../vs140/_crtgetreporthook.md)