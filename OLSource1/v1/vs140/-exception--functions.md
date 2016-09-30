---
title: "&lt;exception&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c09ac569-5e35-4fe8-872d-ca5810274dd7
caps.latest.revision: 10
---
# &lt;exception&gt; functions
||||  
|-|-|-|  
|[current_exception](#current_exception)|[get_terminate](#get_terminate)|[get_unexpected](#get_unexpected)|  
|[make_exception_ptr](#make_exception_ptr)|[rethrow_exception](#rethrow_exception)|[set_terminate](#set_terminate)|  
|[set_unexpected](#set_unexpected)|[terminate](#terminate)|[uncaught_exception](#uncaught_exception)|  
|[unexpected](#unexpected)|  
  
##  \<a name="current_exception">\</a>  current_exception  
 Obtains a smart pointer to the current exception.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Return Value  
 An [exception_ptr](../vs140/-exception--typedefs.md#exception_ptr) object pointing to the current exception.  
  
### Remarks  
 Call the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function in a catch block. If an exception is in flight and the catch block can catch the exception, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function returns an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object that references the exception. Otherwise, the function returns a null <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function captures the exception that is in flight regardless of whether the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement specifies an [exception-declaration](../vs140/try--throw--and-catch-statements--c---.md) statement.  
  
 The destructor for the current exception is called at the end of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> block if you do not rethrow the exception. However, even if you call the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function in the destructor, the function returns an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object that references the current exception.  
  
 Successive calls to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function return <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> objects that refer to different copies of the current exception. Consequently, the objects compare as unequal because they refer to different copies, even though the copies have the same binary value.  
  
##  \<a name="make_exception_ptr">\</a>  make_exception_ptr  
 Creates an [exception_ptr](../vs140/-exception--typedefs.md#exception_ptr) object that holds a copy of an exception.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The class with the exception to copy. Usually, you specify an [exception class](../vs140/exception-class.md) object as the argument to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function, although any class object can be the argument.  
  
### Return Value  
 An [exception_ptr](../vs140/-exception--typedefs.md#exception_ptr) object pointing to a copy of the current exception for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Remarks  
 Calling the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function is equivalent to throwing a C++ exception, catching it in a catch block, and then calling the [current_exception](../vs140/-exception--functions.md#current_exception) function to return an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object that references the exception. The Microsoft implementation of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function is more efficient than throwing and then catching an exception.  
  
 An application typically does not require the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> function, and we discourage its use.  
  
##  \<a name="rethrow_exception">\</a>  rethrow_exception  
 Throws an exception passed as a parameter.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The caught exception to re-throw. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a null [exception_ptr](../vs140/-exception--typedefs.md#exception_ptr), the function throws [std::bad_exception](../vs140/bad_exception-class.md).  
  
### Remarks  
 After you store a caught exception in an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object, the primary thread can process the object. In your primary thread, call the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function together with the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object as its argument. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> function extracts the exception from the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object and then throws the exception in the context of the primary thread.  
  
##  \<a name="get_terminate">\</a>  get_terminate  
 Obtains the current <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="set_terminate">\</a>  set_terminate  
 Establishes a new <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to be called at the termination of the program.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The function to be called at termination.  
  
### Return Value  
 The address of the previous function that used to be called at termination.  
  
### Remarks  
 The function establishes a new [terminate_handler](../vs140/-exception--typedefs.md#terminate_handler) as the function * <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> must not be a null pointer. The function returns the address of the previous terminate handler.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="get_unexpected">\</a>  get_unexpected  
 Obtains the current <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="set_unexpected">\</a>  set_unexpected  
 Establishes a new <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to be when an unexpected exception is encountered.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The function to be called when an unexpected exception is encountered.  
  
### Return Value  
 The address of the previous <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> must not be a null pointer.  
  
 The C++ Standard requires that <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is called when a function throws an exception that is not on its throw list. The current implementation does not support this. The following example calls <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> directly, which then calls the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="terminate">\</a>  terminate  
 Calls a terminate handler.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The function calls a terminate handler, a function of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. If **terminate** is called directly by the program, the terminate handler is the one most recently set by a call to [set_terminate](../vs140/-exception--functions.md#set_terminate). If **terminate** is called for any of several other reasons during evaluation of a throw expression, the terminate handler is the one in effect immediately after evaluating the throw expression.  
  
 A terminate handler may not return to its caller. At program startup, the terminate handler is a function that calls **abort**.  
  
### Example  
  See [set_unexpected](../vs140/-exception--functions.md#set_unexpected) for an example of the use of **terminate**.  
  
##  \<a name="uncaught_exception">\</a>  uncaught_exception  
 Returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> only if a thrown exception is being currently processed.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> after completing evaluation of a throw expression and before completing initialization of the exception declaration in the matching handler or calling [unexpected](../vs140/-exception--functions.md#unexpected) as a result of the throw expression. In particular, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> will return <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> when called from a destructor that is being invoked during an exception unwind. On devices, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is only supported on Windows CE 5.00 and higher versions, including Windows Mobile 2005 platforms.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **In Test::Test("outside try block")**  
**In Test::Test("inside try block")**  
**In Test::~Test("inside try block")**  
 **std::uncaught_exception( ) = 1**  
**In Test::~Test("outside try block")**  
 **std::uncaught_exception( ) = 0**    
##  \<a name="unexpected">\</a>  unexpected  
 Calls the unexpected handler.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The C++ Standard requires that <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is called when a function throws an exception that is not on its throw list. The current implementation does not support this. The example calls <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> directly, which calls the unexpected handler.  
  
 The function calls an unexpected handler, a function of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is called directly by the program, the unexpected handler is the one most recently set by a call to [set_unexpected](../vs140/-exception--functions.md#set_unexpected).  
  
 An unexpected handler may not return to its caller. It may terminate execution by:  
  
-   Throwing an object of a type listed in the exception specification or an object of any type if the unexpected handler is called directly by the program.  
  
-   Throwing an object of type [bad_exception](../vs140/bad_exception-class.md).  
  
-   Calling [terminate](../vs140/-exception--functions.md#terminate), **abort** or **exit**( <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>).  
  
 At program startup, the unexpected handler is a function that calls [terminate](../vs140/-exception--functions.md#terminate).  
  
### Example  
  See [set_unexpected](../vs140/-exception--functions.md#set_unexpected) for an example of the use of **unexpected.**  
  
## See Also  
 [&lt;exception&gt;](../vs140/-exception-.md)