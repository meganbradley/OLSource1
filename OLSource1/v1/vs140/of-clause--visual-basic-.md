---
title: "Of Clause (Visual Basic)"
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
  - "Of"
  - "vb.Of"
  - "vb.of"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Of keyword"
  - "arguments [Visual Basic], data types"
  - "constraints, Visual Basic generic types"
  - "generic parameters"
  - "generics [Visual Basic], constraints"
  - "parameters, type"
  - "types [Visual Basic], generic"
  - "parameters, generic"
  - "type parameters"
  - "data type arguments"
ms.assetid: 0db8f65c-65af-4089-ab7f-6fcfecb60444
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Of Clause (Visual Basic)
Introduces an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause, which identifies a *type parameter* on a *generic* class, structure, interface, delegate, or procedure. For information on generic types, see [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md).  
  
## Using the Of Keyword  
 The following code example uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword to define the outline of a class that takes two type parameters. It *constrains* the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter by the \<xref:System.IComparable*> interface, which means the consuming code must supply a type argument that implements \<xref:System.IComparable*>. This is necessary so that the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure can call the \<xref:System.IComparable.CompareTo*?displayProperty=fullName> method. For more information on constraints, see [Type List](../vs140/type-list--visual-basic-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you complete the preceding class definition, you can construct a variety of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> classes from it. The types you supply to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> determine what type of entry the class holds and what type of key it associates with each entry. Because of the constraint, you must supply to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> a type that implements \<xref:System.IComparable*>.  
  
 The following code example creates an object that holds <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> entries and associates an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> key with each one. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implements \<xref:System.IComparable*> and therefore satisfies the constraint on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword can be used in these contexts:  
  
 [Class Statement](../vs140/class-statement--visual-basic-.md)  
  
 [Delegate Statement](../vs140/delegate-statement.md)  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)  
  
 [Structure Statement](../vs140/structure-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 \<xref:System.IComparable*>   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [in (Generic Modifier) (Visual Basic)](../vs140/in--generic-modifier---visual-basic-.md)   
 [Out (Generic Modifier) (Visual Basic)](../vs140/out--generic-modifier---visual-basic-.md)