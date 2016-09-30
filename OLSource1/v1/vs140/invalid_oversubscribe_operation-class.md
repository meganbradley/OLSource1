---
title: "invalid_oversubscribe_operation Class"
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
  - "concrt/concurrency::invalid_oversubscribe_operation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_oversubscribe_operation class"
ms.assetid: 0a9c5f08-d5e6-4ad0-90a9-517472b3ac28
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_oversubscribe_operation Class
This class describes an exception thrown when the             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method is called with the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter set to             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> without a prior call to the             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method with the             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter set to             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[invalid_oversubscribe_operation::invalid_oversubscribe_operation Constructor](#invalid_oversubscribe_operation__invalid_oversubscribe_operation_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="invalid_oversubscribe_operation__invalid_oversubscribe_operation_constructor">\</a>  invalid_oversubscribe_operation::invalid_oversubscribe_operation Constructor  
 Constructs an                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Context::Oversubscribe Method](../vs140/context-class.md#context__oversubscribe_method)