---
title: "Exception Processing"
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
  - "vc.mfc.macros.exceptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "macros, exception handling"
  - "DAO (Data Access Objects), exceptions"
  - "OLE exceptions, MFC functions"
  - "exceptions, processing"
  - "exception macros"
  - "termination functions, MFC"
  - "MFC, exceptions"
  - "exceptions, MFC throwing functions"
ms.assetid: 26d4457c-8350-48f5-916e-78f919787c30
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Processing
When a program executes, a number of abnormal conditions and errors called "exceptions" can occur. These may include running out of memory, resource allocation errors, and failure to find files.  
  
 The Microsoft Foundation Class Library uses an exception-handling scheme that is modeled closely after the one proposed by the ANSI standards committee for C++. An exception handler must be set up before calling a function that may encounter an abnormal situation. If the function encounters an abnormal condition, it throws an exception and control is passed to the exception handler.  
  
 Several macros included with the Microsoft Foundation Class Library will set up exception handlers. A number of other global functions help to throw specialized exceptions and terminate programs, if necessary. These macros and global functions fall into the following categories:  
  
-   [Exception macros](#_mfc_exception_macros), which structure your exception handler.  
  
-   [Exception-throwing functions](#_mfc_exception.2d.throwing_functions), which generate exceptions of specific types.  
  
-   [Termination functions](#_mfc_termination_functions), which cause program termination.  
  
 For examples and more details, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
### Exception Macros  
  
|||  
|-|-|  
|[TRY](../vs140/try.md)|Designates a block of code for exception processing.|  
|[CATCH](../vs140/catch.md)|Designates a block of code for catching an exception from the preceding **TRY** block.|  
|[CATCH_ALL](../vs140/catch_all.md)|Designates a block of code for catching all exceptions from the preceding **TRY** block.|  
|[AND_CATCH](../vs140/and_catch.md)|Designates a block of code for catching additional exception types from the preceding **TRY** block.|  
|[AND_CATCH_ALL](../vs140/and_catch_all.md)|Designates a block of code for catching all other additional exception types thrown in a preceding **TRY** block.|  
|[END_CATCH](../vs140/end_catch.md)|Ends the last **CATCH** or `AND_CATCH` code block.|  
|[END_CATCH_ALL](../vs140/end_catch_all.md)|Ends the last `CATCH_ALL` code block.|  
|[THROW](../vs140/throw--mfc-.md)|Throws a specified exception.|  
|[THROW_LAST](../vs140/throw_last.md)|Throws the currently handled exception to the next outer handler.|  
  
### Exception-Throwing Functions  
  
|||  
|-|-|  
|[AfxThrowArchiveException](../vs140/afxthrowarchiveexception.md)|Throws an archive exception.|  
|[AfxThrowFileException](../vs140/afxthrowfileexception.md)|Throws a file exception.|  
|[AfxThrowMemoryException](../vs140/afxthrowmemoryexception.md)|Throws a memory exception.|  
|[AfxThrowNotSupportedException](../vs140/afxthrownotsupportedexception.md)|Throws a not-supported exception.|  
|[AfxThrowResourceException](../vs140/afxthrowresourceexception.md)|Throws a Windows resource-not-found exception.|  
|[AfxThrowUserException](../vs140/afxthrowuserexception.md)|Throws an exception in a user-initiated program action.|  
  
 MFC provides two exception-throwing functions specifically for OLE exceptions:  
  
### OLE Exception Functions  
  
|||  
|-|-|  
|[AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md)|Throws an exception within an OLE automation function.|  
|[AfxThrowOleException](../vs140/afxthrowoleexception.md)|Throws an OLE exception.|  
  
 To support database exceptions, the database classes provide two exception classes, `CDBException` and `CDaoException`, and global functions to support the exception types:  
  
### DAO Exception Functions  
  
|||  
|-|-|  
|[AfxThrowDAOException](../vs140/afxthrowdaoexception.md)|Throws a [CDaoException](../vs140/cdaoexception-class.md) from your own code.|  
|[AfxThrowDBException](../vs140/afxthrowdbexception.md)|Throws a [CDBException](../vs140/cdbexception-class.md) from your own code.|  
  
 MFC provides the following termination function:  
  
### Termination Functions  
  
|||  
|-|-|  
|[AfxAbort](../vs140/afxabort.md)|Called to terminate an application when a fatal error occurs.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CException Class](../vs140/cexception-class.md)