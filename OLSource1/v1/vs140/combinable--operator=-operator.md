---
title: "combinable::operator= Operator"
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
  - ppl/concurrency::combinable::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator
ms.assetid: f7f22f4f-a028-4713-b638-dac4f5521a5c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# combinable::operator= Operator
Assigns to a `combinable` object from another `combinable` object.  
  
## Syntax  
  
```  
combinable& operator=(  
   const combinable& _Copy  
);  
```  
  
#### Parameters  
 `_Copy`  
 An existing `combinable` object to be copied into this one.  
  
## Return Value  
 A reference to this `combinable` object.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [combinable Class](../vs140/combinable-class.md)