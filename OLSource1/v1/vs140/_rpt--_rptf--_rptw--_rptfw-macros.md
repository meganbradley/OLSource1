---
title: "_RPT, _RPTF, _RPTW, _RPTFW Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "RPT3"
  - "RPTF4"
  - "_RPT4"
  - "RPT1"
  - "_RPTF0"
  - "RPTF3"
  - "_RPTF4"
  - "RPTF1"
  - "RPT4"
  - "_RPT1"
  - "_RPT0"
  - "RPT0"
  - "_RPTF2"
  - "RPTF0"
  - "_RPT3"
  - "_RPT2"
  - "_RPTF3"
  - "RPT2"
  - "_RPTF1"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], using macros"
  - "_RPTW3 macro"
  - "_RPT0 macro"
  - "RPTW4 macro"
  - "_RPTF3 macro"
  - "_RPTW4 macro"
  - "RPTF4 macro"
  - "RPTFW2 macro"
  - "RPTW macros"
  - "RPT1 macro"
  - "_RPTF macros"
  - "RPTFW3 macro"
  - "_RPTW0 macro"
  - "_RPTF0 macro"
  - "macros, debugging with"
  - "_RPTW2 macro"
  - "RPTF3 macro"
  - "RPT3 macro"
  - "RPT0 macro"
  - "_RPT macros"
  - "RPTW3 macro"
  - "_RPTFW macros"
  - "debug reporting macros"
  - "RPTF macros"
  - "RPT macros"
  - "_RPTW macros"
  - "RPTF2 macro"
  - "_RPTF1 macro"
  - "_RPT1 macro"
  - "_RPT4 macro"
  - "_RPTFW2 macro"
  - "_RPTFW1 macro"
  - "RPTF0 macro"
  - "_RPT2 macro"
  - "RPTFW macros"
  - "_RPTW1 macro"
  - "_RPTFW0 macro"
  - "RPT4 macro"
  - "_RPT3 macro"
  - "_RPTFW3 macro"
  - "_RPTF4 macro"
  - "_RPTFW4 macro"
  - "_RPTF2 macro"
  - "RPTW0 macro"
  - "RPTFW4 macro"
  - "RPTFW0 macro"
  - "RPTW2 macro"
  - "RPTF1 macro"
  - "RPT2 macro"
  - "RPTFW1 macro"
  - "RPTW1 macro"
ms.assetid: a5bf8b30-57f7-4971-8030-e773b7a1ae13
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _RPT, _RPTF, _RPTW, _RPTFW Macros
Tracks an application's progress by generating a debug report (debug version only). Note that *n* specifies the number of arguments in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and can be 0, 1, 2, 3, 4, or 5.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Report type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Format-control string used to create the user message.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Substitution arguments used by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 All these macros take the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>parameters. In addition, they might also take up to four additional arguments, signified by the number appended to the macro name. For example, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> take no additional arguments, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> take <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> take <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and so on.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> macros are similar to the [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) function, because they can be used to track an application's progress during the debugging process. However, these macros are more flexible than <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> because they do not need to be enclosed in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statements to prevent them from being called in a retail build of an application. This flexibility is achieved by using the [_DEBUG](../vs140/_debug.md) macro; the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> macros are only available when the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> flag is defined. When <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is not defined, calls to these macros are removed during preprocessing.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> macros are wide-character versions of these macros. They are like <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and take wide-character strings as arguments.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> macros call the [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md) function to generate a debug report with a user message. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> macros call the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function to generate the same report with wide characters. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> macros create a debug report with the source file and line number where the report macro was called, in addition to the user message. The user message is created by substituting the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>[*n*] arguments into the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> string, using the same rules defined by the [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) function.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> generates the debug report and determines its destinations based on the current report modes and file defined for <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. The [_CrtSetReportMode](../vs140/_crtsetreportmode.md) and [_CrtSetReportFile](../vs140/_crtsetreportfile.md) functions are used to define the destinations for each report type.  
  
 If an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> macro is called and neither <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> has been called, messages are displayed as follows.  
  
|Report type|Output destination|  
|-----------------|------------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Warning text is not displayed.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|A pop-up window. Same as if <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> had been specified.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
  
 When the destination is a debug message window and the user chooses the **Retry** button, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns 1, causing these macros to start the debugger, provided that just-in-time (JIT) debugging is enabled. For more information about using these macros as a debugging error handling mechanism, see [Using Macros for Verification and Reporting](../vs140/macros-for-reporting.md).  
  
 Two other macros exist that generate a debug report. The [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) macro generates a report, but only when its expression argument evaluates to FALSE. [_ASSERTE](../vs140/_assert--_asserte--_assert_expr-macros.md) is exactly like <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, but includes the failed expression in the generated report.  
  
## Requirements  
  
|Macro|Required header|  
|-----------|---------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder> macros|\<crtdbg.h>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> macros|\<crtdbg.h>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> macros|\<crtdbg.h>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> macros|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
 Although these are macros and are obtained by including Crtdbg.h, the application must link with one of the debug libraries because these macros call other run-time functions.  
  
## Example  
 See the example in the [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) topic.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)