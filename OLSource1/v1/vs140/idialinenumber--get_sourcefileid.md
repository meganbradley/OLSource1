---
title: "IDiaLineNumber::get_sourceFileId"
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
  - "IDiaLineNumber::get_sourceFileId method"
ms.assetid: 4f482a1e-e85f-4173-98de-8e5f7622554b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLineNumber::get_sourceFileId
Retrieves a unique source file identifier for the source file that contributed this line.  
  
## Syntax  
  
```cpp#  
HRESULT get_sourceFileId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the unique source file identifier for the source file that contributed this line.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaLineNumber](../vs140/idialinenumber.md)