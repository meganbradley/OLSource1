---
title: "ATLTRACE2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL.atlTraceDBClient"
  - "ATL::atlTraceGeneral"
  - "ATL::atlTraceDBProvider"
  - "ATL.ATL_TRACE_LEVEL"
  - "ATL.atlTraceHosting"
  - "ATL.atlTraceRegistrar"
  - "atlTraceRefcount"
  - "atlTraceQI"
  - "atlTraceSnapin"
  - "atlTraceWindowing"
  - "atlTraceControls"
  - "atlTraceGeneral"
  - "ATL_TRACE_LEVEL"
  - "ATL.atlTraceSnapin"
  - "ATL.ATLTRACE2"
  - "ATL.atlTraceControls"
  - "ATL.CTraceCategory"
  - "ATL::atlTraceSnapin"
  - "atlTraceHosting"
  - "ATL::atlTraceHosting"
  - "ATL::ATLTRACE2"
  - "ATL::CTraceCategory"
  - "ATL.atlTraceGeneral"
  - "ATL.atlTraceCOM"
  - "ATL.atlTraceQI"
  - "ATL::atlTraceRegistrar"
  - "CTraceCategory"
  - "atlTraceRegistrar"
  - "atlTraceDBClient"
  - "ATL::atlTraceCOM"
  - "ATL.atlTraceUser"
  - "ATL::atlTraceWindowing"
  - "atlTraceCOM"
  - "ATL.atlTraceDBProvider"
  - "ATLTRACE2"
  - "ATL::ATL_TRACE_LEVEL"
  - "ATL::atlTraceUser"
  - "ATL.atlTraceWindowing"
  - "ATL_TRACE_CATEGORY"
  - "ATL::ATL_TRACE_CATEGORY"
  - "atlTraceUser"
  - "atlTraceDBProvider"
  - "ATL::atlTraceDBClient"
  - "ATL.atlTraceRefcount"
  - "ATL::atlTraceQI"
  - "ATL.ATL_TRACE_CATEGORY"
  - "ATL::atlTraceControls"
  - "ATL::atlTraceRefcount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTraceCategory class"
  - "atlTraceDBClient function"
  - "atlTraceWindowing function"
  - "atlTraceCOM function"
  - "atlTraceRefcount function"
  - "ATL_TRACE_CATEGORY macro"
  - "atlTraceNotImpl function"
  - "atlTraceControls function"
  - "ATL_TRACE_LEVEL macro"
  - "tracing, ATL flags and warnings"
  - "debug messages"
  - "atlTraceDBProvider function"
  - "atlTraceRegistrar function"
  - "atlTraceSnapin function"
  - "atlTraceUser function"
  - "ATL, debugging"
  - "atlTraceQI function"
  - "debugging [ATL], trace macros"
  - "ATLTRACE2 macro"
  - "atlTraceGeneral function"
  - "atlTraceHosting function"
ms.assetid: 467ff555-e7a5-4f94-bdd9-50ee27ab9986
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLTRACE2
Reports warnings to an output device, such as the debugger window, according to the indicated flags and levels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The string to send to the Visual C++ output window or any application that traps these messages.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Type of event or method on which to report. See the Remarks for a list of categories.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The level of tracing to report. See the Remarks for details.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-style format string to use to create a string to send to the dump device.  
  
## Remarks  
 The short form of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> writes a string to the debugger's output window. The second form of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> also writes output to the debugger's output window, but is subject to the settings of the ATL/MFC Trace Tool (see [ATLTraceTool Sample](../vs140/visual-c---samples.md)). For example, if you set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to 4 and the ATL/MFC Trace Tool to level 0, you will not see the message. *level* can be 0, 1, 2, 3, or 4. The default, 0, reports only the most serious problems.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter lists the trace flags to set. These flags correspond to the types of methods for which you want to report. The tables below list the valid trace flags you can use for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
### ATL Trace Flags  
  
|ATL Category|Description|  
|------------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Reports on all ATL applications. The default.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Reports on COM methods.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Reports on QueryInterface calls.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Reports on the registration of objects.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Reports on changing reference count.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Reports on windows methods; for example, reports an invalid message map ID.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Reports on controls; for example, reports when a control or its window is destroyed.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Reports hosting messages; for example, reports when a client in a container is activated.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Reports on OLE DB Consumer Template; for example, when a call to GetData fails, the output can contain the HRESULT.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Reports on OLE DB Provider Template; for example, reports if the creation of a column failed.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Reports for MMC SnapIn application.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Reports that the indicated function is not implemented.|  
|**atlTraceAllocation**|Reports messages printed by the memory debugging tools in atldbgmem.h.|  
  
### MFC Trace Flags  
  
|MFC Category|Description|  
|------------------|-----------------|  
|**traceAppMsg**|General purpose, MFC messages. Always recommended.|  
|**traceDumpContext**|Messages from [CDumpContext](../vs140/cdumpcontext-class.md).|  
|**traceWinMsg**|Messages from MFC's message handling code.|  
|**traceMemory**|Messages from MFC's memory management code.|  
|**traceCmdRouting**|Messages from MFC's Windows command routing code.|  
|**traceHtml**|Messages from MFC's DHTML dialog support.|  
|**traceSocket**|Messages from MFC's socket support.|  
|**traceOle**|Messages from MFC's OLE support.|  
|**traceDatabase**|Messages from MFC's database support.|  
|**traceInternet**|Messages from MFC's Internet support.|  
  
 To declare a custom trace category, declare a global instance of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class as follows:  
  
 [!code[NVC_ATL_Utilities#109](../vs140/codesnippet/CPP/atltrace2_1.cpp)]  
  
 The category name, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in this example, is the name you specify to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter. The first parameter is the category name that will appear in the ATL/MFC Trace Tool. The second parameter is the default trace level. This parameter is optional, and the default trace level is 0.  
  
 To use a user-defined category:  
  
 [!code[NVC_ATL_Utilities#110](../vs140/codesnippet/CPP/atltrace2_2.cpp)]  
  
 To specify that you want to filter the trace messages, insert definitions for these macros into Stdafx.h before the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement.  
  
 Alternatively, you can set the filter in the preprocessor directives in the **Property Pages** dialog box. Click the **Preprocessor** tab and then insert the global into the **Preprocessor Definitions** edit box.  
  
 Atlbase.h contains default definitions of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> macros and these definitions will be used if you don't define these symbols before atlbase.h is processed.  
  
 In release builds, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> compiles to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> limits the contents of the string to be sent to the dump device to no more than 1023 characters, after formatting.  
  
 **ATLTRACE** and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> have the same behavior, **ATLTRACE** is included for backward compatibility.  
  
## Example  
 [!code[NVC_ATL_Utilities#111](../vs140/codesnippet/CPP/atltrace2_3.cpp)]  
  
## Requirements  
 **Header:** atltrace.h  
  
## See Also  
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)   
 [ATLTRACE](../vs140/atltrace--atl-.md)