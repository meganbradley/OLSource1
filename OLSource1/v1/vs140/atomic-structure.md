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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic Structure
Describes an object that performs atomic operations on a stored value of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
|[atomic::operator&= Operator](../vs140/atomic--operator-=-operator.md)|Performs a bitwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on a specified value and the stored value. Used only by integral specializations.|  
|[atomic::operator&#124;= Operator](../vs140/atomic--operator-=-operator.md)|Performs a bitwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on a specified value and the stored value. Used only by integral specializations.|  
|[atomic::operator^= Operator](../vs140/atomic--operator^=-operator.md)|Performs a bitwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on a specified value and the stored value. Used only by integral specializations.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[atomic::compare_exchange_strong Method](../vs140/atomic--compare_exchange_strong-method.md)|Performs an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operation on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and returns the result.|  
|[atomic::compare_exchange_weak Method](../vs140/atomic--compare_exchange_weak-method.md)|Performs a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operation on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and returns the result.|  
|[atomic::fetch_add Method](../vs140/atomic--fetch_add-method.md)|Adds a specified value to the stored value.|  
|[atomic::fetch_and Method](../vs140/atomic--fetch_and-method.md)|Performs a bitwise <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on a specified value and the stored value.|  
|[atomic::fetch_or Method](../vs140/atomic--fetch_or-method.md)|Performs a bitwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on a specified value and the stored value.|  
|[atomic::fetch_sub Method](../vs140/atomic--fetch_sub-method.md)|Subtracts a specified value from the stored value.|  
|[atomic::fetch_xor Method](../vs140/atomic--fetch_xor-method.md)|Performs a bitwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> on a specified value and the stored value.|  
|[atomic::is_lock_free Method](../vs140/atomic--is_lock_free-method.md)|Specifies whether atomic operations on <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are *lock free*. An atomic type is *lock free* if no atomic operations on that type use locks.|  
|[atomic::load Method](../vs140/atomic--load-method.md)|Reads and returns the stored value.|  
|[atomic::store Method](../vs140/atomic--store-method.md)|Uses a specified value to replace the stored value.|  
  
## Remarks  
 The type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be *trivially copyable*. That is, using [memcpy](../vs140/memcpy--wmemcpy.md) to copy its bytes must produce a valid <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object that compares equal to the original object. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member functions use [memcmp](../vs140/memcmp--wmemcmp.md) to determine whether two <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> values are equal. These functions will not use a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>-defined <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The member functions of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to copy values of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 A partial specialization, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, exists for all pointer types. The specialization enables the addition of an offset to the managed pointer value or the subtraction of an offset from it. The arithmetic operations take an argument of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and adjust that argument according to the size of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to be consistent with ordinary address arithmetic.  
  
 A specialization exists for every integral type except <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Each specialization provides a rich set of methods for atomic arithmetic and logical operations.  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
  
 Integral specializations are derived from corresponding <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> types. For example, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [Header Files](../vs140/c---standard-library-header-files.md)