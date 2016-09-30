---
title: "improper_lock Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrt/concurrency::improper_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "improper_lock class"
ms.assetid: 8f494942-7748-4a2a-8de2-23414bfe6346
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# improper_lock Class
This class describes an exception thrown when a lock is acquired improperly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[improper_lock::improper_lock Constructor](#improper_lock__improper_lock_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
  
## Remarks  
 Typically, this exception is thrown when an attempt is made to acquire a non-reentrant lock recursively on the same context.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="improper_lock__improper_lock_constructor">\</a>  improper_lock::improper_lock Constructor  
 Constructs an                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [critical_section Class](../vs140/critical_section-class.md)   
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)