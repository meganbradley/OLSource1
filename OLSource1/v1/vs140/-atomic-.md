---
title: "&lt;atomic&gt;"
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
  - "<atomic>"
  - "atomic/std::atomic_int_least32_t"
  - "atomic/std::atomic_ullong"
  - "atomic/std::atomic_ptrdiff_t"
  - "atomic/std::atomic_char16_t"
  - "atomic/std::atomic_schar"
  - "atomic/std::atomic_ulong"
  - "atomic/std::atomic_uint_fast32_t"
  - "atomic/std::atomic_uint8_t"
  - "atomic/std::atomic_int32_t"
  - "atomic/std::atomic_uint_fast64_t"
  - "atomic/std::atomic_uint32_t"
  - "atomic/std::atomic_int16_t"
  - "atomic/std::atomic_uintmax_t"
  - "atomic/std::atomic_intmax_t"
  - "atomic/std::atomic_long"
  - "atomic/std::atomic_int"
  - "atomic/std::atomic_uint_least8_t"
  - "atomic/std::atomic_size_t"
  - "atomic/std::atomic_uint_fast16_t"
  - "atomic/std::atomic_wchar_t"
  - "atomic/std::atomic_int_fast64_t"
  - "atomic/std::atomic_uint_fast8_t"
  - "atomic/std::atomic_int_fast8_t"
  - "atomic/std::atomic_intptr_t"
  - "atomic/std::atomic_uint"
  - "atomic/std::atomic_uint16_t"
  - "atomic/std::atomic_char32_t"
  - "atomic/std::atomic_uint64_t"
  - "atomic/std::atomic_ushort"
  - "atomic/std::atomic_int_least16_t"
  - "atomic/std::atomic_char"
  - "atomic/std::atomic_uint_least32_t"
  - "atomic/std::atomic_uintptr_t"
  - "atomic/std::atomic_short"
  - "atomic/std::atomic_llong"
  - "atomic/std::atomic_uint_least16_t"
  - "atomic/std::atomic_int_fast16_t"
  - "atomic/std::atomic_int_least8_t"
  - "atomic/std::atomic_int_least64_t"
  - "atomic/std::atomic_int_fast32_t"
  - "atomic/std::atomic_uchar"
  - "atomic/std::atomic_int8_t"
  - "atomic/std::atomic_int64_t"
  - "atomic/std::atomic_uint_least64_t"
dev_langs: 
  - "C++"
ms.assetid: e79a6b9f-52ff-48da-9554-654c4e1999f6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;atomic&gt;
Defines classes and template classes to use to create types that support atomic operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  In code that's compiled by using **/clr** or **/clr:pure**, this header is blocked.  
  
 An atomic operation has two key properties that help you use multiple threads to correctly manipulate an object without using mutex locks.  
  
-   Because an atomic operation is indivisible, a second atomic operation on the same object from a different thread can obtain the state of the object only before or after the first atomic operation.  
  
