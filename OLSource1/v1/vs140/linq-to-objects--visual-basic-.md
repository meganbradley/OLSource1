---
title: "LINQ to Objects (Visual Basic)"
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
ms.assetid: dd4c30bc-1c9b-4781-a482-b5eada38deb2
caps.latest.revision: 7
---
# LINQ to Objects (Visual Basic)
The term "LINQ to Objects" refers to the use of LINQ queries with any <xref:System.Collections.IEnumerable*> or <xref:System.Collections.Generic.IEnumerable`1*> collection directly, without the use of an intermediate LINQ provider or API such as [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655) or [LINQ to XML](../vs140/linq-to-xml.md). You can use LINQ to query any enumerable collections such as <xref:System.Collections.Generic.List`1*>, <xref:System.Array*>, or <xref:System.Collections.Generic.Dictionary`2*>. The collection may be user-defined or may be returned by a .NET Framework API.  
  
 In a basic sense, LINQ to Objects represents a new approach to collections. In the old way, you had to write complex `For Each` loops that specified how to retrieve data from a collection. In the LINQ approach, you write declarative code that describes what you want to retrieve.  
  
 In addition, LINQ queries offer three main advantages over traditional `For Each` loops:  
  
1.  They are more concise and readable, especially when filtering multiple conditions.  
  
2.  They provide powerful filtering, ordering, and grouping capabilities with a minimum of application code.  
  
3.  They can be ported to other data sources with little or no modification.  
  
 In general, the more complex the operation you want to perform on the data, the more benefit you will realize by using LINQ instead of traditional iteration techniques.  
  
 The purpose of this section is to demonstrate the LINQ approach with some select examples. It is not intended to be exhaustive.  
  
## In This Section  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)  
 Explains how LINQ can be used to query and transform strings and collections of strings. Also includes links to topics that demonstrate these principles.  
  
 [LINQ and Reflection (Visual Basic)](../vs140/linq-and-reflection--visual-basic-.md)  
 Links to a sample that demonstrates how LINQ uses reflection.  
  
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)  
 Explains how LINQ can be used to interact with file systems. Also includes links to topics that demonstrate these concepts.  
  
 [How to: Query an ArrayList with LINQ (Visual Basic)](../vs140/how-to--query-an-arraylist-with-linq--visual-basic-.md)  
 Demonstrates how to query an ArrayList in C#.  
  
 [How to: Add Custom Methods for LINQ Queries (Visual Basic)](../vs140/how-to--add-custom-methods-for-linq-queries--visual-basic-.md)  
 Explains how to extend the set of methods that you can use for LINQ queries by adding extension methods to the <xref:System.Collections.Generic.IEnumerable`1*> interface.  
  
 [Language-Integrated Query (LINQ) (Visual Basic)](../vs140/language-integrated-query--linq---visual-basic-.md)  
 Provides links to topics that explain LINQ and provide examples of code that perform queries.