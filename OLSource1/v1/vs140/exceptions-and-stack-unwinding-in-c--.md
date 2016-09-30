---
title: "Exceptions and Stack Unwinding in C++"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: a1a57eae-5fc5-4c49-824f-3ce2eb8129ed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions and Stack Unwinding in C++
In the C++ exception mechanism, control moves from the throw statement to the first catch statement that can handle the thrown type. When the catch statement is reached, all of the automatic variables that are in scope between the throw and catch statements are destroyed in a process that is known as *stack unwinding*. In stack unwinding, execution proceeds as follows:  
  
1.  Control reaches the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement by normal sequential execution. The guarded section in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block is executed.  
  
2.  If no exception is thrown during execution of the guarded section, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clauses that follow the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block are not executed. Execution continues at the statement after the last <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause that follows the associated <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block.  
  
3.  If an exception is thrown during execution of the guarded section or in any routine that the guarded section calls either directly or indirectly, an exception object is created from the object that is created by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operand. (This implies that a copy constructor may be involved.) At this point, the compiler looks for a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause in a higher execution context that can handle an exception of the type that is thrown, or for a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> handler that can handle any type of exception. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> handlers are examined in order of their appearance after the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block. If no appropriate handler is found, the next dynamically enclosing <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block is examined. This process continues until the outermost enclosing <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block is examined.  
  
4.  If a matching handler is still not found, or if an exception occurs during the unwinding process but before the handler gets control, the predefined run-time function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is called. If an exception occurs after the exception is thrown but before the unwind begins, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is called.  
  
5.  If a matching <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> handler is found, and it catches by value, its formal parameter is initialized by copying the exception object. If it catches by reference, the parameter is initialized to refer to the exception object. After the formal parameter is initialized, the process of unwinding the stack begins. This involves the destruction of all automatic objects that were fully constructed—but not yet destructed—between the beginning of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block that is associated with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> handler and the throw site of the exception. Destruction occurs in reverse order of construction. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> handler is executed and the program resumes execution after the last handler—that is, at the first statement or construct that is not a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> handler. Control can only enter a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> handler through a thrown exception, never through a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement or a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> label in a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>statement.  
  
## Stack Unwinding Example  
 The following example demonstrates how the stack is unwound when an exception is thrown. Execution on the thread jumps from the throw statement in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to the catch statement in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and unwinds each function along the way. Notice the order in which the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects are created and then destroyed as they go out of scope. Also notice that no function completes except <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, which contains the catch statement. Function <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> never returns from its call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> never returns from its call to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If you uncomment the definition of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> pointer and the corresponding delete statement, and then run the program, notice that the pointer is never deleted. This shows what can happen when functions do not provide an exception guarantee. For more information, see How to: Design for Exceptions. If you comment out the catch statement, you can observe what happens when a program terminates because of an unhandled exception.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>