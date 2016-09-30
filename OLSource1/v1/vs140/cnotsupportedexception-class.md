---
title: "CNotSupportedException Class"
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
  - "CNotSupportedException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CNotSupportedException class"
  - "unsupported features"
  - "exceptions, not supported"
ms.assetid: e517391b-eb94-4c39-ae32-87b45bf7d624
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNotSupportedException Class
Represents an exception that is the result of a request for an unsupported feature.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CNotSupportedException::CNotSupportedException](#cnotsupportedexception__cnotsupportedexception)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 No further qualification is necessary or possible.  
  
 For more information on using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 [CSimpleException](../vs140/csimpleexception-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cnotsupportedexception__cnotsupportedexception">\</a>  CNotSupportedException::CNotSupportedException  
 Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Do not use this constructor directly, but rather call the global function [AfxThrowNotSupportedException](../vs140/afxthrownotsupportedexception.md). For more information about exception processing, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)