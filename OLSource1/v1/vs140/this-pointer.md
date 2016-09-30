---
title: "this Pointer"
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
  - "this"
  - "this_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nonstatic member functions"
  - "pointers, to class instance"
  - "this pointer"
ms.assetid: 92e3256a-4ad9-4d46-8be1-d77fad90791f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# this Pointer
The **this** pointer is a pointer accessible only within the nonstatic member functions of a **class**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or **union** type. It points to the object for which the member function is called. Static member functions do not have a **this** pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An object's **this** pointer is not part of the object itself; it is not reflected in the result of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement on the object. Instead, when a nonstatic member function is called for an object, the address of the object is passed by the compiler as a hidden argument to the function. For example, the following function call:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 can be interpreted this way:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object's address is available from within the member function as the **this** pointer. Most uses of **this** are implicit. It is legal, though unnecessary, to explicitly use **this** when referring to members of the class. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The expression <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is commonly used to return the current object from a member function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The **this** pointer is also used to guard against self-reference:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
> [!NOTE]
>  Because the **this** pointer is nonmodifiable, assignments to **this** are not allowed. Earlier implementations of C++ allowed assignments to **this**.  
  
 Occasionally, the **this** pointer is used directly — for example, to manipulate self-referential data structures, where the address of the current object is required.  
  
## Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **my buffer**  
**your buffer**   
## Type of the this pointer  
 The **this** pointer's type can be modified in the function declaration by the **const** and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keywords. To declare a function as having the attributes of one or more of these keywords, add the keyword(s) after the function argument list.  
  
 Consider this example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The preceding code declares a member function, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, in which the **this** pointer is treated as a **const** pointer to a **const** object. Combinations of *cv-mod-list* options can be used, but they always modify the object pointed to by **this**, not the **this** pointer itself. Therefore, the following declaration declares function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; the **this** pointer is a **const** pointer to a **const** object:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of **this** in a member function is described by the following syntax, where *cv-qualifier-list* is determined from the member functions declarator and can be **const** or **volatile** (or both), and *class-type* is the name of the class:  
  
 *[cv-qualifier-list] class-type*  **\* const this**  
  
 In other words, **this** is always a const pointer; it cannot be reassigned.  The **const** or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> qualifiers used in the member function declaration apply to the class instance pointed to by **this** in the scope of that function.  
  
 The following table explains more about how these modifiers work.  
  
### Semantics of this Modifiers  
  
|Modifier|Meaning|  
|--------------|-------------|  
|**const**|Cannot change member data; cannot invoke member functions that are not **const**.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Member data is loaded from memory each time it is accessed; disables certain optimizations.|  
  
 It is an error to pass a **const** object to a member function that is not **const**. Similarly, it is an error to pass a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object to a member function that is not <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Member functions declared as **const** cannot change member data — in such functions, the **this** pointer is a pointer to a **const** object.  
  
> [!NOTE]
>  Constructors and destructors cannot be declared as **const** or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. They can, however, be invoked on **const** or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects.  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Type of this Pointer](../vs140/type-of-this-pointer.md)   
 [Argument Matching and the this Pointer](../vs140/argument-matching-and-the-this-pointer.md)