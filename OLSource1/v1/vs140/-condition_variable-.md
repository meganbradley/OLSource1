---
title: "&lt;condition_variable&gt;"
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
  - "<condition_variable>"
dev_langs: 
  - "C++"
ms.assetid: 8567f7cc-20bd-42a7-9137-87c46f878009
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;condition_variable&gt;
Defines the classes [condition_variable](../vs140/condition_variable-class.md) and [condition_variable_any](../vs140/condition_variable_any-class.md) that are used to create objects that wait for a condition to become true.  
  
 This header uses Concurrency Runtime (ConcRT) so that you can use it together with other ConcRT mechanisms. For more information about ConcRT, see [Concurrency Runtime](../vs140/concurrency-runtime.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  In code that is compiled by using **/clr** or **/clr:pure**, this header is blocked.  
  
### Remarks  
 Code that waits for a condition variable must also use a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. A calling thread must lock the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> before it calls the functions that wait for the condition variable. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is then locked when the called function returns. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not locked while the thread waits for the condition to become true. So that there are no unpredictable results, each thread that waits for a condition variable must use the same <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 Objects of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used with a mutex of any type. The type of the mutex that is used does not have to provide the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method. Objects of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can only be used with a mutex of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Objects of this type may be faster than objects of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 To wait for an event, first lock the mutex, and then call one of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> methods on the condition variable. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call blocks until another thread signals the condition variable.  
  
 *Spurious wakeups* occur when threads that are waiting for condition variables become unblocked without appropriate notifications. To recognize such spurious wakeups, code that waits for a condition to become true should explicitly check that condition when the code returns from a wait function. This is usually done by using a loop; you can use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to perform this loop for you.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> classes each have three methods that wait for a condition.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> waits for an unbounded time period.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> waits until a specified <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> waits for a specified <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Each of these methods has two overloaded versions. One just waits and can wake up spuriously. The other takes an additional template argument that defines a predicate. The method does not return until the predicate is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 Each class also has two methods that are used to notify a condition variable that its condition is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> wakes up one of the threads that is waiting for the condition variable.  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> wakes up all of the threads that are waiting for the condition variable.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [condition_variable_any Class](../vs140/condition_variable_any-class.md)   
 [cv_status Enumeration](../vs140/-condition_variable--enums.md#cv_status_enumeration)