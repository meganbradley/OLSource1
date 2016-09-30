---
title: "How to: Use the Context Class to Implement a Cooperative Semaphore"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cooperative semaphore implementing"
  - "context class"
ms.assetid: 22f4b9c0-ca22-4a68-90ba-39e99ea76696
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the Context Class to Implement a Cooperative Semaphore
This topic shows how to use the [concurrency::Context](../vs140/context-class.md) class to implement a cooperative semaphore class.  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class lets you block or yield the current execution context. Blocking or yielding the current context is useful when the current context cannot proceed because a resource is not available. A *semaphore* is an example of one situation where the current execution context must wait for a resource to become available. A semaphore, like a critical section object, is a synchronization object that enables code in one context to have exclusive access to a resource. However, unlike a critical section object, a semaphore enables more than one context to access the resource concurrently. If the maximum number of contexts holds a semaphore lock, each additional context must wait for another context to release the lock.  
  
### To implement the semaphore class  
  
1.  Declare a class that is named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Add <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sections to this class.  
  
     [!code[concrt-cooperative-semaphore#1](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_1.cpp)]  
  
2.  In the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class, declare a [std::atomic](../vs140/atomic-structure.md) variable that holds the semaphore count and a [concurrency::concurrent_queue](../vs140/concurrent_queue-class.md) object that holds the contexts that must wait to acquire the semaphore.  
  
     [!code[concrt-cooperative-semaphore#2](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_2.cpp)]  
  
3.  In the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class, implement the constructor. The constructor takes a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value that specifies the maximum number of contexts that can concurrently hold the lock.  
  
     [!code[concrt-cooperative-semaphore#3](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_3.cpp)]  
  
4.  In the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class, implement the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method. This method decrements the semaphore count as an atomic operation. If the semaphore count becomes negative, add the current context to the end of the wait queue and call the [concurrency::Context::Block](../vs140/context--block-method.md) method to block the current context.  
  
     [!code[concrt-cooperative-semaphore#4](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_4.cpp)]  
  
5.  In the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class, implement the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method. This method increments the semaphore count as an atomic operation. If the semaphore count is negative before the increment operation, there is at least one context that is waiting for the lock. In this case, unblock the context that is at the front of the wait queue.  
  
     [!code[concrt-cooperative-semaphore#5](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_5.cpp)]  
  
## Example  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class in this example behaves cooperatively because the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> methods yield execution so that the runtime can perform other tasks.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method decrements the counter, but it might not finish adding the context to the wait queue before another context calls the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method. To account for this, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method uses a spin loop that calls the [concurrency::Context::Yield](../vs140/context--yield-method.md) method to wait for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method to finish adding the context.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method can call the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method before the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method calls the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method. You do not have to protect against this race condition because the runtime allows for these methods to be called in any order. If the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method calls <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> before the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for the same context, that context remains unblocked. The runtime only requires that each call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is matched with a corresponding call to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 The following example shows the complete <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function shows basic usage of this class. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function uses the [concurrency::parallel_for](../vs140/parallel_for-function.md) algorithm to create several tasks that require access to the semaphore. Because three threads can hold the lock at any time, some tasks must wait for another task to finish and release the lock.  
  
 [!code[concrt-cooperative-semaphore#6](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_6.cpp)]  
  
 This example produces the following sample output.  
  
 **In loop iteration 5...**  
**In loop iteration 0...**  
**In loop iteration 6...**  
**In loop iteration 1...**  
**In loop iteration 2...**  
**In loop iteration 7...**  
**In loop iteration 3...**  
**In loop iteration 8...**  
**In loop iteration 9...**  
**In loop iteration 4...** For more information about the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class, see [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md). For more information about the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> algorithm, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc cooperative-semaphore.cpp**  
  
## Robust Programming  
 You can use the *Resource Acquisition Is Initialization* (RAII) pattern to limit access to a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object to a given scope. Under the RAII pattern, a data structure is allocated on the stack. That data structure initializes or acquires a resource when it is created and destroys or releases that resource when the data structure is destroyed. The RAII pattern guarantees that the destructor is called before the enclosing scope exits. Therefore, the resource is correctly managed when an exception is thrown or when a function contains multiple <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statements.  
  
 The following example defines a class that is named <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, which is defined in the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class resembles the [concurrency::critical_section::scoped_lock](../vs140/critical_section--scoped_lock-class.md) and [concurrency::reader_writer_lock::scoped_lock](../vs140/reader_writer_lock--scoped_lock-class.md) classes. The constructor of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class acquires access to the given <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object and the destructor releases access to that object.  
  
 [!code[concrt-cooperative-semaphore#7](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_7.cpp)]  
  
 The following example modifies the body of the work function that is passed to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> algorithm so that it uses RAII to ensure that the semaphore is released before the function returns. This technique ensures that the work function is exception-safe.  
  
 [!code[concrt-cooperative-semaphore#8](../vs140/codesnippet/CPP/how-to--use-the-context-class-to-implement-a-cooperative-semaphore_8.cpp)]  
  
## See Also  
 [Contexts](../vs140/contexts.md)   
 [Context Class](../vs140/context-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)