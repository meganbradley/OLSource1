---
title: "CInternetException::CInternetException"
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
  - "CInternetException.CInternetException"
  - "CInternetException::CInternetException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetException class, constructor"
ms.assetid: 1bc9a6a8-9b64-4be4-a608-c64792145945
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetException::CInternetException
This member function is called when a `CInternetException` object is created.  
  
## Syntax  
  
```  
  
      CInternetException(  
   DWORD dwError   
);  
```  
  
#### Parameters  
 `dwError`  
 The error that caused the exception.  
  
## Remarks  
 To throw a CInternetException, call the MFC global function [AfxThrowInternetException](../vs140/afxthrowinternetexception.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetException Class](../vs140/cinternetexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException Class](../vs140/cexception-class.md)