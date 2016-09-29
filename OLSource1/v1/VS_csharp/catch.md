---
title: "CATCH"
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
  - "CATCH"
  - "AFX/CATCH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try-catch exception handling, CATCH macros"
  - "try blocks"
  - "catch blocks, CATCH macros"
  - "CATCH macro"
ms.assetid: 227ebbe1-25f8-40cc-9244-e22b0a8ff570
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CATCH
Defines a block of code that catches the first exception type thrown in the preceding **TRY** block.  
  
## Syntax  
  
```  
  
CATCH(  
exception_class  
,   
exception_object_pointer_name )  
```  
  
#### Parameters  
 *exception_class*  
 Specifies the exception type to test for. For a list of standard exception classes, see class [CException](../VS_csharp/cexception-class.md).  
  
 *exception_object_pointer_name*  
 Specifies a name for an exception-object pointer that will be created by the macro. You can use the pointer name to access the exception object within the **CATCH** block. This variable is declared for you.  
  
## Remarks  
 The exception-processing code can interrogate the exception object, if appropriate, to get more information about the specific cause of the exception. Invoke the `THROW_LAST` macro to shift processing to the next outer exception frame. End the **TRY** block with an `END_CATCH` macro.  
  
 If *exception_class* is the class `CException`, then all exception types will be caught. You can use the [CObject::IsKindOf](../Topic/CObject::IsKindOf.md) member function to determine which specific exception was thrown. A better way to catch several kinds of exceptions is to use sequential `AND_CATCH` statements, each with a different exception type.  
  
 The exception object pointer is created by the macro. You do not need to declare it yourself.  
  
> [!NOTE]
>  The **CATCH** block is defined as a C++ scope delineated by braces. If you declare variables in this scope, they are accessible only within that scope. This also applies to *exception_object_pointer_name*.  
  
 For more information on exceptions and the **CATCH** macro, see the article [Exceptions](../VS_csharp/exception-handling-in-mfc.md).  
  
## Example  
 [!code[NVC_MFCExceptions#26](../VS_csharp/codesnippet/CPP/catch_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [TRY](../VS_csharp/try.md)   
 [AND_CATCH](../VS_csharp/and_catch.md)   
 [END_CATCH](../VS_csharp/end_catch.md)   
 [THROW](../VS_csharp/throw--mfc-.md)   
 [THROW_LAST](../VS_csharp/throw_last.md)   
 [CATCH_ALL](../VS_csharp/catch_all.md)   
 [CException Class](../VS_csharp/cexception-class.md)