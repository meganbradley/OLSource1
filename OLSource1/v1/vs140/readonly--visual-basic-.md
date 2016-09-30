---
title: "ReadOnly (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ReadOnly"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ReadOnly keyword"
  - "variables [Visual Basic], read-only"
  - "ReadOnly property"
  - "properties [Visual Basic], read-only"
  - "read-only variables"
ms.assetid: e868185d-6142-4359-a2fd-a7965cadfce8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ReadOnly (Visual Basic)
Specifies that a variable or property can be read but not written.  
  
## Remarks  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> only at module level. This means the declaration context for a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element must be a class, structure, or module, and cannot be a source file, namespace, or procedure.  
  
-   **Combined Modifiers.** You cannot specify <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> together with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the same declaration.  
  
-   **Assigning a Value.** Code consuming a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property cannot set its value. But code that has access to the underlying storage can assign or change the value at any time.  
  
     You can assign a value to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable only in its declaration or in the constructor of a class or structure in which it is defined.  
  
## When to Use a ReadOnly Variable  
 There are situations in which you cannot use a [Const Statement](../vs140/const-statement--visual-basic-.md) to declare and assign a constant value. For example, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement might not accept the data type you want to assign, or you might not be able to compute the value at compile time with a constant expression. You might not even know the value at compile time. In these cases, you can use a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable to hold a constant value.  
  
> [!IMPORTANT]
>  If the data type of the variable is a reference type, such as an array or a class instance, its members can be changed even if the variable itself is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The following example illustrates this.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 When initialized, the array pointed to by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> holds "x", "y", and "z". Because the variable <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, you cannot change its value once it is initialized; that is, you cannot assign a new array to it. However, you can change the values of one or more of the array members. Following a call to the procedure <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the array pointed to by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> holds "x", "M", and "z".  
  
 Note that this is similar to declaring a procedure parameter to be [ByVal](../vs140/byval--visual-basic-.md), which prevents the procedure from changing the calling argument itself but allows it to change its members.  
  
## Example  
 The following example defines a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property for the date on which an employee was hired. The class stores the property value internally as a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variable, and only code inside the class can change that value. However, the property is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and any code that can access the class can read the property.  
  
 [!code[VbVbalrKeywords#4](../vs140/codesnippet/VisualBasic/readonly--visual-basic-_1.vb)]  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
## See Also  
 [WriteOnly](../vs140/writeonly--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)