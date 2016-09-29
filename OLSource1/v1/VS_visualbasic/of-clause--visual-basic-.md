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
Introduces an `Of` clause, which identifies a *type parameter* on a *generic* class, structure, interface, delegate, or procedure. For information on generic types, see [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md).  
  
## Using the Of Keyword  
 The following code example uses the `Of` keyword to define the outline of a class that takes two type parameters. It *constrains* the `keyType` parameter by the <xref:System.IComparable*> interface, which means the consuming code must supply a type argument that implements <xref:System.IComparable*>. This is necessary so that the `add` procedure can call the <xref:System.IComparable.CompareTo*?displayProperty=fullName> method. For more information on constraints, see [Type List](../VS_csharp/type-list--visual-basic-.md).  
  
```  
Public Class Dictionary(Of entryType, keyType As IComparable)  
    Public Sub add(ByVal e As entryType, ByVal k As keyType)  
        Dim dk As keyType  
        If k.CompareTo(dk) = 0 Then  
        End If  
    End Sub  
    Public Function find(ByVal k As keyType) As entryType  
    End Function  
End Class  
```  
  
 If you complete the preceding class definition, you can construct a variety of `dictionary` classes from it. The types you supply to `entryType` and `keyType` determine what type of entry the class holds and what type of key it associates with each entry. Because of the constraint, you must supply to `keyType` a type that implements <xref:System.IComparable*>.  
  
 The following code example creates an object that holds `String` entries and associates an `Integer` key with each one. `Integer` implements <xref:System.IComparable*> and therefore satisfies the constraint on `keyType`.  
  
```  
Dim d As New dictionary(Of String, Integer)  
```  
  
 The `Of` keyword can be used in these contexts:  
  
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)  
  
 [Delegate Statement](../VS_csharp/delegate-statement.md)  
  
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_csharp/interface-statement--visual-basic-.md)  
  
 [Structure Statement](../VS_csharp/structure-statement.md)  
  
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 <xref:System.IComparable*>   
 [Type List](../VS_csharp/type-list--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md)   
 [in (Generic Modifier) (Visual Basic)](../VS_csharp/in--generic-modifier---visual-basic-.md)   
 [Out (Generic Modifier) (Visual Basic)](../VS_csharp/out--generic-modifier---visual-basic-.md)