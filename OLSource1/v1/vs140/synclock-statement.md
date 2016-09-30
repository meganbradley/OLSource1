---
title: "SyncLock Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.SyncLock"
  - "SyncLock"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "threading [Visual Basic], locks"
  - "SyncLock statement"
  - "locks, threads"
ms.assetid: 14501703-298f-4d43-b139-c4b6366af176
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SyncLock Statement
Acquires an exclusive lock for a statement block before executing the block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Expression that evaluates to an object reference.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. Block of statements that are to execute when the lock is acquired.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Terminates a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement ensures that multiple threads do not execute the statement block at the same time. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> prevents each thread from entering the block until no other thread is executing it.  
  
 The most common use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is to protect data from being updated by more than one thread simultaneously. If the statements that manipulate the data must go to completion without interruption, put them inside a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block.  
  
 A statement block protected by an exclusive lock is sometimes called a *critical section*.  
  
## Rules  
  
-   Branching. You cannot branch into a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block from outside the block.  
  
-   Lock Object Value. The value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> cannot be <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. You must create the lock object before you use it in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement.  
  
     You cannot change the value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> while executing a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block. The mechanism requires that the lock object remain unchanged.  
  
-   You can't use the [Await](../vs140/await-operator--visual-basic-.md) operator in a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block.  
  
## Behavior  
  
-   Mechanism. When a thread reaches the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement, it evaluates the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> expression and suspends execution until it acquires an exclusive lock on the object returned by the expression. When another thread reaches the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement, it does not acquire a lock until the first thread executes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement.  
  
-   Protected Data. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> variable, the exclusive lock prevents a thread in any instance of the class from executing the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block while any other thread is executing it. This protects data that is shared among all the instances.  
  
     If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is an instance variable (not <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>), the lock prevents a thread running in the current instance from executing the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block at the same time as another thread in the same instance. This protects data maintained by the individual instance.  
  
-   Acquisition and Release. A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block behaves like a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> construction in which the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block acquires an exclusive lock on <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> block releases it. Because of this, the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block guarantees release of the lock, no matter how you exit the block. This is true even in the case of an unhandled exception.  
  
-   Framework Calls. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block acquires and releases the exclusive lock by calling the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> methods of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class in the \<xref:System.Threading*> namespace.  
  
## Programming Practices  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> expression should always evaluate to an object that belongs exclusively to your class. You should declare a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object variable to protect data belonging to the current instance, or a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object variable to protect data common to all instances.  
  
 You should not use the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> keyword to provide a lock object for instance data. If code external to your class has a reference to an instance of your class, it could use that reference as a lock object for a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block completely different from yours, protecting different data. In this way, your class and the other class could block each other from executing their unrelated <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> blocks. Similarly locking on a string can be problematic since any other code in the process using the same string will share the same lock.  
  
 You should also not use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method to provide a lock object for shared data. This is because <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> always returns the same <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object for a given class name. External code could call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> on your class and obtain the same lock object you are using. This would result in the two classes blocking each other from their <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> blocks.  
  
## Examples  
  
### Description  
 The following example shows a class that maintains a simple list of messages. It holds the messages in an array and the last used element of that array in a variable. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> procedure increments the last element and stores the new message. Those two operations are protected by the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statements, because once the last element has been incremented, the new message must be stored before any other thread can increment the last element again.  
  
 If the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> class shared one list of messages among all its instances, the variables <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> would be declared as <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. In this case, the variable <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> should also be <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, so that there would be a single lock object used by every instance.  
  
### Code  
 [!code[VbVbalrThreading#1](../vs140/codesnippet/VisualBasic/synclock-statement_1.vb)]  
  
### Description  
 The following example uses threads and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. As long as the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement is present, the statement block is a critical section and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> never becomes a negative number. You can comment out the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statements to see the effect of leaving out the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> keyword.  
  
### Code  
 [!code[VbVbalrThreading#21](../vs140/codesnippet/VisualBasic/synclock-statement_2.vb)]  
  
### Comments  
  
## See Also  
 \<xref:System.Threading*>   
 \<xref:System.Threading.Monitor*>   
 [Thread Synchronization (C# and Visual Basic)](../vs140/thread-synchronization--csharp-and-visual-basic-.md)   
 [Threading (C# and Visual Basic)](../vs140/threading--csharp-and-visual-basic-.md)