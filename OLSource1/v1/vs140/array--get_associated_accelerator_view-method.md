---
title: "array::get_associated_accelerator_view Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::array::get_associated_accelerator_view
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_associated_accelerator_view method
ms.assetid: 2756737e-29a9-4721-8205-e8a945253ae8
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::get_associated_accelerator_view Method
Gets the second [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the  [array](../vs140/array-class.md) object.  
  
## Syntax  
  
```  
Concurrency::accelerator_view get_associated_accelerator_view() const ;  
```  
  
## Return Value  
 The second [accelerator_view](../vs140/accelerator_view-class.md) object passed to the staging constructor.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)