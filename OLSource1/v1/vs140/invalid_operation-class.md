---
title: "invalid_operation Class"
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
  - "concrt/concurrency::invalid_operation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_operation class"
ms.assetid: 26ba07dc-fcdf-44cb-b748-a31d35205b52
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_operation Class
This class describes an exception thrown when an invalid operation is performed that is not more accurately described by another exception type thrown by the Concurrency Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[invalid_operation::invalid_operation Constructor](#invalid_operation__invalid_operation_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The various methods which throw this exception will generally document under what circumstances they will throw it.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="invalid_operation__invalid_operation_constructor">\</a>  invalid_operation::invalid_operation Constructor  
 Constructs an                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)