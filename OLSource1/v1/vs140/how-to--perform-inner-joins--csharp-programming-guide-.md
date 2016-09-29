---
title: "How to: Perform Inner Joins (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "joins [C#], inner"
  - "inner joins [LINQ in C#]"
  - "query expressions [LINQ in C#], joins"
  - "queries [LINQ in C#], joins"
ms.assetid: d9edb404-8314-413e-ae51-83bb86c7a4b5
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Perform Inner Joins (C# Programming Guide)
In relational database terms, an *inner join* produces a result set in which each element of the first collection appears one time for every matching element in the second collection. If an element in the first collection has no matching elements, it does not appear in the result set. The <xref:System.Linq.Enumerable.Join*> method, which is called by the `join` clause in C#, implements an inner join.  
  
 This topic shows you how to perform four variations of an inner join:  
  
-   A simple inner join that correlates elements from two data sources based on a simple key.  
  
-   An inner join that correlates elements from two data sources based on a *composite* key. A composite key, which is a key that consists of more than one value, enables you to correlate elements based on more than one property.  
  
-   A *multiple join* in which successive join operations are appended to each other.  
  
-   An inner join that is implemented by using a group join.  
  
## Example  
  
## Simple Key Join Example  
 The following example creates two collections that contain objects of two user-defined types, `Person` and `Pet`. The query uses the `join` clause in C# to match `Person` objects with `Pet` objects whose `Owner` is that `Person`. The `select` clause in C# defines how the resulting objects will look. In this example the resulting objects are anonymous types that consist of the owner's first name and the pet's name.  
  
 [!code[CsLINQProgJoining#1](../vs140/codesnippet/CSharp/how-to--perform-inner-joins--csharp-programming-guide-_1.cs)]  
  
 Note that the `Person` object whose `LastName` is "Huff" does not appear in the result set because there is no `Pet` object that has `Pet.Owner` equal to that `Person`.  
  
## Example  
  
## Composite Key Join Example  
 Instead of correlating elements based on just one property, you can use a composite key to compare elements based on multiple properties. To do this, specify the key selector function for each collection to return an anonymous type that consists of the properties you want to compare. If you label the properties, they must have the same label in each key's anonymous type. The properties must also appear in the same order.  
  
 The following example uses a list of `Employee` objects and a list of `Student` objects to determine which employees are also students. Both of these types have a `FirstName` and a `LastName` property of type <xref:System.String*>. The functions that create the join keys from each list's elements return an anonymous type that consists of the `FirstName` and `LastName` properties of each element. The join operation compares these composite keys for equality and returns pairs of objects from each list where both the first name and the last name match.  
  
 [!code[CsLINQProgJoining#2](../vs140/codesnippet/CSharp/how-to--perform-inner-joins--csharp-programming-guide-_2.cs)]  
  
## Example  
  
## Multiple Join Example  
 Any number of join operations can be appended to each other to perform a multiple join. Each `join` clause in C# correlates a specified data source with the results of the previous join.  
  
 The following example creates three collections: a list of `Person` objects, a list of `Cat` objects, and a list of `Dog` objects.  
  
 The first `join` clause in C# matches people and cats based on a `Person` object matching `Cat.Owner`. It returns a sequence of anonymous types that contain the `Person` object and `Cat.Name`.  
  
 The second `join` clause in C# correlates the anonymous types returned by the first join with `Dog` objects in the supplied list of dogs, based on a composite key that consists of the `Owner` property of type `Person`, and the first letter of the animal's name. It returns a sequence of anonymous types that contain the `Cat.Name` and `Dog.Name` properties from each matching pair. Because this is an inner join, only those objects from the first data source that have a match in the second data source are returned.  
  
 [!code[CsLINQProgJoining#3](../vs140/codesnippet/CSharp/how-to--perform-inner-joins--csharp-programming-guide-_3.cs)]  
  
## Example  
  
## Inner Join by using Grouped Join Example  
 The following example shows you how to implement an inner join by using a group join.  
  
 In `query1`, the list of `Person` objects is group-joined to the list of `Pet` objects based on the `Person` matching the `Pet.Owner` property. The group join creates a collection of intermediate groups, where each group consists of a `Person` object and a sequence of matching `Pet` objects.  
  
 By adding a second `from` clause to the query, this sequence of sequences is combined (or flattened) into one longer sequence. The type of the elements of the final sequence is specified by the `select` clause. In this example, that type is an anonymous type that consists of the `Person.FirstName` and `Pet.Name` properties for each matching pair.  
  
 The result of `query1` is equivalent to the result set that would have been obtained by using the `join` clause without the `into` clause to perform an inner join. The `query2` variable demonstrates this equivalent query.  
  
 [!code[CsLINQProgJoining#4](../vs140/codesnippet/CSharp/how-to--perform-inner-joins--csharp-programming-guide-_4.cs)]  
  
## Compiling the Code  
  
-   Create a new Console Application project in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)].  
  
-   Add a reference to System.Core.dll if it is not already referenced.  
  
-   Include the <xref:System.Linq*> namespace.  
  
-   Copy and paste the code from the example into the program.cs file, below the `Main` method. Add a line of code to the `Main` method to call the method you pasted in.  
  
-   Run the program.  
  
## See Also  
 <xref:System.Linq.Enumerable.Join*>   
 <xref:System.Linq.Enumerable.GroupJoin*>   
 [Joining](../vs140/join-operations.md)   
 [How to: Perform a Grouped Join](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md)   
 [How to: Perform a Left Outer Join](../vs140/how-to--perform-left-outer-joins--csharp-programming-guide-.md)   
 [How to: Join Two Collections (C#) LINQ to XML](../vs140/how-to--join-two-collections--csharp---linq-to-xml-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)