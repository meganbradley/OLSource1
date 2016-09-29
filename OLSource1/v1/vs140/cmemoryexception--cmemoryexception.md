---
title: "CMemoryException::CMemoryException"
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
  - "CMemoryException::CMemoryException"
  - "CMemoryException.CMemoryException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemoryException class, constructor"
ms.assetid: 2adbea19-e8c5-4ad5-baf4-ad81d1d53c94
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemoryException::CMemoryException
Constructs a `CMemoryException` object.  
  
## Syntax  
  
```  
  
CMemoryException( );  
```  
  
## Remarks  
 Do not use this constructor directly, but rather call the global function [AfxThrowMemoryException](../vs140/afxthrowmemoryexception.md). This global function can succeed in an out-of-memory situation because it constructs the exception object in previously allocated memory. For more information about exception processing, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemoryException Class](../vs140/cmemoryexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Exception Processing](../vs140/exception-processing.md)