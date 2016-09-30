---
title: "_set_se_translator"
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
  - "_set_se_translator"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_set_se_translator"
  - "set_se_translator"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "set_se_translator function"
  - "exception handling, changing"
  - "_set_se_translator function"
ms.assetid: 280842bc-d72a-468b-a565-2d3db893ae0f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_se_translator
Handles Win32 exceptions (C structured exceptions) as C++ typed exceptions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a C structured exception translator function that you write.  
  
## Return Value  
 Returns a pointer to the previous translator function registered by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, so that the previous function can be restored later. If no previous function has been set, the return value can be used to restore the default behavior; this value can be NULL.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function provides a way to handle Win32 exceptions (C structured exceptions) as C++ typed exceptions. To allow each C exception to be handled by a C++ <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> handler, first define a C exception wrapper class that can be used, or derived from, to attribute a specific class type to a C exception. To use this class, install a custom C exception translator function that is called by the internal exception-handling mechanism each time a C exception is raised. Within your translator function, you can throw any typed exception that can be caught by a matching C++ <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> handler.  
  
 You must use [/EHa](../vs140/-eh--exception-handling-model-.md) when using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 To specify a custom translation function, call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with the name of your translation function as its argument. The translator function that you write is called once for each function invocation on the stack that has <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> blocks. There is no default translator function.  
  
 Your translator function should do no more than throw a C++ typed exception. If it does anything in addition to throwing (such as writing to a log file, for example) your program might not behave as expected, because the number of times the translator function is invoked is platform-dependent.  
  
 In a multithreaded environment, translator functions are maintained separately for each thread. Each new thread needs to install its own translator function. Thus, each thread is in charge of its own translation handling. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is specific to one thread; another DLL can install a different translation function.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function that you write must be a native-compiled function (not compiled with /clr). It must take an unsigned integer and a pointer to a Win32 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure as arguments. The arguments are the return values of calls to the Win32 API <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions, respectively.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, there are implications when dynamically linking to the CRT; another DLL in the process might call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and replace your handler with its own.  
  
 When using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> from managed code (code compiled with /clr) or mixed native and managed code, be aware that the translator affects exceptions generated in native code only. Any managed exceptions generated in managed code (such as when raising <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) are not routed through the translator function. Exceptions raised in managed code using the Win32 function <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or caused by a system exception like a divide by zero exception are routed through the translator.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<eh.h>|  
  
 The functionality provided by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not available in code compiled with the [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md) compiler option.  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **In trans_func.**  
**In finally**  
**Caught a __try exception with SE_Exception.**   
## Example  
 Although the functionality provided by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not available in managed code, it is possible to use this mapping in native code, even if that native code is in a compilation under the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> switch, as long as the native code is indicated using <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If a structured exception is being thrown in managed code that is to be mapped, the code that generates and handles the exception must be marked with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The following code shows a possible use. For more information, see [Pragma Directives](../vs140/pragma-directives-and-the-__pragma-keyword.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Translating the structured exception to a C++ exception.**  
**Caught CMyException.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Exception Handling Routines](../vs140/exception-handling-routines.md)   
 [set_terminate](../vs140/set_terminate--crt-.md)   
 [set_unexpected](../vs140/set_unexpected--crt-.md)   
 [terminate](../vs140/terminate--crt-.md)   
 [unexpected](../vs140/unexpected--crt-.md)