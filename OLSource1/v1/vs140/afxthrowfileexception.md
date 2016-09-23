---
title: "AfxThrowFileException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFX/AfxThrowFileException
  - AfxThrowFileException
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxThrowFileException function
  - exception-throwing functions
ms.assetid: 714be79a-81ce-43fe-8d19-d07186e95d02
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxThrowFileException
Throws a file exception.  
  
## Syntax  
  
```  
  
      void AfxThrowFileException(  
   int cause,  
   LONG lOsError = -1,  
   LPCTSTR lpszFileName = NULL   
);   
```  
  
#### Parameters  
 `cause`  
 Specifies an integer that indicates the reason for the exception. For a list of the possible values, see [CFileException::m_cause](../vs140/cfileexception--m_cause.md).  
  
 `lOsError`  
 Contains the operating-system error number (if available) that states the reason for the exception. See your operating-system manual for a listing of error codes.  
  
 `lpszFileName`  
 Points to a string containing the name of the file that caused the exception (if available).  
  
## Remarks  
 You are responsible for determining the cause based on the operating-system error code.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CFileException::ThrowOsError](../vs140/cfileexception--throwoserror.md)   
 [THROW](../vs140/throw--mfc-.md)