---
title: "How to: Query an ArrayList with LINQ (Visual Basic)"
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
ms.assetid: 176358a9-d765-4b57-9557-7feb4428138d
caps.latest.revision: 7
---
# How to: Query an ArrayList with LINQ (Visual Basic)
When using LINQ to query non-generic <xref:System.Collections.IEnumerable?qualifyHint=False> collections such as <xref:System.Collections.ArrayList?qualifyHint=False>, you must explicitly declare the type of the range variable to reflect the specific type of the objects in the collection. For example, if you have an <xref:System.Collections.ArrayList?qualifyHint=False> of `Student` objects, your [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md) should look like this:  
  
```  
  
Dim query = From student As Student In arrList   
...  
  
```  
  
 By specifying the type of the range variable, you are casting each item in the <xref:System.Collections.ArrayList?qualifyHint=False> to a `Student`.  
  
 The use of an explicitly typed range variable in a query expression is equivalent to calling the <xref:System.Linq.Enumerable.Cast``1?qualifyHint=False> method. <xref:System.Linq.Enumerable.Cast``1?qualifyHint=False> throws an exception if the specified cast cannot be performed. <xref:System.Linq.Enumerable.Cast``1?qualifyHint=False> and <xref:System.Linq.Enumerable.OfType``1?qualifyHint=False> are the two Standard Query Operator methods that operate on non-generic <xref:System.Collections.IEnumerable?qualifyHint=False> types. In Visual Basic, you must explicitly call the <xref:System.Linq.Enumerable.Cast``1?qualifyHint=False> method on the data source to ensure a specific range variable type. For more information, see[Type Relationships in Query Operations (Visual Basic)](../vs140/type-relationships-in-query-operations--visual-basic-.md).  
  
## Example  
 The following example shows a simple query over an <xref:System.Collections.ArrayList?qualifyHint=False>. Note that this example uses object initializers when the code calls the <xref:System.Collections.ArrayList.Add?qualifyHint=False> method, but this is not a requirement.  
  
```vb  
Imports System.Collections  
Imports System.Linq  
  
Module Module1  
  
    Public Class Student  
        Public Property FirstName As String  
        Public Property LastName As String  
        Public Property Scores As Integer()  
    End Class  
  
    Sub Main()  
  
        Dim student1 As New Student With {.FirstName = "Svetlana",   
                                     .LastName = "Omelchenko",   
                                     .Scores = New Integer() {98, 92, 81, 60}}  
        Dim student2 As New Student With {.FirstName = "Claire",   
                                    .LastName = "O'Donnell",   
                                    .Scores = New Integer() {75, 84, 91, 39}}  
        Dim student3 As New Student With {.FirstName = "Cesar",   
                                    .LastName = "Garcia",   
                                    .Scores = New Integer() {97, 89, 85, 82}}  
        Dim student4 As New Student With {.FirstName = "Sven",   
                                    .LastName = "Mortensen",   
                                    .Scores = New Integer() {88, 94, 65, 91}}  
  
        Dim arrList As New ArrayList()  
        arrList.Add(student1)  
        arrList.Add(student2)  
        arrList.Add(student3)  
        arrList.Add(student4)  
  
        ' Use an explicit type for non-generic collections  
        Dim query = From student As Student In arrList   
                    Where student.Scores(0) > 95   
                    Select student  
  
        For Each student As Student In query  
            Console.WriteLine(student.LastName & ": " & student.Scores(0))  
        Next  
        ' Keep the console window open in debug mode.  
        Console.WriteLine("Press any key to exit.")  
        Console.ReadKey()  
    End Sub  
  
End Module  
' Output:  
'   Omelchenko: 98  
'   Garcia: 97  
```  
  
## See Also  
 [LINQ to Objects (Visual Basic)](../vs140/linq-to-objects--visual-basic-.md)