---
title: "Exceptions: Catching and Deleting Exceptions"
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
helpviewer_keywords: 
  - "exceptions, deleting"
  - "AND_CATCH macro"
  - "try-catch exception handling, catching and deleting exceptions"
  - "exception handling, catching and deleting exceptions"
  - "catch blocks, catching and deleting exceptions"
  - "execution, returns from within catch block"
ms.assetid: 7c233ff0-89de-4de0-a68a-9e9cdb164311
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: Catching and Deleting Exceptions
The following instructions and examples show you how to catch and delete exceptions. For more information on the **try**, **catch**, and <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keywords, see [C++ Exception Handling](../vs140/c---exception-handling.md).  
  
 Your exception handlers must delete exception objects they handle, because failure to delete the exception causes a memory leak whenever that code catches an exception.  
  
 Your **catch** block must delete an exception when:  
  
-   The **catch** block throws a new exception.  
  
     Of course, you must not delete the exception if you throw the same exception again:  
  
     [!code[NVC_MFCExceptions#3](../vs140/codesnippet/CPP/exceptions--catching-and-deleting-exceptions_1.cpp)]  
  
-   Execution returns from within the **catch** block.  
  
> [!NOTE]
>  When deleting a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, use the **Delete** member function to delete the exception. Do not use the **delete** keyword, because it can fail if the exception is not on the heap.  
  
#### To catch and delete exceptions  
  
1.  Use the **try** keyword to set up a **try** block. Execute any program statements that might throw an exception within a **try** block.  
  
     Use the **catch** keyword to set up a **catch** block. Place exception-handling code in a **catch** block. The code in the **catch** block is executed only if the code within the **try** block throws an exception of the type specified in the **catch** statement.  
  
     The following skeleton shows how **try** and **catch** blocks are normally arranged:  
  
     [!code[NVC_MFCExceptions#4](../vs140/codesnippet/CPP/exceptions--catching-and-deleting-exceptions_2.cpp)]  
  
     When an exception is thrown, control passes to the first **catch** block whose exception-declaration matches the type of the exception. You can selectively handle different types of exceptions with sequential **catch** blocks as listed below:  
  
     [!code[NVC_MFCExceptions#5](../vs140/codesnippet/CPP/exceptions--catching-and-deleting-exceptions_3.cpp)]  
  
 For more information, see [Exceptions: Converting from MFC Exception Macros](../vs140/exceptions--converting-from-mfc-exception-macros.md).  
  
## See Also  
 [Exception Handling](../vs140/exception-handling-in-mfc.md)