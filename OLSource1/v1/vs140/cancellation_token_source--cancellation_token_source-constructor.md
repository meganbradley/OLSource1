---
title: "cancellation_token_source::cancellation_token_source Constructor"
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
  - "pplcancellation_token/concurrency::cancellation_token_source::cancellation_token_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancellation_token_source, constructor"
ms.assetid: 162af3fb-0796-4e11-b51c-1a7bc291347d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token_source::cancellation_token_source Constructor
Constructs a new `cancellation_token_source`. The source can be used to flag cancellation of some cancelable operation.  
  
## Syntax  
  
```  
cancellation_token_source();  
  
cancellation_token_source(  
   const cancellation_token_source& _Src  
);  
  
cancellation_token_source(  
   cancellation_token_source&& _Src  
);  
```  
  
#### Parameters  
 `_Src`  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token_source Class](../vs140/cancellation_token_source-class.md)