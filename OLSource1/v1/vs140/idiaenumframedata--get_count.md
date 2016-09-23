---
title: "IDiaEnumFrameData::get_Count"
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
  - IDiaEnumFrameData::get_Count method
ms.assetid: 94374d27-e335-4e90-a442-233181ab8e58
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaEnumFrameData::get_Count
Retrieves the number of frame data elements.  
  
## Syntax  
  
```cpp#  
HRESULT get_Count (   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns the number of frame data elements.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../vs140/idiaenumframedata.md)   
 [IDiaEnumFrameData::Item](../vs140/idiaenumframedata--item.md)