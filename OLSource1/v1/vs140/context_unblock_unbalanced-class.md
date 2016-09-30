---
title: "context_unblock_unbalanced Class"
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
  - "concrt/concurrency::context_unblock_unbalanced"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "context_unblock_unbalanced class"
ms.assetid: a76066c8-19dd-44fa-959a-6941ec1b0d2d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# context_unblock_unbalanced Class
This class describes an exception thrown when calls to the             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods of a             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object are not properly paired.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[context_unblock_unbalanced::context_unblock_unbalanced Constructor](#context_unblock_unbalanced__context_unblock_unbalanced_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Calls to the                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods of a                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object must always be properly paired. The Concurrency Runtime allows the operations to happen in either order. For example, a call to                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can be followed by a call to                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or vice-versa. This exception would be thrown if, for instance, two calls to the                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method were made in a row, on a                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object which was not blocked.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="context_unblock_unbalanced__context_unblock_unbalanced_constructor">\</a>  context_unblock_unbalanced::context_unblock_unbalanced Constructor  
 Constructs a                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Context Class](../vs140/context-class.md)   
 [Context::Unblock Method](../vs140/context-class.md#context__unblock_method)   
 [Context::Block Method](../vs140/context-class.md#context__block_method)