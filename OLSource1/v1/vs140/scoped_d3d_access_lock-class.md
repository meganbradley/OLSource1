---
title: "scoped_d3d_access_lock Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 0ad333e6-9839-4736-a722-16d95d70c4b1
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# scoped_d3d_access_lock Class
RAII wrapper for a D3D access lock on an accelerator_view object.  
  
## Syntax  
  
```  
class scoped_d3d_access_lock;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_d3d_access_lock::scoped_d3d_access_lock Constructor](#scoped_d3d_access_lock__scoped_d3d_access_lock_constructor)|Overloaded. Constructs a                                         `scoped_d3d_access_lock` object. The lock is released when this object goes out of scope.|  
|[scoped_d3d_access_lock::~scoped_d3d_access_lock Destructor](#scoped_d3d_access_lock___dtorscoped_d3d_access_lock_destructor)|Releases the D3D access lock on the associated                                         `accelerator_view` object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_d3d_access_lock::operator= Operator](#scoped_d3d_access_lock__operator_eq_operator)|Takes ownership of a lock from another                                         `scoped_d3d_access_lock`.|  
  
## Inheritance Hierarchy  
 `scoped_d3d_access_lock`  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency::direct3d  
  
##  <a name="scoped_d3d_access_lock___dtorscoped_d3d_access_lock_destructor"></a>  scoped_d3d_access_lock::~scoped_d3d_access_lock Destructor  
 Releases the D3D access lock on the associated                 `accelerator_view` object.  
  
```  
~scoped_d3d_access_lock();  
```  
  
## See Also  
 [concurrency::direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)