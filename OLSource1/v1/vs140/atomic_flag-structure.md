---
title: "atomic_flag Structure"
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
  - "atomic/std::atomic_flag"
dev_langs: 
  - "C++"
ms.assetid: 17f0c2f5-fd39-4a44-873a-b569720a670e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_flag Structure
Describes an object that atomically sets and clears a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag. Operations on atomic flags are always lock-free.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[atomic_flag::clear Method](#atomic_flag__clear_method)|Sets the stored flag to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|[atomic_flag::test_and_set Method](#atomic_flag__test_and_set_method)|Sets the stored flag to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and returns the initial flag value.|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects can be passed to the non-member functions [atomic_flag_clear](../vs140/-atomic--functions.md#atomic_flag_clear_function), [atomic_flag_clear_explicit](../vs140/-atomic--functions.md#atomic_flag_clear_explicit_function), [atomic_flag_test_and_set](../vs140/-atomic--functions.md#atomic_flag_test_and_set_function), and [atomic_flag_test_and_set_explicit](../vs140/-atomic--functions.md#atomic_flag_test_and_set_explicit_function). They can be initialized by using the value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
##  \<a name="atomic_flag__clear_method">\</a>  atomic_flag::clear Method  
 Sets the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag that is stored in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, within the specified [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_flag__test_and_set_method">\</a>  atomic_flag::test_and_set Method  
 Sets the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag that is stored in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, within the specified [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The initial value of the flag that is stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)