---
title: "array::data Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::array::data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data method"
ms.assetid: bd40c7cf-44af-41a9-8bd9-151ac3d807c2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::data Method
Returns a pointer to the raw data of the [array](../vs140/array-class.md).  
  
## Syntax  
  
```  
_Value_type* data() restrict(amp,cpu);  
  
const _Value_type* data() const restrict(amp,cpu);  
```  
  
## Return Value  
 A pointer to the raw data of the array.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)