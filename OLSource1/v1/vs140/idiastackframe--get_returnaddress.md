---
title: "IDiaStackFrame::get_returnAddress"
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
  - "IDiaStackFrame::get_returnAddress method"
ms.assetid: 0df91981-919f-48ed-9c70-4121567d645b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_returnAddress
Retrieves the return address of the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_returnAddress (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the return address of the frame.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)