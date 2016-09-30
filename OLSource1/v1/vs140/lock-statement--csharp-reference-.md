---
title: "lock Statement (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "lock_CSharpKeyword"
  - "lock"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "lock keyword [C#]"
ms.assetid: 656da1a4-707e-4ef6-9c6e-6d13b646af42
caps.latest.revision: 47
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock Statement (C# Reference)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword marks a statement block as a critical section by obtaining the mutual-exclusion lock for a given object, executing a statement, and then releasing the lock. The following example includes a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information, see [Lock Statement and Thread Synchronization (C# Programmers Reference)](../vs140/thread-synchronization--csharp-and-visual-basic-.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword ensures that one thread does not enter a critical section of code while another thread is in the critical section. If another thread tries to enter a locked code, it will wait, block, until the object is released.  
  
 The section [Threading (Visual C#)](../vs140/threading--csharp-and-visual-basic-.md) discusses threading.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword calls \<xref:System.Threading.Monitor.Enter*> at the start of the block and \<xref:System.Threading.Monitor.Exit*> at the end of the block. A \<xref:System.Threading.ThreadInterruptedException*> is thrown if \<xref:System.Threading.Thread.Interrupt*> interrupts a thread that is waiting to enter a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
 In general, avoid locking on a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type, or instances beyond your code's control. The common constructs <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> violate this guideline:  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a problem if the instance can be accessed publicly.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a problem if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is publicly accessible.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a problem because any other code in the process using the same string, will share the same lock.  
  
 Best practice is to define a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object to lock on, or a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object variable to protect data common to all instances.  
  
 You can't use the [await](../vs140/await--csharp-reference-.md) keyword in the body of a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement.  
  
## Example  
 The following sample shows a simple use of threads without locking in C#.  
  
 [!code[csrefKeywordsFixedLock#5](../vs140/codesnippet/CSharp/lock-statement--csharp-reference-_1.cs)]  
  
## Example  
 The following sample uses threads and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. As long as the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement is present, the statement block is a critical section and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will never become a negative number.  
  
 [!code[csrefKeywordsFixedLock#6](../vs140/codesnippet/CSharp/lock-statement--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Reflection.MethodImplAttributes*>   
 \<xref:System.Threading.Mutex*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Threading (Visual C#)](../vs140/threading--csharp-and-visual-basic-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Statement Keywords](../vs140/statement-keywords--csharp-reference-.md)   
 [Monitor](assetId:///33fe4aef-b44b-42fd-9e72-c908e39e75db)   
 [Interlocked](assetId:///cbda7114-c752-4f3e-ada1-b1e8dd262f2b)   
 [AutoResetEvent,](assetId:///6d39c48d-6b37-4a9b-8631-f2924cfd9c18)   
 [Lock Statement and Thread Synchronization (C# Programmers Reference)](../vs140/thread-synchronization--csharp-and-visual-basic-.md)