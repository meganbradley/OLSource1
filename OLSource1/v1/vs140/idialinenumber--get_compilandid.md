---
title: "IDiaLineNumber::get_compilandId"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLineNumber::get_compilandId method"
ms.assetid: 2cd6f551-8091-47c7-803f-3f79a766a211
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLineNumber::get_compilandId
Retrieves a unique identifier for the compiland that contributed this line.  
  
## Syntax  
  
```cpp#  
HRESULT get_compilandId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `DWORD` that contains the unique identifier for the compiland that contributed this line.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaLineNumber](../vs140/idialinenumber.md)