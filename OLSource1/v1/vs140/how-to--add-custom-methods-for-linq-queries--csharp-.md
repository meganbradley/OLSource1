---
title: "How to: Add Custom Methods for LINQ Queries (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 1a500f60-2e10-49fb-8b2a-d8d08e4817cb
caps.latest.revision: 5
---
# How to: Add Custom Methods for LINQ Queries (C#)
You can extend the set of methods that you can use for LINQ queries by adding extension methods to the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1*> interface, you can apply your custom methods to any enumerable collection. For more information, see [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md).  
  
## Adding an Aggregate Method  
 An aggregate method computes a single value from a set of values. LINQ provides several aggregate methods, including \<xref:System.Linq.Enumerable.Average*>, \<xref:System.Linq.Enumerable.Min*>, and \<xref:System.Linq.Enumerable.Max*>. You can create your own aggregate method by adding an extension method to the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>double<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1*> interface.  
  
 The following code example shows how to use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method for an array of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Overloading an Aggregate Method to Accept Various Types  
 You can overload your aggregate method so that it accepts sequences of various types. The standard approach is to create an overload for each type. Another approach is to create an overload that will take a generic type and convert it to a specific type by using a delegate. You can also combine both approaches.  
  
#### To create an overload for each type  
 You can create a specific overload for each type that you want to support. The following code example shows an overload of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can now call the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> overloads for both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> types, as shown in the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
#### To create a generic overload  
 You can also create an overload that accepts a sequence of generic objects. This overload takes a delegate as a parameter and uses it to convert a sequence of objects of a generic type to a specific type.  
  
 The following code shows an overload of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method that takes the <xref:System.Func<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>double<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Group By<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>2*> delegate parameter to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method for each case.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Adding a Method That Returns a Collection  
 You can extend the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>1*>. Such methods can be used to apply filters or data transforms to a sequence of values.  
  
 The following example shows how to create an extension method named <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> that returns every other element in a collection, starting from the first element.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 You can call this extension method for any enumerable collection just as you would call other methods from the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>1*>   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)