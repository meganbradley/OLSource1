---
title: "exception_ptr"
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
ms.assetid: d39e329e-52d5-49be-8b4b-479e65833dc7
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exception_ptr
A type that describes a pointer to an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An unspecified internal class that is used to implement the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type.  
  
 Use an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to reference the current exception or an instance of a user-specified exception. In the Microsoft implementation, an exception is represented by an [EXCEPTION_RECORD](http://msdn.microsoft.com/library/windows/desktop/aa363082) structure. Each <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object includes an exception reference field that points to a copy of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure that represents the exception.  
  
 When you declare an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable, the variable is not associated with any exception. That is, its exception reference field is NULL. Such an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is called a *null exception_ptr*.  
  
 Use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function to assign an exception to an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. When you assign an exception to an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable, the variable's exception reference field points to a copy of the exception. If there is insufficient memory to copy the exception, the exception reference field points to a copy of a [std::bad_alloc](../vs140/bad_alloc-class.md) exception. If the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function cannot copy the exception for any other reason, the function calls the [terminate (CRT)](../vs140/terminate--crt-.md) function to exit the current process.  
  
 Despite its name, an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is not itself a pointer. It does not obey pointer semantics and cannot be used with the pointer member access (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) or indirection (*) operators. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object has no public data members or member functions.  
  
 **Comparisons:**  
  
 You can use the equal (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) and not-equal (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) operators to compare two <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects. The operators do not compare the binary value (bit pattern) of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structures that represent the exceptions. Instead, the operators compare the addresses in the exception reference field of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects. Consequently, a null <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and the NULL value compare as equal.  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)