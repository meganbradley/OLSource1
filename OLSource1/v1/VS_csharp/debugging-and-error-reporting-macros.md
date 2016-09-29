---
title: "Debugging and Error Reporting Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "macros, error reporting"
ms.assetid: 4da9b87f-ec5c-4a32-ab93-637780909b9d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging and Error Reporting Macros
These macros provide useful debugging and trace facilities.  
  
|||  
|-|-|  
|[_ATL_DEBUG_INTERFACES](../VS_csharp/_atl_debug_interfaces.md)|Writes, to the output window, any interface leaks that are detected when `_Module.Term` is called.|  
|[_ATL_DEBUG_QI](../VS_csharp/_atl_debug_qi.md)|Writes all calls to `QueryInterface` to the output window.|  
|[ATLASSERT](../VS_csharp/atlassert.md)|Performs the same functionality as the [_ASSERTE](../VS_csharp/_assert--_asserte--_assert_expr-macros.md) macro found in the C run-time library.|  
|[ATLENSURE](../VS_csharp/atlensure.md)|Performs parameters validation. Call `AtlThrow` if needed|  
|[ATLTRACENOTIMPL](../VS_csharp/atltracenotimpl.md)|Sends a message to the dump device that the specified function is not implemented.|  
|[ATLTRACE](../VS_csharp/atltrace--atl-.md)|Reports warnings to an output device, such as the debugger window, according to the indicated flags and levels. Included for backward compatibility.|  
|[ATLTRACE2](../VS_csharp/atltrace2.md)|Reports warnings to an output device, such as the debugger window, according to the indicated flags and levels.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)   
 [Debugging and Error Reporting Global Functions](../VS_csharp/debugging-and-error-reporting-global-functions.md)