---
title: "Variance in Generic Interfaces (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
ms.assetid: cf4096d0-4bb3-45a9-9a6b-f01e29a60333
caps.latest.revision: 3
---
# Variance in Generic Interfaces (Visual Basic)
.NET Framework 4 introduced variance support for several existing generic interfaces. Variance support enables implicit conversion of classes that implement these interfaces. The following interfaces are now variant:  
  
-   <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> (T is covariant)  
  
-   <xref:System.Collections.Generic.IEnumerator`1?qualifyHint=False> (T is covariant)  
  
-   <xref:System.Linq.IQueryable`1?qualifyHint=False> (T is covariant)  
  
-   <xref:System.Linq.IGrouping`2?qualifyHint=False> (`TKey` and `TElement` are covariant)  
  
-   <xref:System.Collections.Generic.IComparer`1?qualifyHint=False> (T is contravariant)  
  
-   <xref:System.Collections.Generic.IEqualityComparer`1?qualifyHint=False> (T is contravariant)  
  
-   <xref:System.IComparable`1?qualifyHint=False> (T is contravariant)  
  
 Covariance permits a method to have a more derived return type than that defined by the generic type parameter of the interface. To illustrate the covariance feature, consider these generic interfaces: `IEnumerable(Of Object)` and `IEnumerable(Of String)`. The `IEnumerable(Of String)` interface does not inherit the `IEnumerable(Of Object)` interface. However, the `String` type does inherit the `Object` type, and in some cases you may want to assign objects of these interfaces to each other. This is shown in the following code example.  
  
```vb  
Dim strings As IEnumerable(Of String) = New List(Of String)  
Dim objects As IEnumerable(Of Object) = strings  
```  
  
 In earlier versions of the .NET Framework, this code causes a compilation error in Visual Basic with `Option Strict On`. But now you can use `strings` instead of `objects`, as shown in the previous example, because the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface is covariant.  
  
 Contravariance permits a method to have argument types that are less derived than that specified by the generic parameter of the interface. To illustrate contravariance, assume that you have created a `BaseComparer` class to compare instances of the `BaseClass` class. The `BaseComparer` class implements the `IEqualityComparer(Of BaseClass)` interface. Because the <xref:System.Collections.Generic.IEqualityComparer`1?qualifyHint=False> interface is now contravariant, you can use `BaseComparer` to compare instances of classes that inherit the `BaseClass` class. This is shown in the following code example.  
  
```vb  
' Simple hierarchy of classes.  
Class BaseClass  
End Class  
  
Class DerivedClass  
    Inherits BaseClass  
End Class  
  
' Comparer class.  
Class BaseComparer  
    Implements IEqualityComparer(Of BaseClass)  
  
    Public Function Equals1(ByVal x As BaseClass,  
                            ByVal y As BaseClass) As Boolean _  
                            Implements IEqualityComparer(Of BaseClass).Equals  
        Return (x.Equals(y))  
    End Function  
  
    Public Function GetHashCode1(ByVal obj As BaseClass) As Integer _  
        Implements IEqualityComparer(Of BaseClass).GetHashCode  
        Return obj.GetHashCode  
    End Function  
End Class  
Sub Test()  
    Dim baseComparer As IEqualityComparer(Of BaseClass) = New BaseComparer  
    ' Implicit conversion of IEqualityComparer(Of BaseClass) to   
    ' IEqualityComparer(Of DerivedClass).  
    Dim childComparer As IEqualityComparer(Of DerivedClass) = baseComparer  
End Sub  
```  
  
 For more examples, see [Using Variance in Interfaces for Generic Collections (Visual Basic)](../vs140/using-variance-in-interfaces-for-generic-collections--visual-basic-.md).  
  
 Variance in generic interfaces is supported for reference types only. Value types do not support variance. For example, `IEnumerable(Of Integer)` cannot be implicitly converted to `IEnumerable(Of Object)`, because integers are represented by a value type.  
  
```vb  
Dim integers As IEnumerable(Of Integer) = New List(Of Integer)  
' The following statement generates a compiler error  
' with Option Strict On, because Integer is a value type.  
' Dim objects As IEnumerable(Of Object) = integers  
```  
  
 It is also important to remember that classes that implement variant interfaces are still invariant. For example, although <xref:System.Collections.Generic.List`1?qualifyHint=False> implements the covariant interface <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>, you cannot implicitly convert `List(Of Object)` to `List(Of String)`. This is illustrated in the following code example.  
  
```vb  
' The following statement generates a compiler error  
' because classes are invariant.  
' Dim list As List(Of Object) = New List(Of String)  
  
' You can use the interface object instead.  
Dim listObjects As IEnumerable(Of Object) = New List(Of String)  
```  
  
## See Also  
 [Using Variance in Interfaces for Generic Collections (Visual Basic)](../vs140/using-variance-in-interfaces-for-generic-collections--visual-basic-.md)   
 [Creating Variant Generic Interfaces (Visual Basic)](../vs140/creating-variant-generic-interfaces--visual-basic-.md)   
 [Generic Interfaces](assetId:///88bf5b04-d371-4edb-ba38-01ec7cabaacf)   
 [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md)