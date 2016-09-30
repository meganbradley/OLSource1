---
title: "Exception Handling Differences"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "structured exception handling, vs. C++ exception handling"
  - "structured exception handling, vs. unstructured"
  - "exceptions, wrapper class"
  - "C++ exception handling, vs. structured exception handling"
  - "wrapper classes, C exception"
ms.assetid: f21d1944-4810-468e-b02a-9f77da4138c9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Handling Differences
The major difference between structured exception handling and C++ exception handling is that the C++ exception handling model deals in types, while the C structured exception handling model deals with exceptions of one type — specifically, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. That is, C exceptions are identified by an unsigned integer value, whereas C++ exceptions are identified by data type. When an exception is raised in C, each possible handler executes a filter that examines the C exception context and determines whether to accept the exception, pass it to some other handler, or ignore it. When an exception is thrown in C++, it may be of any type.  
  
 A second difference is that the C structured exception handling model is referred to as "asynchronous" in that exceptions occur secondary to the normal flow of control. The C++ exception handling mechanism is fully "synchronous," which means that exceptions occur only when they are thrown.  
  
 If a C exception is raised in a C++ program, it can be handled by a structured exception handler with its associated filter or by a C++ **catch** handler, whichever is dynamically nearer to the exception context. For example, the following C++ program raises a C exception inside a C++ **try** context:  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **In finally.**  
**Caught a C exception.**   
##  \<a name="_core_c_exception_wrapper_class">\</a> C Exception Wrapper Class  
 In a simple example like the above, the C exception can be caught only by an ellipsis (**...**) **catch** handler. No information about the type or nature of the exception is communicated to the handler. While this method works, in some cases you may need to define a transformation between the two exception handling models so that each C exception is associated with a specific class. To do this, you can define a C exception "wrapper" class, which can be used or derived from in order to attribute a specific class type to a C exception. By doing so, each C exception can be handled by a C++ **catch** handler more separately than in the preceding example.  
  
 Your wrapper class might have an interface consisting of some member functions that determine the value of the exception, and that access the extended exception context information provided by the C exception model. You might also want to define a default constructor and a constructor that accepts an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument (to provide for the underlying C exception representation), and a bitwise copy constructor. The following is a possible implementation of a C exception wrapper class:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To use this class, you install a custom C exception translation function that is called by the internal exception handling mechanism each time a C exception is thrown. Within your translation function, you can throw any typed exception (perhaps an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type, or a class type derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) that can be caught by an appropriate matching C++ **catch** handler. The translation function can simply return, which indicates that it did not handle the exception. If the translation function itself raises a C exception, [terminate](../vs140/terminate--crt-.md) is called.  
  
 To specify a custom translation function, call the [_set_se_translator](../vs140/_set_se_translator.md) function with the name of your translation function as its single argument. The translation function that you write is called once for each function invocation on the stack that has **try** blocks. There is no default translation function; if you do not specify one by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the C exception can only be caught by an ellipsis **catch** handler.  
  
## Example  
 For example, the following code installs a custom translation function, and then raises a C exception that is wrapped by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **In trans_func.**  
**In finally**  
**Caught a __try exception with SE_Exception.**  
**nSE = 0xc0000094**   
## See Also  
 [Mixing C (Structured) and C++ Exceptions](../vs140/mixing-c--structured--and-c---exceptions.md)