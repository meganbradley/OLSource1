---
title: "_ASSERT, _ASSERTE, _ASSERT_EXPR Macros"
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
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ASSERTE"
  - "ASSERTE"
  - "_ASSERT"
  - "_ASSERT_EXPR"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], using macros"
  - "_ASSERTE macro"
  - "macros, debugging with"
  - "debug reporting macros"
  - "_ASSERT macro"
  - "_ASSERT_EXPR macro"
ms.assetid: e98fd2a6-7f5e-4aa8-8fe8-e93490deba36
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ASSERT, _ASSERTE, _ASSERT_EXPR Macros
Evaluate an expression and generate a debug report when the result is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A scalar expression (including pointer expressions) that evaluates to nonzero (true) or 0 (false).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A wide string to display as part of the report.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> macros provide an application with a clean and simple mechanism for checking assumptions during the debugging process. They are very flexible because they do not need to be enclosed in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statements to prevent them from being called in a retail build of an application. This flexibility is achieved by using the [_DEBUG](../vs140/_debug.md) macro. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are only available when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is defined at compile time. When <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not defined, calls to these macros are removed during preprocessing.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> evaluate their <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument and when the result is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (0), they print a diagnostic message and call [_CrtDbgReportW](../vs140/_crtdbgreport--_crtdbgreportw.md) to generate a debug report. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> macro prints a simple diagnostic message,  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> includes a string representation of the failed expression in the message, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> includes the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> string in the diagnostic message. These macros do nothing when <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> evaluates to nonzero.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> invoke <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, which causes all output to be in wide characters. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> properly prints Unicode characters in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> prints Unicode characters in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 Because the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> macro specifies the failed expression, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> lets you specify a message in the generated report, they enable users to identify the problem without referring to the application source code. However, a disadvantage exists in that every <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> printed by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and every expression evaluated by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is included in the output (debug version) file of your application as a string constant. Therefore, if a large number of calls are made to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, these expressions can greatly increase the size of your output file.  
  
 Unless you specify otherwise with the [_CrtSetReportMode](../vs140/_crtsetreportmode.md) and [_CrtSetReportFile](../vs140/_crtsetreportfile.md) functions, messages appear in a pop-up dialog box equivalent to setting:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> generates the debug report and determines its destination or destinations, based on the current report mode or modes and file defined for the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> report type. By default, assertion failures and errors are directed to a debug message window. The [_CrtSetReportMode](../vs140/_crtsetreportmode.md) and [_CrtSetReportFile](../vs140/_crtsetreportfile.md) functions are used to define the destinations for each report type.  
  
 When the destination is a debug message window and the user clicks the **Retry** button, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns 1, causing the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> macros to start the debugger provided that just-in-time (JIT) debugging is enabled.  
  
 For more information about the reporting process, see the [_CrtDbgReport, _CrtDbgReportW](../vs140/_crtdbgreport--_crtdbgreportw.md) function. For more information about resolving assertion failures and using these macros as a debugging error handling mechanism, see [Using Macros for Verification and Reporting](../vs140/macros-for-reporting.md).  
  
 In addition to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> macros, the [assert](../vs140/assert-macro--_assert--_wassert.md) macro can be used to verify program logic. This macro is available in both the debug and release versions of the libraries. The [_RPT, _RPTF](../vs140/_rpt--_rptf--_rptw--_rptfw-macros.md) debug macros are also available for generating a debug report, but they do not evaluate an expression. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> macros generate a simple report. The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> macros include the source file and line number where the report macro was called in the generated report. Wide character versions of these macros are available (<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>). The wide character versions are identical to the narrow character versions except that wide character strings are used for all string parameters and output.  
  
 Although <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> are macros and are available by including \<crtdbg.h>, the application must link with a debug version of the C run-time library when <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is defined because these macros call other run-time functions.  
  
## Requirements  
  
|Macro|Required header|  
|-----------|---------------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>,                  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
## Example  
 In this program, calls are made to the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> macros to test the condition <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. If the condition fails, these macros print a diagnostic message. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> group of macros is also exercised in this program, as an alternative to the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Use the assert macros to evaluate the expression p1 == p2.**  
**crt_ASSERT_macro.c(54) :**   
 **Will _ASSERT find 'I am p1' == 'I am p2' ?**  
**crt_ASSERT_macro.c(55) : Assertion failed!**  
**crt_ASSERT_macro.c(58) :**   
 **Will _ASSERTE find 'I am p1' == 'I am p2' ?**  
**crt_ASSERT_macro.c(59) : Assertion failed: p1 == p2**  
**'I am p1' != 'I am p2'**   
## .NET Framework Equivalent  
 [System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [assert](../vs140/assert-macro--_assert--_wassert.md)   
 [_RPT, _RPTF, _RPTW, _RPTFW Macros](../vs140/_rpt--_rptf--_rptw--_rptfw-macros.md)