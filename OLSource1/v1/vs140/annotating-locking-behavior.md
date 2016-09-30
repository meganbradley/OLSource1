---
title: "Annotating Locking Behavior"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_Releases_nonreentrant_lock_"
  - "_Lock_kind_mutex_"
  - "_Lock_kind_critical_section_"
  - "_Acquires_lock_"
  - "_Releases_lock_"
  - "_Has_lock_kind_"
  - "_Releases_exclusive_lock_"
  - "_Post_same_lock_"
  - "_Requires_exclusive_lock_held_"
  - "_Requires_shared_lock_held_"
  - "_Lock_kind_semaphore_"
  - "_Requires_lock_held_"
  - "_Acquires_exclusive_lock_"
  - "_Create_lock_level_"
  - "_Acquires_nonreentrant_lock_"
  - "_Releases_shared_lock_"
  - "_Has_lock_level_"
  - "_Lock_kind_spin_lock_"
  - "_Requires_lock_not_held_"
  - "_Acquires_shared_lock_"
  - "_Requires_no_locks_held_"
  - "_Lock_level_order_"
  - "_Lock_kind_event_"
ms.assetid: 07769c25-9b97-4ab7-b175-d1c450308d7a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Annotating Locking Behavior
To avoid concurrency bugs in your multithreaded program, always follow an appropriate locking discipline and use SAL annotations.  
  
 Concurrency bugs are notoriously hard to reproduce, diagnose, and debug because they are non-deterministic. Reasoning about thread interleaving is difficult at best, and becomes impractical when you are designing a body of code that has more than a few threads. Therefore, it's good practice to follow a locking discipline in your multithreaded programs. For example, obeying a lock order while acquiring multiple locks helps avoid deadlocks, and acquiring the proper guarding lock before accessing a shared resource helps prevent race conditions.  
  
 Unfortunately, seemingly simple locking rules can be surprisingly hard to follow in practice. A fundamental limitation in today’s programming languages and compilers is that they do not directly support the specification and analysis of concurrency requirements. Programmers have to rely on informal code comments to express their intentions about how they use locks.  
  
 Concurrency SAL annotations are designed to help you specify locking side effects, locking responsibility, data guardianship, lock order hierarchy, and other expected locking behavior. By making implicit rules explicit, SAL concurrency annotations provide a consistent way for you to document how your code uses locking rules. Concurrency annotations also enhance the ability of code analysis tools to find race conditions, deadlocks, mismatched synchronization operations, and other subtle concurrency errors.  
  
## General Guidelines  
 By using annotations, you can state the contracts that are implied by function definitions between implementations (callees) and clients (callers), and express invariants and other properties of the program that can further improve analysis.  
  
 SAL supports many different kinds of locking primitives—for example, critical sections, mutexes, spin locks, and other resource objects. Many concurrency annotations take a lock expression as a parameter. By convention, a lock is denoted by the path expression of the underlying lock object.  
  
 Some thread ownership rules to keep in mind:  
  
-   Spin locks are uncounted locks that have clear thread ownership.  
  
-   Mutexes and critical sections are counted locks that have clear thread ownership.  
  
-   Semaphores and events are counted locks that do not have clear thread ownership.  
  
## Locking Annotations  
 The following table lists the locking annotations.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function increments by one the exclusive lock count of the lock object that's named by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function increments by one the lock count of the lock object that's named by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The lock that's named by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is acquired.  An error is reported if the lock is already held.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function increments by one the shared lock count of the lock object that's named by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A statement that declares the symbol <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to be a lock level so that it may be used in the annotations <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Annotates any object to refine the type information of a resource object. Sometimes a common type is used for different kinds of resources and the overloaded type is not sufficient to distinguish the semantic requirements among various resources. Here's a list of pre-defined <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters:\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br /> Lock kind ID for mutexes.\<br />\<br /> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br /> Lock kind ID for events.\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br /> Lock kind ID for semaphores.\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br /> Lock kind ID for spin locks.\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br /> Lock kind ID for critical sections.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Annotates a lock object and gives it the lock level of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|A statement that gives the lock ordering between <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the two locks, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, are treated as if they are the same lock object.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function decrements by one the exclusive lock count of the lock object that's named by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function decrements by one the lock count of the lock object that's named by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|The lock that's named by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is released. An error is reported if the lock is not currently held.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Annotates a function and indicates that in post state the function decrements by one the shared lock count of the lock object that's named by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Annotates a function and indicates that in pre state the lock count of the object that's named by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is at least one.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Annotates a function and indicates that in pre state the lock count of the object that's named by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is zero.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Annotates a function and indicates that the lock counts of all locks that are known to the checker are zero.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Annotates a function and indicates that in pre state the shared lock count of the object that's named by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is at least one.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Annotates a function and indicates that in pre state the exclusive lock count of the object that's named by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is at least one.|  
  
## SAL Intrinsics For Unexposed Locking Objects  
 Certain lock objects are not exposed by the implementation of the associated locking functions.  The following table lists SAL intrinsic variables that enable annotations on functions that operate on those unexposed lock objects.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Describes the cancel spin lock.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Describes the critical region.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Describes interlocked operations.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Describes the priority region.|  
  
## Shared Data Access Annotations  
 The following table lists the annotations for shared data access.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Annotates a variable and indicates that whenever the variable is accessed, the lock count of the lock object that's named by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is at least one.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Annotates a variable and is equivalent to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|The annotated function parameter is the target operand of one of the various Interlocked functions.  Those operands must have specific additional properties.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Annotates a variable and indicates that whenever the variable is modified, the lock count of the lock object that's named by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is at least one.|  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Specifying When and Where an Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)   
 [Code Analysis Team Blog](http://go.microsoft.com/fwlink/p/?LinkId=251197)