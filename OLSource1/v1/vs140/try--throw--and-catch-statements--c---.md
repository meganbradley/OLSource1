---
title: "try, throw, and catch Statements (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "catch_cpp"
  - "throw"
  - "try_cpp"
  - "try"
  - "throw_cpp"
  - "catch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "catch keyword [C++]"
  - "keywords [C++], exception handling"
  - "C++ exception handling, statement syntax"
  - "try-catch keyword [C++], about try-catch exception handling"
  - "throw keyword [C++]"
  - "try-catch keyword [C++]"
  - "try-catch keyword [C++], exception handling"
  - "throwing exceptions, throw keyword"
  - "try-catch keyword [C++], throw keyword [C++]s"
  - "throwing exceptions, implementing C++ exception handling"
  - "throwing exceptions"
  - "throw keyword [C++], throw() vs. throw(...)"
ms.assetid: 15e6a87b-b8a5-4032-a7ef-946c644ba12a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try, throw, and catch Statements (C++)
To implement exception handling in C++, you use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> expressions.  
  
 First, use a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block to enclose one or more statements that might throw an exception.  
  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression signals that an exceptional condition—often, an error—has occurred in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block. You can use an object of any type as the operand of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression. Typically, this object is used to communicate information about the error. In most cases, we recommend that you use the [std::exception](../vs140/exception-class.md) class or one of the derived classes that are defined in the standard library. If one of those is not appropriate, we recommend that you derive your own exception class from  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 To handle exceptions that may be thrown, implement one or more <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> blocks immediately following a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block. Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block specifies the type of exception it can handle.  
  
 This example shows a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block and its handlers. Assume that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> acquires data over a network connection and that the two exception types are user-defined classes that derive from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Notice that the exceptions are caught by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> reference in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement. We recommend that you throw exceptions by value and catch them by const reference.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The code after the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause is the guarded section of code. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> expression *throws*—that is, raises—an exception. The code block after the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> clause is the exception handler. This is the handler that *catches* the exception that's thrown if the types in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> expressions are compatible. For a list of rules that govern type-matching in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> blocks, see [How Catch Blocks are Evaluated](../vs140/how-catch-blocks-are-evaluated--c---.md). If the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement specifies an ellipsis (...) instead of a type, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block handles every type of exception. When you compile with the [/EHa](../vs140/-eh--exception-handling-model-.md) option, these can include C structured exceptions and system-generated or application-generated asynchronous exceptions such as memory protection, divide-by-zero, and floating-point violations. Because <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> blocks are processed in program order to find a matching type, an ellipsis handler must be the last handler for the associated <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> block. Use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> with caution; do not allow a program to continue unless the catch block knows how to handle the specific exception that is caught. Typically, a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block is used to log errors and perform special cleanup before program execution is stopped.  
  
 A <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> expression that has no operand re-throws the exception currently being handled. We recommend this form when re-throwing the exception, because this preserves the original exception’s polymorphic type information. Such an expression should only be used in a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> handler or in a function that's called from a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> handler. The re-thrown exception object is the original exception object, not a copy.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C++ Exception Handling](../vs140/c---exception-handling.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Unhandled C++ Exceptions](../vs140/unhandled-c---exceptions.md)   
 [__uncaught_exception](../vs140/__uncaught_exception.md)