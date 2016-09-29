---
title: "IThreadPoolConfig::GetTimeout"
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
  - "ATL::IThreadPoolConfig::GetTimeout"
  - "GetTimeout"
  - "ATL.IThreadPoolConfig.GetTimeout"
  - "IThreadPoolConfig.GetTimeout"
  - "IThreadPoolConfig::GetTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTimeout method"
ms.assetid: 9a746b5c-d42a-4455-bddd-d7d497eeaa5c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadPoolConfig::GetTimeout
Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetTimeout)(  
   DWORD * pdwMaxWait   
);  
```  
  
#### Parameters  
 `pdwMaxWait`  
 [out] Address of the variable that, on success, receives the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Example  
 See [IThreadPoolConfig::GetSize](../VS_csharp/ithreadpoolconfig--getsize.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [IThreadPoolConfig Interface](../VS_csharp/ithreadpoolconfig-interface.md)   
 [IThreadPoolConfig::SetTimeout](../VS_csharp/ithreadpoolconfig--settimeout.md)