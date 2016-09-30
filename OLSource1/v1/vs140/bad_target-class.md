---
title: "bad_target Class"
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
  - "concrt/concurrency::bad_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bad_target class"
ms.assetid: e6dcddbf-9217-4fac-ac7f-7b8b4781d2f5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bad_target Class
This class describes an exception thrown when a messaging block is given a pointer to a target which is invalid for the operation being performed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[bad_target::bad_target Constructor](#bad_target__bad_target_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This exception is typically thrown for reasons such as a target attempting to consume a message which is reserved for a different target or releasing a reservation that it does not hold.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="bad_target__bad_target_constructor">\</a>  bad_target::bad_target Constructor  
 Constructs a                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)