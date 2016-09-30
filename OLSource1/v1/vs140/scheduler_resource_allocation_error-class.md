---
title: "scheduler_resource_allocation_error Class"
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
  - "concrt/concurrency::scheduler_resource_allocation_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scheduler_resource_allocation_error class"
ms.assetid: 8b40449a-7abb-4d0a-bb85-c0e9a495ae97
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scheduler_resource_allocation_error Class
This class describes an exception thrown because of a failure to acquire a critical resource in the Concurrency Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[scheduler_resource_allocation_error::scheduler_resource_allocation_error Constructor](#scheduler_resource_allocation_error__scheduler_resource_allocation_error_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[scheduler_resource_allocation_error::get_error_code Method](#scheduler_resource_allocation_error__get_error_code_method)|Returns the error code that caused the exception.|  
  
## Remarks  
 This exception is typically thrown when a call to the operating system from within the Concurrency Runtime fails. The error code which would normally be returned from a call to the Win32 method                 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is converted to a value of type                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and can be retrieved using the                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="scheduler_resource_allocation_error__get_error_code_method">\</a>  scheduler_resource_allocation_error::get_error_code Method  
 Returns the error code that caused the exception.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value of the error that caused the exception.  
  
##  \<a name="scheduler_resource_allocation_error__scheduler_resource_allocation_error_constructor">\</a>  scheduler_resource_allocation_error::scheduler_resource_allocation_error Constructor  
 Constructs a                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value of the error that caused the exception.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)