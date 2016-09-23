---
title: "CResourceException Class"
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
  - CResourceException
dev_langs: 
  - C++
helpviewer_keywords: 
  - resource allocation exception
  - resources [C++], allocating
  - resource exceptions
  - exceptions, resource
  - CResourceException class
ms.assetid: af6ae043-d124-4bfd-b35e-7bb0db67d289
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CResourceException Class
Generated when Windows cannot find or allocate a requested resource.  
  
## Syntax  
  
```  
class CResourceException : public CSimpleException  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CResourceException::CResourceException](#cresourceexception__cresourceexception)|Constructs a `CResourceException` object.|  
  
## Remarks  
 No further qualification is necessary or possible.  
  
 For more information on using `CResourceException`, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 [CSimpleException](../vs140/csimpleexception-class.md)  
  
 `CResourceException`  
  
## Requirements  
 **Header:** afxwin.h  
  
##  <a name="cresourceexception__cresourceexception"></a>  CResourceException::CResourceException  
 Constructs a `CResourceException` object.  
  
```  
CResourceException( );  
  
```  
  
### Remarks  
 Do not use this constructor directly, but rather call the global function [AfxThrowResourceException](../vs140/afxthrowresourceexception.md). For more information about exceptions, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)