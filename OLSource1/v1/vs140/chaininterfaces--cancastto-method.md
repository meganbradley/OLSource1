---
title: "ChainInterfaces::CanCastTo Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "implements/Microsoft::WRL::ChainInterfaces::CanCastTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanCastTo method"
ms.assetid: 8be44875-53ed-494b-91a0-0f8e399685bb
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ChainInterfaces::CanCastTo Method
Indicates whether the specified interface ID can be cast to each of the specializations defined by the non-default template parameters.  
  
## Syntax  
  
```  
__forceinline bool CanCastTo(  
   REFIID riid,  
   _Deref_out_ void **ppv  
);  
```  
  
#### Parameters  
 `riid`  
 An interface ID.  
  
 `ppv`  
 A pointer to the last interface ID that was cast successfully.  
  
## Return Value  
 `true` if all the cast operations succeeded; otherwise, `false`.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ChainInterfaces Structure](../vs140/chaininterfaces-structure.md)