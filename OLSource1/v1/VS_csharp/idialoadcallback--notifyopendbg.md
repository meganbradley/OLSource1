---
title: "IDiaLoadCallback::NotifyOpenDBG"
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
  - "IDiaLoadCallback::NotifyOpenDBG method"
ms.assetid: dbc4dcf0-4ace-4dce-9790-0fdaf3a23d3b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback::NotifyOpenDBG
Called when a candidate .dbg file has been opened.  
  
## Syntax  
  
```cpp#  
HRESULT NotifyOpenDBG (   
   LPCOLESTR dbgPath,  
   HRESULT   resultCode  
);  
```  
  
#### Parameters  
 `dbgPath`  
 [in] The full path of the .dbg file.  
  
 `resultCode`  
 [in] Code that indicates the success (`S_OK`) or failure of the load as applied to this file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The return code is typically ignored.  
  
## See Also  
 [IDiaLoadCallback2](../VS_csharp/idialoadcallback2.md)