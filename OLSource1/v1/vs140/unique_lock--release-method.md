---
title: "unique_lock::release Method"
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
  - "mutex/std::unique_lock::release"
dev_langs: 
  - "C++"
ms.assetid: fcad2594-bd75-4a7f-9722-05f0de8e1c44
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::release Method
Disassociates the `unique_lock` object from the associated `mutex` object.  
  
## Syntax  
  
```cpp  
mutex_type *release() _NOEXCEPT;  
```  
  
## Return Value  
 The previous value of the stored `mutex` pointer.  
  
## Remarks  
 This method sets the value of the stored `mutex` pointer to 0 and sets the internal `mutex` ownership flag to `false`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)