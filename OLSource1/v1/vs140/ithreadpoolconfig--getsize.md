---
title: "IThreadPoolConfig::GetSize"
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
  - "ATL.IThreadPoolConfig.GetSize"
  - "IThreadPoolConfig.GetSize"
  - "IThreadPoolConfig::GetSize"
  - "ATL::IThreadPoolConfig::GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 984c8a78-5692-4771-b602-64185589629c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadPoolConfig::GetSize
Call this method to get the number of threads in the pool.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetSize)(  
   int * pnNumThreads   
);  
```  
  
#### Parameters  
 `pnNumThreads`  
 [out] Address of the variable that, on success, receives the number of threads in the pool.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Example  
 [!code[NVC_ATL_Utilities#134](../vs140/codesnippet/CPP/ithreadpoolconfig--getsize_1.cpp)]  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [IThreadPoolConfig Interface](../vs140/ithreadpoolconfig-interface.md)   
 [IThreadPoolConfig::SetSize](../vs140/ithreadpoolconfig--setsize.md)