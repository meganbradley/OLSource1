---
title: "IThreadPoolConfig::SetTimeout"
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
  - "IThreadPoolConfig::SetTimeout"
  - "IThreadPoolConfig.SetTimeout"
  - "ATL.IThreadPoolConfig.SetTimeout"
  - "ATL::IThreadPoolConfig::SetTimeout"
  - "SetTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTimeout method"
ms.assetid: b82a1dc3-0c16-4bb8-bb7b-b4055bf719c5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadPoolConfig::SetTimeout
Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The requested maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Example  
 See [IThreadPoolConfig::GetSize](../vs140/ithreadpoolconfig--getsize.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [IThreadPoolConfig Interface](../vs140/ithreadpoolconfig-interface.md)   
 [IThreadPoolConfig::GetTimeout](../vs140/ithreadpoolconfig--gettimeout.md)