---
title: "CFileException::ErrnoToException"
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
  - "ErrnoToException"
  - "CFileException.ErrnoToException"
  - "CFileException::ErrnoToException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ErrnoToException method"
  - "CFileException class, code conversion"
ms.assetid: 0aa0b602-2a47-4c5a-841d-8b9be744ff99
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::ErrnoToException
Converts a given run-time library error value to a `CFileException` enumerated error value.  
  
## Syntax  
  
```  
  
      static int PASCAL ErrnoToException(  
   int nErrno   
);  
```  
  
#### Parameters  
 `nErrno`  
 An integer error code as defined in the run-time include file ERRNO.H.  
  
## Return Value  
 Enumerated value that corresponds to a given run-time library error value.  
  
## Remarks  
 See [CFileException::m_cause](../vs140/cfileexception--m_cause.md) for a list of the possible enumerated values.  
  
## Example  
 [!code[NVC_MFCFiles#26](../vs140/codesnippet/CPP/cfileexception--errnotoexception_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException::OsErrorToException](../vs140/cfileexception--oserrortoexception.md)