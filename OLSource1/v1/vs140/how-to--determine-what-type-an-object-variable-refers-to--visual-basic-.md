---
title: "How to: Determine What Type an Object Variable Refers To (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "TypeOf operator [Visual Basic], determining object variable type"
  - "variables [Visual Basic], object"
  - "object variables, determining type"
ms.assetid: 6f6a138d-58a4-40d1-9f4e-0a3c598eaf81
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine What Type an Object Variable Refers To (Visual Basic)
An object variable contains a pointer to data that is stored elsewhere. The type of that data can change during run time. At any moment, you can use the \<xref:System.Type.GetTypeCode*> method to determine the current run-time type, or the [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md) to find out if the current run-time type is compatible with a specified type.  
  
### To determine the exact type an object variable currently refers to  
  
1.  On the object variable, call the \<xref:System.Object.GetType*> method to retrieve a \<xref:System.Type*?displayProperty=fullName> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  On the \<xref:System.Type*?displayProperty=fullName> class, call the shared method \<xref:System.Type.GetTypeCode*> to retrieve the \<xref:System.TypeCode*> enumeration value for the object's type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You can test the \<xref:System.TypeCode*> enumeration value against whichever enumeration members are of interest, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
### To determine whether an object variable's type is compatible with a specified type  
  
-   Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator in combination with the [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md) to test the object with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the object's run-time type is compatible with the specified type.  
  
     The criterion for compatibility depends on whether the specified type is a class, structure, or interface. In general, the types are compatible if the object is of the same type as, inherits from, or implements the specified type. For more information, see [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md).  
  
## Compiling the Code  
 Note that the specified type cannot be a variable or expression. It must be the name of a defined type, such as a class, structure, or interface. This includes intrinsic types such as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.Object.GetType*>   
 \<xref:System.Type*?displayProperty=fullName>   
 \<xref:System.Type.GetTypeCode*>   
 \<xref:System.TypeCode*>   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)