---
title: "IDiaInjectedSource::get_length"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaInjectedSource::get_length method
ms.assetid: 38b88b8b-c2e0-4b2d-8b8b-9ff373733e78
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaInjectedSource::get_length
Retrieves the number of bytes of code.  
  
## Syntax  
  
```cpp#  
HRESULT get_length (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of code.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is the length of the source code and is the same value as returned by the [IDiaInjectedSource::get_source](../vs140/idiainjectedsource--get_source.md) method.  
  
## See Also  
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)   
 [IDiaInjectedSource::get_source](../vs140/idiainjectedsource--get_source.md)