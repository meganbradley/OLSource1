---
title: "typeid Operator"
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
  - "typeid operator"
ms.assetid: 8871cee6-d6b9-4301-a5cb-bf3dc9798d61
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typeid Operator
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator allows the type of an object to be determined at run time.  
  
 The result of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a **const type_info&**. The value is a reference to a **type_info** object that represents either the *type-id* or the type of the *expression*, depending on which form of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is used. See [type_info Class](../vs140/type_info-class.md) for more information.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator  does not work with managed types (abstract declarators or instances), see [typeid](../vs140/typeid---c---component-extensions-.md) for information on getting the \<xref:System.Type*> of a specified type.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator does a run-time check when applied to an l-value of a polymorphic class type, where the true type of the object cannot be determined by the static information provided. Such cases are:  
  
-   A reference to a class  
  
-   A pointer, dereferenced with *  
  
-   A subscripted pointer (i.e. [ ]). (Note that it is generally not safe to use a subscript with a pointer to a polymorphic type.)  
  
 If the *expression* points to a base class type, yet the object is actually of a type derived from that base class, a **type_info** reference for the derived class is the result. The *expression* must point to a polymorphic type (a class with virtual functions). Otherwise, the result is the **type_info** for the static class referred to in the *expression*. Further, the pointer must be dereferenced so that the object it points to is used. Without dereferencing the pointer, the result will be the **type_info** for the pointer, not what it points to. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the *expression* is dereferencing a pointer, and that pointer's value is zero, **typeid** throws a [bad_typeid exception](../vs140/bad_typeid-exception.md). If the pointer does not point to a valid object, a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> exception is thrown, indicating an attempt to analyze the RTTI that triggered a fault (like access violation), because the object is somehow invalid (bad pointer or the code wasn't compiled with [/GR](../vs140/-gr--enable-run-time-type-information-.md)).  
  
 If the *expression* is neither a pointer nor a reference to a base class of the object, the result is a **type_info** reference representing the static type of the *expression*. The *static type* of an expression refers to the type of an expression as it is known at compile time. Execution semantics are ignored when evaluating the static type of an expression. Furthermore, references are ignored when possible when determining the static type of an expression:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **typeid** can also be used in templates to determine the type of a template parameter:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Run-Time Type Information](../vs140/run-time-type-information.md)   
 [Keywords](../vs140/keywords--c---.md)