---
title: "_configthreadlocale"
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
  - "_configthreadlocale"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_configthreadlocale"
  - "configthreadlocale"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "configthreadlocale function"
  - "locales, per-thread"
  - "_configthreadlocale function"
  - "per-thread locale"
  - "thread locale"
ms.assetid: 10e4050e-b587-4f30-80bc-6c76b35fc770
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _configthreadlocale
Configures per-thread locale options.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The option to set. One of the options listed in the following table.  
  
## Return Value  
 The previous per-thread locale status (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), or -1 on failure.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is used to control the use of thread-specific locales. Use one of these options to specify or determine the per-thread locale status:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Make the current thread use a thread-specific locale. Subsequent calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in this thread affect only the thread's own locale.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Make the current thread use the global locale. Subsequent calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in this thread affect other threads using the global locale.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Retrieves the current setting for this particular thread.  
  
 These functions affect the behavior of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If another method is used to create threads, the locale settings have no effect on those threads.  
  
 When per-thread locale is disabled, any subsequent call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> changes the locale of all threads. When per-thread locale is enabled, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> only affects the current thread's locale.  
  
 If you use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to enable a per-thread locale, we recommend that you call <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to set the preferred locale in that thread immediately afterward.  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not one of the values listed in the table, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<locale.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The thread locale is now set to English_United States.1252.**  
**The time in English locale is: 'Wednesday, May 12, 2004'**  
**The thread locale is now set to German_Germany.1252.**  
**The time in German locale is: 'Mittwoch, 12. Mai 2004'**   
## .NET Framework Equivalent  
 Not applicable. However, see [Using the CurrentCulture Property](assetId:///3156042d-6082-4205-90b4-c917ae6a3ba6).  
  
## See Also  
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_beginthread, _beginthreadex](../vs140/_beginthread--_beginthreadex.md)   
 [Locale](../vs140/locale.md)   
 [Multithreading and Locales](../vs140/multithreading-and-locales.md)