---
title: "const and volatile Pointers"
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
helpviewer_keywords: 
  - "volatile keyword [C++], and pointers"
  - "pointers, and const"
  - "pointers, and volatile"
  - "const keyword [C++], volatile pointers"
ms.assetid: 0c92dc6c-400e-4342-b345-63ddfe649d7e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const and volatile Pointers
The [const](../vs140/const--c---.md) and [volatile](../vs140/volatile--c---.md) keywords change how pointers are treated. The **const** keyword specifies that the pointer cannot be modified after initialization; the pointer is protected from modification thereafter.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword specifies that the value associated with the name that follows can be modified by actions other than those in the user application. Therefore, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword is useful for declaring objects in shared memory that can be accessed by multiple processes or global data areas used for communication with interrupt service routines.  
  
 When a name is declared as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the compiler reloads the value from memory each time it is accessed by the program. This dramatically reduces the possible optimizations. However, when the state of an object can change unexpectedly, it is the only way to ensure predictable program performance.  
  
 To declare the object pointed to by the pointer as **const** or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, use a declaration of the form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To declare the value of the pointer — that is, the actual address stored in the pointer — as **const** or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, use a declaration of the form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The C++ language prevents assignments that would allow modification of an object or pointer declared as **const**. Such assignments would remove the information that the object or pointer was declared with, thereby violating the intent of the original declaration. Consider the following declarations:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Given the preceding declarations of two objects (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, of type **const char**, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, of type **char)**, the following declaration/initializations are valid:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following declaration/initializations are erroneous.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The declaration of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> declares a pointer through which a constant object might be modified and is therefore disallowed. The declaration of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specifies that the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is constant, not the object; the declaration is disallowed for the same reason the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> declaration is disallowed.  
  
 The following eight assignments show assigning through pointer and changing of pointer value for the preceding declarations; for now, assume that the initialization was correct for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointers declared as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or as a mixture of **const** and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, obey the same rules.  
  
 Pointers to **const** objects are often used in function declarations as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The preceding statement declares a function, [strcpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md), where two of the three arguments are of type pointer to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Because the arguments are passed by reference and not by value, the function would be free to modify both <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> were not declared as **const**. The declaration of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> as **const** assures the caller that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> cannot be changed by the called function.  
  
> [!NOTE]
>  Because there is a standard conversion from *typename* **\*** to **const** *typename* **\***, it is legal to pass an argument of type **char \*** to [strcpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md). However, the reverse is not true; no implicit conversion exists to remove the **const** attribute from an object or pointer.  
  
 A **const** pointer of a given type can be assigned to a pointer of the same type. However, a pointer that is not **const** cannot be assigned to a **const** pointer. The following code shows correct and incorrect assignments:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The following sample shows how to declare an object as const if you have a pointer to a pointer to an object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Pointers](../vs140/pointers--c---.md)