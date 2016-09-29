---
title: "IDiaInjectedSource::get_source"
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
  - "IDiaInjectedSource::get_source method"
ms.assetid: 3c0b5386-321f-4f8f-85cc-e2ee7b4cc3d2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaInjectedSource::get_source
Retrieves the source code bytes.  
  
## Syntax  
  
```cpp#  
HRESULT get_source (   
   DWORD  cbData,  
   DWORD* pcbData,  
   BYTE   data[]  
);  
```  
  
#### Parameters  
 `cbData`  
 [in] The number of bytes that represents the size of the data buffer.  
  
 `pcbData`  
 [out] Returns the number of bytes that represents the bytes returned. If `data` is `NULL`, then `pcbData` is the total number of bytes of data available.  
  
 `data[]`  
 [out] A buffer that is to be filled in with the source bytes.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)