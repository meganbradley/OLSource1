---
title: "Diagnostic Services"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "diagnosis, diagnostic services"
  - "diagnostic macros, list of general MFC"
  - "services, diagnostic"
  - "MFC, diagnostic services"
  - "general diagnostic functions and variables"
  - "diagnostics, diagnostic functions and variables"
  - "diagnostics, list of general MFC"
  - "diagnosis, diagnostic functions and variables"
  - "diagnosis, list of general MFC"
  - "general diagnostic macros in MFC"
  - "diagnostic macros"
  - "diagnostic services"
  - "object diagnostic functions in MFC"
  - "diagnostics, diagnostic services"
  - "diagnostic functions and variables"
ms.assetid: 8d78454f-9fae-49c2-88c9-d3fabd5393e8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Diagnostic Services
The Microsoft Foundation Class Library supplies many diagnostic services that make debugging your programs easier. These diagnostic services include macros and global functions that allow you to track your program's memory allocations, dump the contents of objects during run time, and print debugging messages during run time. The macros and global functions for diagnostic services are grouped into the following categories:  
  
-   General diagnostic macros  
  
-   General diagnostic functions and variables  
  
-   Object diagnostic functions  
  
 These macros and functions are available for all classes derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> in the Debug and Release versions of MFC. However, all except <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and **VERIFY** do nothing in the Release version.  
  
 In the Debug library, all allocated memory blocks are bracketed with a series of "guard bytes." If these bytes are disturbed by an errant memory write, then the diagnostic routines can report a problem. If you include the line:  
  
 [!code[NVC_MFCCObjectSample#14](../vs140/codesnippet/CPP/diagnostic-services_1.cpp)]  
  
 in your implementation file, all calls to **new** will store the filename and line number where the memory allocation took place. The function [CMemoryState::DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md) will display this extra information, allowing you to identify memory leaks. Refer also to the class [CDumpContext](../vs140/cdumpcontext-class.md) for additional information on diagnostic output.  
  
 In addition, the C run-time library also supports a set of diagnostic functions you can use to debug your applications. For more information, see [Debug Routines](../vs140/debug-routines.md) in the Run-Time Library Reference.  
  
### MFC General Diagnostic Macros  
  
|||  
|-|-|  
|[ASSERT](../vs140/assert--mfc-.md)|Prints a message and then aborts the program if the specified expression evaluates to **FALSE** in the Debug version of the library.|  
|[ASSERT_KINDOF](../vs140/assert_kindof.md)|Tests that an object is an object of the specified class or of a class derived from the specified class.|  
|[ASSERT_VALID](../vs140/assert_valid.md)|Tests the internal validity of an object by calling its <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function; typically overridden from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|[DEBUG_NEW](../vs140/debug_new.md)|Supplies a filename and line number for all object allocations in Debug mode to help find memory leaks.|  
|[DEBUG_ONLY](../vs140/debug_only.md)|Similar to **ASSERT** but does not test the value of the expression; useful for code that should execute only in Debug mode.|  
|[TRACE](../vs140/trace.md)|Provides <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-like capability in the Debug version of the library.|  
|[VERIFY](../vs140/verify.md)|Similar to **ASSERT** but evaluates the expression in the Release version of the library as well as in the Debug version.|  
  
### MFC General Diagnostic Variables and Functions  
  
|||  
|-|-|  
|[afxDump](../vs140/afxdump--cdumpcontext-in-mfc-.md)|Global variable that sends [CDumpContext](../vs140/cdumpcontext-class.md) information to the debugger output window or to the debug terminal.|  
|[afxMemDF](../vs140/afxmemdf.md)|Global variable that controls the behavior of the debugging memory allocator.|  
|[AfxCheckError](../vs140/afxcheckerror.md)|Global variable used to test the passed **SCODE** to see if it is an error and, if so, throws the appropriate error.|  
|[AfxCheckMemory](../vs140/afxcheckmemory.md)|Checks the integrity of all currently allocated memory.|  
|[AfxDump](../vs140/afxdump--mfc-.md)|If called while in the debugger, dumps the state of an object while debugging.|  
|[AfxDumpStack](../vs140/afxdumpstack.md)|Generate an image of the current stack. This function is always linked statically.|  
|[AfxEnableMemoryLeakDump](../vs140/afxenablememoryleakdump.md)|Enables the memory leak dump.|  
|[AfxEnableMemoryTracking](../vs140/afxenablememorytracking.md)|Turns memory tracking on and off.|  
|[AfxIsMemoryBlock](../vs140/afxismemoryblock.md)|Verifies that a memory block has been properly allocated.|  
|[AfxIsValidAddress](../vs140/afxisvalidaddress.md)|Verifies that a memory address range is within the program's bounds.|  
|[AfxIsValidString](../vs140/afxisvalidstring.md)|Determines whether a pointer to a string is valid.|  
|[AfxSetAllocHook](../vs140/afxsetallochook.md)|Enables the calling of a function on each memory allocation.|  
  
### MFC Object Diagnostic Functions  
  
|||  
|-|-|  
|[AfxDoForAllClasses](../vs140/afxdoforallclasses.md)|Performs a specified function on all <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived classes that support run-time type checking.|  
|[AfxDoForAllObjects](../vs140/afxdoforallobjects.md)|Performs a specified function on all <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived objects that were allocated with **new**.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)