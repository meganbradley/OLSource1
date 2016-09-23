---
title: "CArchiveException::CArchiveException"
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
  - CArchiveException::CArchiveException
  - CArchiveException.CArchiveException
dev_langs: 
  - C++
helpviewer_keywords: 
  - CArchiveException class, constructor
ms.assetid: 0ea53a3e-9a80-4468-a989-138aaf520e05
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArchiveException::CArchiveException
Constructs a `CArchiveException` object, storing the value of `cause` in the object.  
  
## Syntax  
  
```  
  
      CArchiveException(  
   int cause = CArchiveException::none,  
   LPCTSTR lpszArchiveName = NULL  
);  
```  
  
#### Parameters  
 `cause`  
 An enumerated type variable that indicates the reason for the exception. For a list of the enumerators, see the [m_cause](../vs140/carchiveexception--m_cause.md) data member.  
  
 `lpszArchiveName`  
 Points to a string containing the name of the `CArchive` object causing the exception.  
  
## Remarks  
 You can create a `CArchiveException` object on the heap and throw it yourself or let the global function [AfxThrowArchiveException](../vs140/afxthrowarchiveexception.md) handle it for you.  
  
 Do not use this constructor directly; instead, call the global function `AfxThrowArchiveException`.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchiveException Class](../vs140/carchiveexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)