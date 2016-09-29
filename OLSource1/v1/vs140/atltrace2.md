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
  
```  
  
      ATLTRACE2(   
      exp   
      );  
ATLTRACE2(  
   DWORD category,  
   UINT level,  
   LPCSTR lpszFormat,  
   ...  
);  
```  
  
#### Parameters  
 `exp`  
 [in] The string to send to the Visual C++ output window or any application that traps these messages.  
  
 `category`  
 [in] Type of event or method on which to report. See the Remarks for a list of categories.  
  
 `level`  
 [in] The level of tracing to report. See the Remarks for details.  
  
 `lpszFormat`  
 [in] The `printf`-style format string to use to create a string to send to the dump device.  
  
## Remarks  
 The short form of `ATLTRACE2` writes a string to the debugger's output window. The second form of `ATLTRACE2` also writes output to the debugger's output window, but is subject to the settings of the ATL/MFC Trace Tool (see [ATLTraceTool Sample](../vs140/visual-c---samples.md)). For example, if you set `level` to 4 and the ATL/MFC Trace Tool to level 0, you will not see the message. *level* can be 0, 1, 2, 3, or 4. The default, 0, reports only the most serious problems.  
  
 The `category` parameter lists the trace flags to set. These flags correspond to the types of methods for which you want to report. The tables below list the valid trace flags you can use for the `category` parameter.  
  
### ATL Trace Flags  
  
|ATL Category|Description|  
|------------------|-----------------|  
|`atlTraceGeneral`|Reports on all ATL applications. The default.|  
|`atlTraceCOM`|Reports on COM methods.|  
|`atlTraceQI`|Reports on QueryInterface calls.|  
|`atlTraceRegistrar`|Reports on the registration of objects.|  
|`atlTraceRefcount`|Reports on changing reference count.|  
|`atlTraceWindowing`|Reports on windows methods; for example, reports an invalid message map ID.|  
|`atlTraceControls`|Reports on controls; for example, reports when a control or its window is destroyed.|  
|`atlTraceHosting`|Reports hosting messages; for example, reports when a client in a container is activated.|  
|`atlTraceDBClient`|Reports on OLE DB Consumer Template; for example, when a call to GetData fails, the output can contain the HRESULT.|  
|`atlTraceDBProvider`|Reports on OLE DB Provider Template; for example, reports if the creation of a column failed.|  
|`atlTraceSnapin`|Reports for MMC SnapIn application.|  
|`atlTraceNotImpl`|Reports that the indicated function is not implemented.|  
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
  
 To declare a custom trace category, declare a global instance of the `CTraceCategory` class as follows:  
  
 [!code[NVC_ATL_Utilities#109](../vs140/codesnippet/CPP/atltrace2_1.cpp)]  
  
 The category name, `MY_CATEGORY` in this example, is the name you specify to the `category` parameter. The first parameter is the category name that will appear in the ATL/MFC Trace Tool. The second parameter is the default trace level. This parameter is optional, and the default trace level is 0.  
  
 To use a user-defined category:  
  
 [!code[NVC_ATL_Utilities#110](../vs140/codesnippet/CPP/atltrace2_2.cpp)]  
  
 To specify that you want to filter the trace messages, insert definitions for these macros into Stdafx.h before the `#include <atlbase.h>` statement.  
  
 Alternatively, you can set the filter in the preprocessor directives in the **Property Pages** dialog box. Click the **Preprocessor** tab and then insert the global into the **Preprocessor Definitions** edit box.  
  
 Atlbase.h contains default definitions of the `ATLTRACE2` macros and these definitions will be used if you don't define these symbols before atlbase.h is processed.  
  
 In release builds, `ATLTRACE2` compiles to `(void) 0`.  
  
 `ATLTRACE2` limits the contents of the string to be sent to the dump device to no more than 1023 characters, after formatting.  
  
 **ATLTRACE** and `ATLTRACE2` have the same behavior, **ATLTRACE** is included for backward compatibility.  
  
## Example  
 [!code[NVC_ATL_Utilities#111](../vs140/codesnippet/CPP/atltrace2_3.cpp)]  
  
## Requirements  
 **Header:** atltrace.h  
  
## See Also  
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)   
 [ATLTRACE](../vs140/atltrace--atl-.md)