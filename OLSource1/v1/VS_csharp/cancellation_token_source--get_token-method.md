---
title: "cancellation_token_source::get_token Method"
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
  - "pplcancellation_token/concurrency::cancellation_token_source::get_token"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_token method"
ms.assetid: b532dbe1-50a9-4431-bf59-ce97fdcc7b6f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token_source::get_token Method
Returns a cancellation token associated with this source. The returned token can be polled for cancellation or provide a callback if and when cancellation occurs.  
  
## Syntax  
  
```  
cancellation_token get_token() const;  
```  
  
## Return Value  
 A cancellation token associated with this source.  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token_source Class](../VS_csharp/cancellation_token_source-class.md)