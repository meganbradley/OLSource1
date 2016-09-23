---
title: "CFileException::OsErrorToException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFileException::OsErrorToException
  - CFileException.OsErrorToException
  - OsErrorToException
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFileException class, code conversion
  - OsErrorToException method
ms.assetid: f7358537-a61e-47ef-a967-7e21f609710f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileException::OsErrorToException
Returns an enumerator that corresponds to a given `lOsError` value. If the error code is unknown, then the function returns **CFileException::generic**.  
  
## Syntax  
  
```  
  
      static int PASCAL OsErrorToException(  
   LONG lOsError   
);  
```  
  
#### Parameters  
 `lOsError`  
 An operating-system-specific error code.  
  
## Return Value  
 Enumerated value that corresponds to a given operating-system error value.  
  
## Example  
 [!code[NVC_MFCFiles#27](../vs140/codesnippet/CPP/cfileexception--oserrortoexception_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException::ErrnoToException](../vs140/cfileexception--errnotoexception.md)