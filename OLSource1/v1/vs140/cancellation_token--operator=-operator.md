---
title: "cancellation_token::operator= Operator"
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
  - "pplcancellation_token/concurrency::cancellation_token::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 2f792a7b-c6ee-47f5-b7ef-67f0c548ffa5
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token::operator= Operator
## Syntax  
  
```  
cancellation_token& operator=(  
   const cancellation_token& _Src  
);  
  
cancellation_token& operator=(  
   cancellation_token&& _Src  
);  
```  
  
#### Parameters  
 `_Src`  
  
## Return Value  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token Class](../vs140/cancellation_token-class.md)