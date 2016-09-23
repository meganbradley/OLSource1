---
title: "array::associated_accelerator_view Data Member"
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
  - amp/Concurrency::array::associated_accelerator_view
dev_langs: 
  - C++
helpviewer_keywords: 
  - associated_accelerator_view data member
ms.assetid: 159e41e0-86b7-454a-a249-ffd530032d10
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::associated_accelerator_view Data Member
Gets the second [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the  [array](../vs140/array-class.md) object.  
  
## Syntax  
  
```  
__declspec(property(get=get_associated_accelerator_view)) Concurrency::accelerator_view associated_accelerator_view;  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)   
 [array::array Constructor](../vs140/array--array-constructor.md)