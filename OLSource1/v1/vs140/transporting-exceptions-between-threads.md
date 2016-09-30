---
title: "Transporting Exceptions Between Threads"
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
  - "std::current_exception"
  - "transporting exceptions between threads"
  - "std::copy_exception"
  - "exception_ptr"
  - "std::exception_ptr"
  - "std::rethrow_exception"
  - "current_exception"
  - "transport exceptions between threads"
  - "copy_exception"
  - "rethrow_exception"
  - "move exceptions between threads"
ms.assetid: 5c95d57b-acf5-491f-8122-57c5df0edd98
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Transporting Exceptions Between Threads
Visual C++ supports *transporting an exception* from one thread to another. Transporting exceptions enables you to catch an exception in one thread and then make the exception appear to be thrown in a different thread. For example, you can use this feature to write a multithreaded application where the primary thread handles all the exceptions thrown by its secondary threads. Transporting exceptions is useful mostly to developers who create parallel programming libraries or systems. To implement transporting exceptions, Visual C++ provides the [exception_ptr](../vs140/exception_ptr.md) type and the [current_exception](../vs140/current_exception.md), [rethrow_exception](../vs140/rethrow_exception.md), and [make_exception_ptr](../vs140/make_exception_ptr.md) functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|An unspecified internal class that is used to implement the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that references an exception.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|A class that represents an exception.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|An instance of the parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class.|  
  
## Return Value  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object that references the exception that is currently in progress. If no exception is in progress, the function returns an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that is not associated with any exception.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object that references the exception specified by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.  
  
## Remarks  
  
## Scenario  
 Imagine that you want to create an application that can scale to handle a variable amount of work. To achieve this objective, you design a multithreaded application where an initial, primary thread creates as many secondary threads as it needs in order to do the job. The secondary threads help the primary thread to manage resources, to balance loads, and to improve throughput. By distributing the work, the multithreaded application performs better than a single-threaded application.  
  
 However, if a secondary thread throws an exception, you want the primary thread to handle it. This is because you want your application to handle exceptions in a consistent, unified manner regardless of the number of secondary threads.  
  
## Solution  
 To handle the previous scenario, the C++ Standard supports transporting an exception between threads. If a secondary thread throws an exception, that exception becomes the *current exception*. By analogy to the real world, the current exception is said to be *in flight*. The current exception is in flight from the time it is thrown until the exception handler that catches it returns.  
  
 The secondary thread can catch the current exception in a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block, and then call the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function to store the exception in an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object must be available to the secondary thread and to the primary thread. For example, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object can be a global variable whose access is controlled by a mutex. The term *transport an exception* means an exception in one thread can be converted to a form that can be accessed by another thread.  
  
 Next, the primary thread calls the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function, which extracts and then throws the exception from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object. When the exception is thrown, it becomes the current exception in the primary thread. That is, the exception appears to originate in the primary thread.  
  
 Finally, the primary thread can catch the current exception in a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block and then process it or throw it to a higher level exception handler. Or, the primary thread can ignore the exception and allow the process to end.  
  
 Most applications do not have to transport exceptions between threads. However, this feature is useful in a parallel computing system because the system can divide work among secondary threads, processors, or cores. In a parallel computing environment, a single, dedicated thread can handle all the exceptions from the secondary threads and can present a consistent exception-handling model to any application.  
  
 For more information about the C++ Standards committee proposal, search the Internet for document number N2179, titled "Language Support for Transporting Exceptions between Threads".  
  
## Exception-Handling Models and Compiler Options  
 Your application's exception-handling model determines whether it can catch and transport an exception. Visual C++ supports three models that can handle C++ exceptions, structured exception handling (SEH) exceptions, and common language runtime (CLR) exceptions. Use the [/EH](../vs140/-eh--exception-handling-model-.md) and [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler options to specify your application's exception-handling model.  
  
 Only the following combination of compiler options and programming statements can transport an exception. Other combinations either cannot catch exceptions, or can catch but cannot transport exceptions.  
  
-   The **/EHa** compiler option and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement can transport SEH and C++ exceptions.  
  
-   The **/EHa**, **/EHs**, and **/EHsc** compiler options and the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement can transport C++ exceptions.  
  
