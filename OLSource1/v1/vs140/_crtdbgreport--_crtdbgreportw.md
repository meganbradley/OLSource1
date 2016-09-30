---
title: "_CrtDbgReport, _CrtDbgReportW"
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
  - "_CrtDbgReport"
  - "_CrtDbgReportW"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtDbgReport"
  - "CrtDbgReportW"
  - "_CrtDbgReportW"
  - "_CrtDbgReport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debug reporting"
  - "_CrtDbgReport function"
  - "CrtDbgReport function"
  - "CrtDbgReportW function"
  - "_CrtDbgReportW function"
ms.assetid: 6e581fb6-f7fb-4716-9432-f0145d639ecc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtDbgReport, _CrtDbgReportW
Generates a report with a debugging message and sends the report to three possible destinations (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Report type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to name of source file where assert/report occurred or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Line number in source file where assert/report occurred or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to name of module (.exe or .dll) where assert or report occurred.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Pointer to format-control string used to create the user message.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Optional substitution arguments used by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 For all report destinations, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return –1 if an error occurs and 0 if no errors are encountered. However, when the report destination is a debug message window and the user clicks the **Retry** button, these functions return 1. If the user clicks the **Abort** button in the Debug Message window, these functions immediately abort and do not return a value.  
  
 The [_RPT, _RPTF](../vs140/_rpt--_rptf--_rptw--_rptfw-macros.md) debug macros call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to generate their debug reports. The wide-character versions of these macros as well as [_ASSERT&#91;E&#93;](../vs140/_assert--_asserte--_assert_expr-macros.md), <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to generate their debug reports. When <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> return 1, these macros start the debugger, provided that just-in-time (JIT) debugging is enabled.  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can send the debug report to three different destinations: a debug report file, a debug monitor (the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugger), or a debug message window. Two configuration functions, [_CrtSetReportMode](../vs140/_crtsetreportmode.md) and [_CrtSetReportFile](../vs140/_crtsetreportfile.md), are used to specify the destination or destinations for each report type. These functions allow the reporting destination or destinations for each report type to be separately controlled. For example, it is possible to specify that a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> only be sent to the debug monitor, while a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> be sent to a debug message window and a user-defined report file.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. All its output and string parameters are in wide-character strings; otherwise it is identical to the single-byte character version.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> create the user message for the debug report by substituting the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>] arguments into the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> string, using the same rules defined by the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> functions. These functions then generate the debug report and determine the destination or destinations, based on the current report modes and file defined for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. When the report is sent to a debug message window, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are included in the information displayed in the window.  
  
 The following table lists the available choices for the report mode or modes and file and the resulting behavior of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. These options are defined as bit flags in \<crtdbg.h>.  
  
|Report mode|Report file|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> behavior|  
|-----------------|-----------------|------------------------------------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Not applicable|Writes message by using Windows [OutputDebugString](http://msdn.microsoft.com/library/windows/desktop/aa363362.aspx) API.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Not applicable|Calls Windows [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) API to create message box to display the message along with **Abort**, **Retry**, and **Ignore** buttons. If a user clicks **Abort**, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> immediately aborts. If a user clicks **Retry**, it returns 1. If a user clicks **Ignore**, execution continues and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> return 0. Note that clicking **Ignore** when an error condition exists often results in "undefined behavior."|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Writes message to user-supplied <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, using the Windows [WriteFile](http://msdn.microsoft.com/library/windows/desktop/aa365747.aspx) API and does not verify validity of file handle; the application is responsible for opening the report file and passing a valid file handle.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Writes message to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Writes message to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.|  
  
 The report can be sent to one, two, or three destinations or to no destination at all. For more information about specifying the report mode or modes and report file, see the [_CrtSetReportMode](../vs140/_crtsetreportmode.md) and [_CrtSetReportFile](../vs140/_crtsetreportfile.md) functions. For more information about using the debug macros and reporting functions, see [Macros for Reporting](../vs140/macros-for-reporting.md).  
  
 If your application needs more flexibility than that provided by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, you can write your own reporting function and hook it into the C run-time library reporting mechanism by using the [_CrtSetReportHook](../vs140/_crtsetreporthook.md) function.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<crtdbg.h>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> are Microsoft extensions. For more information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 See [crt_dbg2](assetId:///21e1346a-6a17-4f57-b275-c76813089167) for an example of how to change the report function.  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Debug::Write](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.write.aspx)  
  
-   [System::Diagnostics::Debug::Writeline](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writeline.aspx)  
  
-   [System::Diagnostics::Debug::WriteIf](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writeif.aspx)  
  
-   [System::Diagnostics::Debug::WriteLineIf](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.writelineif.aspx)  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtSetReportMode](../vs140/_crtsetreportmode.md)   
 [_CrtSetReportFile](../vs140/_crtsetreportfile.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [_DEBUG](../vs140/_debug.md)