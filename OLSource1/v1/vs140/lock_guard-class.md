---
title: "lock_guard Class"
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
  - "mutex/std::lock_guard"
dev_langs: 
  - "C++"
ms.assetid: 57121f0d-9c50-481c-b971-54e64df864e0
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock_guard Class
Represents a template that can be instantiated to create an object whose destructor unlocks a `mutex`.  
  
## Syntax  
  
```  
template<class Mutex>  
class lock_guard;  
```  
  
## Remarks  
 The template argument `Mutex` must name a *mutex type*.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`lock_guard::mutex_type`|Synonym for the template argument `Mutex`.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[lock_guard::lock_guard Constructor](#lock_guard__lock_guard_constructor)|Constructs a `lock_guard` object.|  
|[lock_guard::~lock_guard Destructor](#lock_guard___dtorlock_guard_destructor)|Unlocks the `mutex` that was passed to the constructor.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  <a name="lock_guard__lock_guard_constructor"></a>  lock_guard::lock_guard Constructor  
 Constructs a `lock_guard` object.  
  
```cpp  
explicit lock_guard(mutex_type& Mtx);  
lock_guard(mutex_type& Mtx, adopt_lock_t);  
```  
  
### Parameters  
 `Mtx`  
 A *mutex type* object.  
  
### Remarks  
 The first constructor constructs an object of type `lock_guard` and locks `Mtx`. If `Mtx` is not a recursive mutex, it must be unlocked when this constructor is called.  
  
 The second constructor does not lock `Mtx`. `Mtx` must be locked when this constructor is called. The constructor throws no exceptions.  
  
##  <a name="lock_guard___dtorlock_guard_destructor"></a>  lock_guard::~lock_guard Destructor  
 Unlocks the `mutex` that was passed to the constructor.  
  
```  
~lock_guard() _NOEXCEPT;  
```  
  
### Remarks  
 If the `mutex` does not exist when the destructor runs, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)