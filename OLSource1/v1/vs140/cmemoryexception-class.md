---
title: "CMemoryException Class"
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
  - "CMemoryException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemoryException class"
  - "memory exceptions"
  - "exceptions, memory type"
  - "C++ exception handling, memory"
  - "memory, exception handling"
ms.assetid: 9af0ed57-d12a-45ca-82b5-c910a60f7edf
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemoryException Class
Represents an out-of-memory exception condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMemoryException::CMemoryException](#cmemoryexception__cmemoryexception)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 No further qualification is necessary or possible. Memory exceptions are thrown automatically by **new**. If you write your own memory functions, using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, for example, then you are responsible for throwing memory exceptions.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 [CSimpleException](../vs140/csimpleexception-class.md)  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cmemoryexception__cmemoryexception">\</a>  CMemoryException::CMemoryException  
 Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Do not use this constructor directly, but rather call the global function [AfxThrowMemoryException](../vs140/afxthrowmemoryexception.md). This global function can succeed in an out-of-memory situation because it constructs the exception object in previously allocated memory. For more information about exception processing, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)