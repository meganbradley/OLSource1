---
title: "d3d_access_unlock Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: e09858f3-9db8-476a-874f-8a68edbe2953
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# d3d_access_unlock Function
Release the D3D access lock on the given accelerator_view. If the calling thread does not hold the lock on the accelerator_view the results are undefined.  
  
## Syntax  
  
```  
void __cdecl d3d_access_unlock(  
   accelerator_view &_Av  
);  
```  
  
#### Parameters  
 `_Av`  
 The accelerator_view for which the lock is to be released.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency::direct3d  
  
## See Also  
 [concurrency::direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)