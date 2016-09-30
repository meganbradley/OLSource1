---
title: "CInvalidArgException Class"
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
  - "CInvalidArgException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInvalidArgException class"
ms.assetid: e43d7c67-1157-47f8-817a-804083e8186e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInvalidArgException Class
This class represents an invalid argument exception condition.  
  
## Syntax  
  
```  
class CInvalidArgException : public CSimpleException  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInvalidArgException::CInvalidArgException](#cinvalidargexception__cinvalidargexception)|The constructor.|  
  
## Remarks  
 A `CInvalidArgException` object represents an invalid argument exception condition.  
  
 For more information on Exception Handling, see the [CException Class](../vs140/cexception-class.md) topic and [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 [CSimpleException](../vs140/csimpleexception-class.md)  
  
 `CInvalidArgException`  
  
## Requirements  
 **Header:** afx.h  
  
##  <a name="cinvalidargexception__cinvalidargexception"></a>  CInvalidArgException::CInvalidArgException  
 The constructor.  
  
```  
CInvalidArgException( );  
  
```  
  
### Remarks  
 Do not use this constructor directly; call the global function **AfxThrowInvalidArgException**.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSimpleException Class](../vs140/csimpleexception-class.md)