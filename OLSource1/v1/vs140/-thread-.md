---
title: "&lt;thread&gt;"
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
  - "<thread>"
dev_langs: 
  - "C++"
ms.assetid: 0c858405-4efb-449d-bf76-70d3693c9234
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;thread&gt;
Include the standard header \<thread> to define the class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and various supporting functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  In code that is compiled by using **/clr** or **/clr:pure**, this header is blocked.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro is defined as a nonzero value to indicate that threads are supported by this header.  
  
## Members  
  
### Public Classes  
  
|Name|Description|  
|----------|-----------------|  
|[thread Class](../vs140/thread-class.md)|Defines an object that is used to observe and manage a thread of execution in an application.|  
  
### Public Structures  
  
|Name|Description|  
|----------|-----------------|  
|[hash Structure](../vs140/hash-structure--stl-.md)|Defines a member function that returns a value that is uniquely determined by a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The member function defines a [hash function](../vs140/hash-class.md) that is suitable for mapping values of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to a distribution of index values.|  
  
### Public Functions  
  
|Name|Description|  
|----------|-----------------|  
|[get_id Function](../vs140/-thread--functions.md#get_id_function)|Uniquely identifies the current thread of execution.|  
|[sleep_for Function](../vs140/-thread--functions.md#sleep_for_function)|Blocks the calling thread.|  
|[sleep_until Function](../vs140/-thread--functions.md#sleep_until_function)|Blocks the calling thread at least until the specified time.|  
|[swap Function](../vs140/-thread--functions.md#swap_function)|Exchanges the states of two <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects.|  
|[yield Function](../vs140/-thread--functions.md#yield_function)|Signals the operating system to run other threads, even if the current thread would ordinarily continue to run.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator>= Operator](../vs140/-thread--operators.md#operator_gt__eq)|Determines whether one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is greater than or equal to another.|  
|[operator> Operator](../vs140/-thread--operators.md#operator_gt_)|Determines whether one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is greater than another.|  
|[operator<= Operator](../vs140/-thread--operators.md#operator_lt__eq)|Determines whether one <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is less than or equal to another.|  
|[operator< Operator](../vs140/-thread--operators.md#operator_lt_)|Determines whether one <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is less than another.|  
|[operator!= Operator](../vs140/-thread--operators.md#operator_neq)|Compares two <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects for inequality.|  
|[operator== Operator](../vs140/-thread--operators.md#operator_eq_eq)|Compares two <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects for equality.|  
|[operator<< Operator](../vs140/-thread--operators.md#operator_lt__lt_)|Inserts a text representation of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object into a stream.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)