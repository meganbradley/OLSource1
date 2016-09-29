---
title: "cancellation_token_source::create_linked_source Method"
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
  - "pplcancellation_token/concurrency::cancellation_token_source::create_linked_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "create_linked_source method"
ms.assetid: dedec228-30b1-4bb8-b758-ccfb2fe6349a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token_source::create_linked_source Method
Creates a `cancellation_token_source` which is canceled when the provided token is canceled.  
  
## Syntax  
  
```  
static cancellation_token_source create_linked_source(  
   cancellation_token& _Src  
);  
  
template<  
   typename _Iter  
>  
static cancellation_token_source create_linked_source(  
   _Iter_Begin,  
   _Iter_End  
);  
```  
  
#### Parameters  
 `_Iter`  
 `_Src`  
 A token whose cancellation will cause cancellation of the returned token source. Note that the returned token source can also be canceled independently of the source contained in this parameter.  
  
 `_Begin`  
 The STL iterator corresponding to the beginning of the range of tokens to listen for cancellation of.  
  
 `_End`  
 The STL iterator corresponding to the ending of the range of tokens to listen for cancellation of.  
  
## Return Value  
 A `cancellation_token_source` which is canceled when the token provided by the `_Src` parameter is canceled.  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token_source Class](../VS_csharp/cancellation_token_source-class.md)