-   The **/CLR** or **/CLR:pure** compiler option and the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement can transport C++ exceptions. The **/CLR** compiler options imply specification of the **/EHa** option. Note that the compiler does not support transporting managed exceptions. This is because managed exceptions, which are derived from the [System.Exception](https://msdn.microsoft.com/en-us/library/system.exception.aspx) class, are already objects that you can move between threads by using the facilities of the common languange runtime.  
  
    > [!IMPORTANT]
    >  We recommend that you specify the **/EHsc** compiler option and catch only C++ exceptions. You expose yourself to a security threat if you use the **/EHa** or **/CLR** compiler option and a **catch** statement with an ellipsis *exception-declaration* (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>). You probably intend to use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement to capture a few specific exceptions. However, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement captures all C++ and SEH exceptions, including unexpected ones that should be fatal. If you ignore or mishandle an unexpected exception, malicious code can use that opportunity to undermine the security of your program.  
  
## Usage  
 The following sections describe how to transport exceptions by using the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> type, and the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions.  
  
### exception_ptr Type  
 Use an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object to reference the current exception or an instance of a user-specified exception. In the Microsoft implementation, an exception is represented by an [EXCEPTION_RECORD](http://msdn.microsoft.com/library/windows/desktop/aa363082) structure. Each <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object includes an exception reference field that points to a copy of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> structure that represents the exception.  
  
 When you declare an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> variable, the variable is not associated with any exception. That is, its exception reference field is NULL. Such an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object is called a *null exception_ptr*.  
  
 Use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function to assign an exception to an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object. When you assign an exception to an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> variable, the variable's exception reference field points to a copy of the exception. If there is insufficient memory to copy the exception, the exception reference field points to a copy of a [std::bad_alloc](../vs140/bad_alloc-class.md) exception. If the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function cannot copy the exception for any other reason, the function calls the [terminate (CRT)](../vs140/terminate--crt-.md) function to exit the current process.  
  
 Despite its name, an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object is not itself a pointer. It does not obey pointer semantics and cannot be used with the pointer member access (<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>) or indirection (*) operators. The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object has no public data members or member functions.  
  
 **Comparisons:**  
  
 You can use the equal (<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>) and not-equal (<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>) operators to compare two <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> objects. The operators do not compare the binary value (bit pattern) of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> structures that represent the exceptions. Instead, the operators compare the addresses in the exception reference field of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects. Consequently, a null <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and the NULL value compare as equal.  
  
### current_exception Function  
 Call the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> function in a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> block. If an exception is in flight and the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> block can catch the exception, the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object that references the exception. Otherwise, the function returns a null <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
 **Details:**  
  
 The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> function captures the exception that is in flight regardless of whether the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statement specifies an [exception-declaration](../vs140/try--throw--and-catch-statements--c---.md) statement.  
  
 The destructor for the current exception is called at the end of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> block if you do not rethrow the exception. However, even if you call the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> function in the destructor, the function returns an <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object that references the current exception.  
  
 Successive calls to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> function return <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> objects that refer to different copies of the current exception. Consequently, the objects compare as unequal because they refer to different copies, even though the copies have the same binary value.  
  
 **SEH Exceptions:**  
  
 If you use the **/EHa** compiler option, you can catch an SEH exception in a C++ <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> block. The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object that references the SEH exception. And the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> function throws the SEH exception if you call it with thetransported <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object as its argument.  
  
 The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> function returns a null <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if you call it in an SEH <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> termination handler, an <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> exception handler, or the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> filter expression.  
  
 A transported exception does not support nested exceptions. A nested exception occurs if another exception is thrown while an exception is being handled. If you catch a nested exception, the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> data member points to a chain of <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> structures that describe the associated exceptions. The <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> function does not support nested exceptions because it returns an <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object whose <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> data member is zeroed out.  
  
 If you catch an SEH exception, you must manage the memory referenced by any pointer in the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> data member array. You must guarantee that the memory is valid during the lifetime of the corresponding <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object, and that the memory is freed when the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object is deleted.  
  
 You can use structured exception (SE) translator functions together with the transport exceptions feature. If an SEH exception is translated to a C++ exception, the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> that references the translated exception instead of the original SEH exception. The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> function subsequently throws the translated exception, not the original exception. For more information about SE translator functions, see [_set_se_translator](../vs140/_set_se_translator.md).  
  
### rethrow_exception Function  
 After you store a caught exception in an <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object, the primary thread can process the object. In your primary thread, call the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> function together with the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object as its argument. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> function extracts the exception from the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object and then throws the exception in the context of the primary thread. If the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> function is a null <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, the function throws [std::bad_exception](../vs140/bad_exception-class.md).  
  
 The extracted exception is now the current exception in the primary thread, and you can handle it as you would any other exception. If you catch the exception, you can handle it immediately or use a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> statement to send it to a higher level exception handler. Otherwise, do nothing and let the default system exception handler terminate your process.  
  
### make_exception_ptr Function  
 The <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> function takes an instance of a class as its argument and then returns an <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> that references the instance. Usually, you specify an [exception class](../vs140/exception-class.md) object as the argument to the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> function, although any class object can be the argument.  
  
 Calling the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> function is equivalent to throwing a C++ exception, catching it in a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> block, and then calling the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> function to return an <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object that references the exception. The Microsoft implementation of the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> function is more efficient than throwing and then catching an exception.  
  
 An application typically does not require the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> function, and we discourage its use.  
  
## Example  
 The following example transports a standard C++ exception and a custom C++ exception from one thread to another.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **exception_ptr 0: Caught an invalid_argument exception.**  
**exception_ptr 1: Caught a  myException exception.**   
## Requirements  
 **Header:** \<exception>  
  
## See Also  
 [Exception Handling in Visual C++](../vs140/exception-handling-in-visual-c--.md)   
 [EXCEPTION_RECORD Structure](#base.exception_record_str)   
 [Handler Syntax](#base.handler_syntax)   
 [/EH (Exception Handling Model)](../vs140/-eh--exception-handling-model-.md)   
 [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)