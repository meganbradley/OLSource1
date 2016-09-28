---
title: "Exceptions: OLE Exceptions"
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
  - "OLE, exceptions"
  - "OLE exceptions"
  - "exceptions, OLE"
  - "exception handling, OLE"
  - "OLE exceptions, classes for handling"
ms.assetid: 2f8e0161-b94f-48bb-a5a2-6f644b192527
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: OLE Exceptions
The techniques and facilities for handling exceptions in OLE are the same as those for handling other exceptions. For further information on exception handling, see the article [C++ Exception Handling](../vs140/c---exception-handling.md).  
  
 All exception objects are derived from the abstract base class `CException`. MFC provides two classes for handling OLE exceptions:  
  
-   [COleException](../vs140/coleexception-class.md) For handling general OLE exceptions.  
  
-   [COleDispatchException](../vs140/coledispatchexception-class.md) For generating and handling OLE dispatch (automation) exceptions.  
  
 The difference between these two classes is the amount of information they provide and where they are used. `COleException` has a public data member that contains the OLE status code for the exception. `COleDispatchException` supplies more information, including the following:  
  
-   An application-specific error code  
  
-   An error description, such as "Disk full"  
  
-   A Help context that your application can use to provide additional information for the user  
  
-   The name of your application's Help file  
  
-   The name of the application that generated the exception  
  
 `COleDispatchException` provides more information so that it can be used with products like Microsoft Visual Basic. The verbal error description can be used in a message box or other notification; the Help information can be used to help the user respond to the conditions that caused the exception.  
  
 Two global functions correspond to the two OLE exception classes: [AfxThrowOleException](../vs140/afxthrowoleexception.md) and [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md). Use them to throw general OLE exceptions and OLE dispatch exceptions, respectively.  
  
## See Also  
 [Exception Handling](../vs140/exception-handling-in-mfc.md)