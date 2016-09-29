---
title: "How to: Find the Set Difference Between Two Lists (LINQ) (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: b5b25474-10a8-4df6-aab5-75621bb6b68e
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# How to: Find the Set Difference Between Two Lists (LINQ) (Visual Basic)
This example shows how to use LINQ to compare two lists of strings and output those lines that are in names1.txt but not in names2.txt.  
  
### To create the data files  
  
1.  Copy names1.txt and names2.txt to your solution folder as shown in [How to: Combine and Compare String Collections (LINQ) (Visual Basic)](../vs140/how-to--combine-and-compare-string-collections--linq---visual-basic-.md).  
  
## Example  
  
```vb  
Class CompareLists  
  
    Shared Sub Main()  
  
        ' Create the IEnumerable data sources.  
        Dim names1 As String() = System.IO.File.ReadAllLines("../../../names1.txt")  
        Dim names2 As String() = System.IO.File.ReadAllLines("../../../names2.txt")  
  
        ' Create the query. Note that method syntax must be used here.  
        Dim differenceQuery = names1.Except(names2)  
        Console.WriteLine("The following lines are in names1.txt but not names2.txt")  
  
        ' Execute the query.  
        For Each name As String In differenceQuery  
            Console.WriteLine(name)  
        Next  
  
        ' Keep console window open in debug mode.  
        Console.WriteLine("Press any key to exit.")  
        Console.ReadKey()  
    End Sub  
End Class  
' Output:  
' The following lines are in names1.txt but not names2.txt  
' Potra, Cristina  
' Noriega, Fabricio  
' Aw, Kam Foo  
' Toyoshima, Tim  
' Guy, Wey Yuan  
' Garcia, Debra  
```  
  
 Some types of query operations in Visual Basic, such as <xref:System.Linq.Enumerable.Except*>, <xref:System.Linq.Enumerable.Distinct*>, <xref:System.Linq.Enumerable.Union*>, and <xref:System.Linq.Enumerable.Concat*>, can only be expressed in method-based syntax.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a `Imports` statement for the System.Linq namespace.  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)