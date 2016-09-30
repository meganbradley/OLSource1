---
title: "scoped_d3d_access_lock::operator= Operator"
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
ms.assetid: 29c7e8fd-9179-499a-bc99-31cdffe484f1
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_d3d_access_lock::operator= Operator
Takes ownership of a D3D access lock from another `scoped_d3d_access_lock` object, releasing the previous lock.  
  
## Syntax  
  
```  
scoped_d3d_access_lock& operator=(  
   scoped_d3d_access_lock &&_Other  
);  
```  
  
#### Parameters  
 `_Other`  
 The accelerator_view from which to move the D3D access lock.  
  
## Return Value  
 A reference to this `scoped_accelerator_view_lock`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency::direct3d  
  
## See Also  
 [scoped_d3d_access_lock Class](../vs140/scoped_d3d_access_lock-class.md)