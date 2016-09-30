---
title: "How to: Interface Between Exceptional and Non-Exceptional Code"
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
ms.assetid: fd5bb4af-5665-46a1-a321-614b48d4061e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Interface Between Exceptional and Non-Exceptional Code
This article describes how to implement consistent exception-handling in a C++ module, and also how to translate those exceptions to and from error codes at the exception boundaries.  
  
 Sometimes a C++ module has to interface with code that doesn't use exceptions (non-exceptional code). Such an interface is known as an *exception boundary*. For example, you may want to call the Win32 function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in your C++ program. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> doesn't throw exceptions; instead it sets error codes that can be retrieved by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function. If your C++ program is non-trivial, then in it you probably prefer to have a consistent exception-based error-handling policy. And you probably don't want to abandon exceptions just because you interface with non-exceptional code, and neither do you want to mix exception-based and non-exception-based error policies in your C++ module.  
  
## Calling Non-Exceptional Functions from C++  
 When you call a non-exceptional function from C++, the idea is to wrap that function in a C++ function that detects any errors and then possibly throws an exception. When you design such a wrapper function, first decide which type of exception guarantee to provide:  no-throw, strong, or basic. Second, design the function so that all resources, for example, file handles, are correctly released if an exception is thrown. Typically, this means that you use smart pointers or similar resource managers to own the resources. For more information about design considerations, see [How to: Design for Exception Safety](../vs140/how-to--design-for-exception-safety.md).  
  
### Example  
 The following example shows C++ functions that use the Win32 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions internally to open and read two files.  The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class is a resource acquisition is initialization (RAII) wrapper for the file handles. Its constructor detects a "file not found" condition and throws an exception to propagate the error up the call stack of the C++ module (in this example, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function). If an exception is thrown after a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is fully constructed, the destructor automatically calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to release the file handle. (If you prefer, you can use the Active Template Library (ATL) <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class for this same purpose, or a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> together with a custom deleter.) The functions that call Win32 and CRT APIs detect errors and then throw C++ exceptions using the locally-defined <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function, which in turn uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class, derived from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class. All functions in this example provide a strong exception guarantee; if an exception is thrown at any point in these functions, no resources are leaked and no program state is modified.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Calling Exceptional Code from Non-Exceptional Code  
 C++ functions that are declared as "extern C" can be called by C programs. C++ COM servers can be consumed by code written in any of a number of different languages. When you implement public exception-aware functions in C++ to be called by non-exceptional code, the C++ function must not allow any exceptions to propagate back to the caller. Therefore, the C++ function must specifically catch every exception that it knows how to handle and, if appropriate, convert the exception to an error code that the caller understands. If not all potential exceptions are known, the C++ function should have a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block as the last handler. In such a case, it's best to report a fatal error to the caller, because your program might be in an unknown state.  
  
 The following example shows a function that assumes that any exception that might be thrown is either a Win32Exception or an exception type derived from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The function catches any exception of these types and propagates the error information as a Win32 error code to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you convert from exceptions to error codes, one potential issue is that error codes often don't contain the richness of information that an exception can store. To address this, you can provide a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> block for each specific exception type that might be thrown, and perform logging to record the details of the exception before it is converted to an error code. This approach can create a lot of code repetition if multiple functions all use the same set of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> blocks. A good way to avoid code repetition is by refactoring those blocks into one private utility function that implements the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> blocks and accepts a function object that is invoked in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block. In each public function, pass the code to the utility function as a lambda expression.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example shows how to write the lambda expression that defines the functor. When a functor is defined "inline" by using a lambda expression, it is often easier to read than it would be if it were written as a named function object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information about lambda expressions, see [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md).  
  
## See Also  
 [Errors and Exception Handling](../vs140/errors-and-exception-handling--modern-c---.md)   
 [How to: Design for Exception Safety](../vs140/how-to--design-for-exception-safety.md)