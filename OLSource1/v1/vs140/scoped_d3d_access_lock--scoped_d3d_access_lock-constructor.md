---
title: "scoped_d3d_access_lock::scoped_d3d_access_lock Constructor"
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
ms.assetid: 08b98db7-f948-4fc3-b13c-b435c8dd9695
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_d3d_access_lock::scoped_d3d_access_lock Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. The lock is released when this object goes out of scope.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for the lock to adopt.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object from which to move an existing lock.  
  
## Construction  
 [1] Constructor  
 Acquires a D3D access lock on the given [accelerator_view](../vs140/accelerator_view-class.md) object. Construction blocks until the lock is acquired.  
  
 [2] Constructor  
 Adopt a D3D access lock from the given [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
 [3] Move Constructor  
 Takes an existing D3D access lock from another <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. Construction does not block.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency::direct3d  
  
## See Also  
 [scoped_d3d_access_lock Class](../vs140/scoped_d3d_access_lock-class.md)