---
title: "&lt;exception&gt; typedefs"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2a338480-35e2-46f7-b223-52d4e84a5768
caps.latest.revision: 9
---
# &lt;exception&gt; typedefs
||||  
|-|-|-|  
|[exception_ptr](#exception_ptr)|[terminate_handler](#terminate_handler)|[unexpected_handler](#unexpected_handler)|  
  
##  \<a name="exception_ptr">\</a>  exception_ptr  
 A type that describes a pointer to an exception.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 An unspecified internal class that is used to implement the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type.  
  
 Use an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to reference the current exception or an instance of a user-specified exception. In the Microsoft implementation, an exception is represented by an                         [EXCEPTION_RECORD](http://msdn.microsoft.com/library/windows/desktop/aa363082) structure. Each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object includes an exception reference field that points to a copy of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure that represents the exception.  
  
 When you declare an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable, the variable is not associated with any exception. That is, its exception reference field is NULL. Such an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is called a *null exception_ptr*.  
  
 Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function to assign an exception to an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object. When you assign an exception to an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> variable, the variable's exception reference field points to a copy of the exception. If there is insufficient memory to copy the exception, the exception reference field points to a copy of a [std::bad_alloc](../vs140/bad_alloc-class.md) exception. If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function cannot copy the exception for any other reason, the function calls the [terminate (CRT)](../vs140/terminate--crt-.md) function to exit the current process.  
  
 Despite its name, an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object is not itself a pointer. It does not obey pointer semantics and cannot be used with the pointer member access ( <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) or indirection (*) operators. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object has no public data members or member functions.  
  
 **Comparisons:**  
  
 You can use the equal ( <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) and not-equal ( <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) operators to compare two <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects. The operators do not compare the binary value (bit pattern) of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structures that represent the exceptions. Instead, the operators compare the addresses in the exception reference field of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> objects. Consequently, a null <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and the NULL value compare as equal.  
  
##  \<a name="terminate_handler">\</a>  terminate_handler  
 The type describes a pointer to a function suitable for use as a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a pointer to a function suitable for use as a terminate handler.  
  
### Example  
  See [set_terminate](../vs140/-exception--functions.md#set_terminate) for an example of the use of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
##  \<a name="unexpected_handler">\</a>  unexpected_handler  
 The type describes a pointer to a function suitable for use as an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
  See [set_unexpected](../vs140/-exception--functions.md#set_unexpected) for an example of the use of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;exception&gt;](../vs140/-exception-.md)