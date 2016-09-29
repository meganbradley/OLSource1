---
title: "CUserException Class"
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
  - "CUserException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operations [C++], stopping"
  - "exceptions, throwing"
  - "CUserException class"
  - "errors [C++], trapping"
  - "operations [C++]"
  - "throwing exceptions, stopping user operations"
ms.assetid: 2156ba6d-2cce-415a-9000-6f02c26fcd7d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserException Class
Thrown to stop an end-user operation.  
  
## Syntax  
  
```  
class CUserException : public CSimpleException  
```  
  
## Remarks  
 Use `CUserException` when you want to use the throw/catch exception mechanism for application-specific exceptions. "User" in the class name can be interpreted as "my user did something exceptional that I need to handle."  
  
 A `CUserException` is usually thrown after calling the global function `AfxMessageBox` to notify the user that an operation has failed. When you write an exception handler, handle the exception specially since the user usually has already been notified of the failure. The framework throws this exception in some cases. To throw a `CUserException` yourself, alert the user and then call the global function `AfxThrowUserException`.  
  
 In the example below, a function containing operations that may fail alerts the user and throws a `CUserException`. The calling function catches the exception and handles it specially:  
  
 [!code[NVC_MFCExceptions#24](../vs140/codesnippet/CPP/cuserexception-class_1.cpp)]  
  
 For more information on using `CUserException`, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 [CSimpleException](../vs140/csimpleexception-class.md)  
  
 `CUserException`  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException](../vs140/cexception-class.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)   
 [AfxThrowUserException](../vs140/afxthrowuserexception.md)   
 [How Do I: Create my Own Custom Exception Classes?](http://go.microsoft.com/fwlink/?LinkId=128045)