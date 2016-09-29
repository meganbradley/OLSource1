---
title: "IDiaImageData::get_imageBase"
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
  - "IDiaImageData::get_imageBase method"
ms.assetid: 4ba3d9e4-b205-4ee6-a41d-6996972f1f85
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaImageData::get_imageBase
Retrieves the memory location where the image should be based.  
  
## Syntax  
  
```cpp#  
HRESULT get_imageBase (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the suggested image base value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Due to image base conflicts, an image may be rebased automatically to an unused memory location when it is loaded. This method returns the base hint (suggested memory location) that was stored in the module at compile time.  
  
## See Also  
 [IDiaImageData](../vs140/idiaimagedata.md)