-   Based on its [memory_order](../vs140/-atomic--enums.md#memory_order_enum) argument, an atomic operation establishes ordering requirements for the visibility of the effects of other atomic operations in the same thread. Consequently, it inhibits compiler optimizations that violate the ordering requirements.  
  
 On some platforms, it might not be possible to efficiently implement atomic operations for some types without using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> locks. An atomic type is *lock-free* if no atomic operations on that type use locks.  
  
 **C++11**: In signal-handlers you can perform atomic operations on an object <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are true.  
  
 The class [atomic_flag](../vs140/atomic_flag-structure.md) provides a minimal atomic type that holds a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> flag. Its operations are always lock-free.  
  
 The template class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> stores an object of its argument type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and provides atomic access to that stored value. You can instantiate it by using any type that can be copied by using [memcpy](../vs140/memcpy--wmemcpy.md) and tested for equality by using [memcmp](../vs140/memcmp--wmemcmp.md). In particular, you can use it with user-defined types that meet these requirements and, in many cases, with floating-point types.  
  
 The template also has a set of specializations for integral types and a partial specialization for pointers. These specializations provide additional operations that are not available through the primary template.  
  
## Pointer Specializations  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> partial specializations apply to all pointer types. They provide methods for pointer arithmetic.  
  
## Integral Specializations  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specializations apply to all integral types. They provide additional operations that are not available through the primary template.  
  
 Each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type has a corresponding macro that you can use in an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to determine at compile time whether operations on that type are lock-free. If the value of the macro is zero, operations on the type are not lock-free. If the value is 1, operations might be lock-free, and a runtime check is required. If the value is 2, operations are lock-free. You can use the function <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to determine at runtime whether operations on the type are lock-free.  
  
 For each of the integral types, there is a corresponding named atomic type that manages an object of that integral type. Each <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type has the same set of member functions as the corresponding instantiation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and can be passed to any of the non-member atomic functions.  
  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> Type|Integral Type|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> Macro|  
|----------------------------|-------------------|---------------------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
  
 Typedef names exist for specializations of the atomic template for some of the types that are defined in the header \<inttypes.h>.  
  
|Atomic Type|Typedef Name|  
|-----------------|------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|  
  
## Structs  
  
|Name|Description|  
|----------|-----------------|  
|[atomic Structure](../vs140/atomic-structure.md)|Describes an object that performs atomic operations on a stored value.|  
|[atomic_flag Structure](../vs140/atomic_flag-structure.md)|Describes an object that atomically sets and clears a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> flag.|  
  
## Enums  
  
|Name|Description|  
|----------|-----------------|  
|[memory_order Enum](../vs140/-atomic--enums.md#memory_order_enum)|Supplies symbolic names for synchronization operations on memory locations. These operations affect how assignments in one thread become visible in another.|  
  
## Functions  
 In the following list, the functions that do not end in <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> have the semantics of the corresponding <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, except that they have the implicit [memory_order](../vs140/-atomic--enums.md#memory_order_enum) arguments of <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
|Name|Description|  
|----------|-----------------|  
|[atomic_compare_exchange_strong Function](../vs140/-atomic--functions.md#atomic_compare_exchange_strong_function)|Performs an *atomic compare and exchange* operation.|  
|[atomic_compare_exchange_strong_explicit Function](../vs140/-atomic--functions.md#atomic_compare_exchange_strong_explicit_function)|Performs an *atomic compare and exchange* operation.|  
|[atomic_compare_exchange_weak Function](../vs140/-atomic--functions.md#atomic_compare_exchange_weak_function)|Performs a *weak atomic compare and exchange* operation.|  
|[atomic_compare_exchange_weak_explicit Function](../vs140/-atomic--functions.md#atomic_compare_exchange_weak_explicit_function)|Performs a *weak atomic compare and exchange* operation.|  
|[atomic_exchange Function](../vs140/-atomic--functions.md#atomic_exchange_function)|Replaces a stored value.|  
|[atomic_exchange_explicit Function](../vs140/-atomic--functions.md#atomic_exchange_explicit_function)|Replaces a stored value.|  
|[atomic_fetch_add Function](../vs140/-atomic--functions.md#atomic_fetch_add_function)|Adds a specified value to an existing stored value.|  
|[atomic_fetch_add_explicit Function](../vs140/-atomic--functions.md#atomic_fetch_add_explicit_function)|Adds a specified value to an existing stored value.|  
|[atomic_fetch_and Function](../vs140/-atomic--functions.md#atomic_fetch_and_function)|Performs a bitwise <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_fetch_and_explicit Function](../vs140/-atomic--functions.md#atomic_fetch_and_explicit_function)|Performs a bitwise <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_fetch_or Function](../vs140/-atomic--functions.md#atomic_fetch_or_function)|Performs a bitwise <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_fetch_or_explicit Function](../vs140/-atomic--functions.md#atomic_fetch_or_explicit_function)|Performs a bitwise <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_fetch_sub Function](../vs140/-atomic--functions.md#atomic_fetch_sub_function)|Subtracts a specified value from an existing stored value.|  
|[atomic_fetch_sub_explicit Function](../vs140/-atomic--functions.md#atomic_fetch_sub_explicit_function)|Subtracts a specified value from an existing stored value.|  
|[atomic_fetch_xor Function](../vs140/-atomic--functions.md#atomic_fetch_xor_function)|Performs a bitwise <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_fetch_xor_explicit Function](../vs140/-atomic--functions.md#atomic_fetch_xor_explicit_function)|Performs a bitwise <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> on a specified value and an existing stored value.|  
|[atomic_flag_clear Function](../vs140/-atomic--functions.md#atomic_flag_clear_function)|Sets the flag in an <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.|  
|[atomic_flag_clear_explicit Function](../vs140/-atomic--functions.md#atomic_flag_clear_explicit_function)|Sets the flag in an <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.|  
|[atomic_flag_test_and_set Function](../vs140/-atomic--functions.md#atomic_flag_test_and_set_function)|Sets the flag in an <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.|  
|[atomic_flag_test_and_set_explicit Function](../vs140/-atomic--functions.md#atomic_flag_test_and_set_explicit_function)|Sets the flag in an <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.|  
|[atomic_init Function](../vs140/-atomic--functions.md#atomic_init_function)|Sets the stored value in an <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object.|  
|[atomic_is_lock_free Function](../vs140/-atomic--functions.md#atomic_is_lock_free_function)|Specifies whether atomic operations on a specified object are lock-free.|  
|[atomic_load Function](../vs140/-atomic--functions.md#atomic_load_function)|Atomically retrieves a value.|  
|[atomic_load_explicit Function](../vs140/-atomic--functions.md#atomic_load_explicit_function)|Atomically retrieves a value.|  
|[atomic_signal_fence Function](../vs140/-atomic--functions.md#atomic_signal_fence_function)|Acts as a *fence* that establishes memory ordering requirements between fences in a calling thread that has signal handlers executed in the same thread.|  
|[atomic_store Function](../vs140/-atomic--functions.md#atomic_store_function)|Atomically stores a value.|  
|[atomic_store_explicit Function](../vs140/-atomic--functions.md#atomic_store_explicit_function)|Atomically stores a value.|  
|[atomic_thread_fence Function](../vs140/-atomic--functions.md#atomic_thread_fence_function)|Acts as a *fence* that establishes memory ordering requirements with respect to other fences.|  
|[kill_dependency Function](../vs140/-atomic--functions.md#kill_dependency_function)|Breaks a possible dependency chain.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Standard Template Library](../vs140/standard-template-library.md)