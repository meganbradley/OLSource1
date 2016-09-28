---
title: "atomic Structure"
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
  - "atomic/std::atomic"
dev_langs: 
  - "C++"
ms.assetid: 261628ed-7049-41ac-99b9-cfe49f696b44
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic Structure
Describes an object that performs atomic operations on a stored value of type `Ty`.  
  
## Syntax  
  
```  
template <class Ty>  
struct atomic;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[atomic::atomic Constructor](../vs140/atomic--atomic-constructor.md)|Constructs an atomic object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[atomic::operator Ty Operator](../vs140/atomic--operator-ty-operator.md)|Reads and returns the stored value. ([atomic::load Method](../vs140/atomic--load-method.md))|  
|[atomic::operator= Operator](../vs140/atomic--operator=-operator.md)|Uses a specified value to replace the stored value. ([atomic::store Method](../vs140/atomic--store-method.md))|  
|||  
|[atomic::operator++ Operator](../vs140/atomic--operator---operator.md)|Increments the stored value. Used only by integral and pointer specializations.|  
|[atomic::operator+= Operator](../vs140/atomic--operator-=-operator.md)|Adds a specified value to the stored value. Used only by integral and pointer specializations.|  
|[atomic::operator-- Operator](../vs140/atomic--operator---operator.md)|Decrements the stored value. Used only by integral and pointer specializations.|  
|[atomic::operator-= Operator](../vs140/atomic--operator-=-operator.md)|Subtracts a specified value from the stored value. Used only by integral and pointer specializations.|  
|[atomic::operator&= Operator](../vs140/atomic--operator-=-operator.md)|Performs a bitwise `and` on a specified value and the stored value. Used only by integral specializations.|  
|[atomic::operator&#124;= Operator](../vs140/atomic--operator-=-operator.md)|Performs a bitwise `or` on a specified value and the stored value. Used only by integral specializations.|  
|[atomic::operator^= Operator](../vs140/atomic--operator^=-operator.md)|Performs a bitwise `exclusive or` on a specified value and the stored value. Used only by integral specializations.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[atomic::compare_exchange_strong Method](../vs140/atomic--compare_exchange_strong-method.md)|Performs an `atomic_compare_and_exchange` operation on `this` and returns the result.|  
|[atomic::compare_exchange_weak Method](../vs140/atomic--compare_exchange_weak-method.md)|Performs a `weak_atomic_compare_and_exchange` operation on `this` and returns the result.|  
|[atomic::fetch_add Method](../vs140/atomic--fetch_add-method.md)|Adds a specified value to the stored value.|  
|[atomic::fetch_and Method](../vs140/atomic--fetch_and-method.md)|Performs a bitwise `and` on a specified value and the stored value.|  
|[atomic::fetch_or Method](../vs140/atomic--fetch_or-method.md)|Performs a bitwise `or` on a specified value and the stored value.|  
|[atomic::fetch_sub Method](../vs140/atomic--fetch_sub-method.md)|Subtracts a specified value from the stored value.|  
|[atomic::fetch_xor Method](../vs140/atomic--fetch_xor-method.md)|Performs a bitwise `exclusive or` on a specified value and the stored value.|  
|[atomic::is_lock_free Method](../vs140/atomic--is_lock_free-method.md)|Specifies whether atomic operations on `this` are *lock free*. An atomic type is *lock free* if no atomic operations on that type use locks.|  
|[atomic::load Method](../vs140/atomic--load-method.md)|Reads and returns the stored value.|  
|[atomic::store Method](../vs140/atomic--store-method.md)|Uses a specified value to replace the stored value.|  
  
## Remarks  
 The type `Ty` must be *trivially copyable*. That is, using [memcpy](../vs140/memcpy--wmemcpy.md) to copy its bytes must produce a valid `Ty` object that compares equal to the original object. The `compare_exchange_weak` and `compare_exchange_strong` member functions use [memcmp](../vs140/memcmp--wmemcmp.md) to determine whether two `Ty` values are equal. These functions will not use a `Ty`-defined `operator==`. The member functions of `atomic` use `memcpy` to copy values of type `Ty`.  
  
 A partial specialization, `atomic<Ty *>`, exists for all pointer types. The specialization enables the addition of an offset to the managed pointer value or the subtraction of an offset from it. The arithmetic operations take an argument of type `ptrdiff_t` and adjust that argument according to the size of `Ty` to be consistent with ordinary address arithmetic.  
  
 A specialization exists for every integral type except `bool`. Each specialization provides a rich set of methods for atomic arithmetic and logical operations.  
  
||||  
|-|-|-|  
|`atomic<char>`|`atomic<signed char>`|`atomic<unsigned char>`|  
|`atomic<char16_t>`|`atomic<char32_t>`|`atomic<wchar_t>`|  
|`atomic<short>`|`atomic<unsigned short>`|`atomic<int>`|  
|`atomic<unsigned int>`|`atomic<long>`|`atomic<unsigned long>`|  
|`atomic<long long>`|`atomic<unsigned long long>`|  
  
 Integral specializations are derived from corresponding `atomic_``integral` types. For example, `atomic<unsigned int>` is derived from `atomic_uint`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [Header Files](../vs140/c---standard-library-header-files.md)