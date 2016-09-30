---
title: "Language Specific Handler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 6503e0cd-2d3a-4330-a925-8bed8c27c2be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Language Specific Handler
The relative address of the language specific handler is present in the UNWIND_INFO whenever flags UNW_FLAG_EHANDLER or UNW_FLAG_UHANDLER are set. As described in the previous section, the language specific handler is called as part of the search for an exception handler or as part of an unwind. It has the following prototype:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **ExceptionRecord** supplies a pointer to an exception record, which has the standard Win64 definition.  
  
 **EstablisherFrame** is the address of the base of the fixed stack allocation for this function.  
  
 **ContextRecord** points to the exception context at the time the exception was raised (in the exception handler case) or the current "unwind" context (in the termination handler case).  
  
 **DispatcherContext** points to the dispatcher context for this function. It has the following definition:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **ControlPc** is the value of RIP within this function. This is either an exception address or the address at which control left the establishing function. This is the RIP that will be used to determine if control is within some guarded construct within this function (for example, a __try block for \__try/\__except or \__try/\__finally).  
  
 **ImageBase** is the image base (load address) of the module containing this function, to be added to the 32-bit offsets used in the function entry and unwind info to record relative addresses.  
  
 **FunctionEntry** supplies a pointer to the RUNTIME_FUNCTION function entry holding the function and unwind info image-base relative addresses for this function.  
  
 **EstablisherFrame** is the address of the base of the fixed stack allocation for this function.  
  
 **TargetIp** Supplies an optional instruction address that specifies the continuation address of the unwind. This address is ignored if **EstablisherFrame** is not specified.  
  
 **ContextRecord** points to the exception context, for use by the system exception dispatch/unwind code.  
  
 **LanguageHandler** points to the language-specific language handler routine being called.  
  
 **HandlerData** points to the language-specific handler data for this function.  
  
## See Also  
 [Exception Handling (x64)](../vs140/exception-handling--x64-.md)