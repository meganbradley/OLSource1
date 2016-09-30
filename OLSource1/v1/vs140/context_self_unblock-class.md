---
title: "context_self_unblock Class"
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
  - "concrt/concurrency::context_self_unblock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "context_self_unblock class"
ms.assetid: 9601cd28-4f40-4c2e-89ab-747068956331
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# context_self_unblock Class
This class describes an exception thrown when the             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method of a             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is called from the same context. This would indicate an attempt by a given context to unblock itself.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[context_self_unblock::context_self_unblock Constructor](#context_self_unblock__context_self_unblock_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="context_self_unblock__context_self_unblock_constructor">\</a>  context_self_unblock::context_self_unblock Constructor  
 Constructs a                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Context Class](../vs140/context-class.md)   
 [Context::Unblock Method](../vs140/context-class.md#context__unblock_method)