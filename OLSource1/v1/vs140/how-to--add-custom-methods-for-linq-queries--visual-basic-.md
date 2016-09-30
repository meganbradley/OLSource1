---
title: "How to: Add Custom Methods for LINQ Queries (Visual Basic)"
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
ms.assetid: 099b2e2a-83cd-45c6-aa4d-01b398b5faaf
caps.latest.revision: 7
---
# How to: Add Custom Methods for LINQ Queries (Visual Basic)
You can extend the set of methods that you can use for LINQ queries by adding extension methods to the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1*> interface, you can apply your custom methods to any enumerable collection. For more information, see [Extension Methods (Visual Basic Programming Guide)](../vs140/extension-methods--visual-basic-.md).  
  
## Adding an Aggregate Method  
 An aggregate method computes a single value from a set of values. LINQ provides several aggregate methods, including \<xref:System.Linq.Enumerable.Average*>, \<xref:System.Linq.Enumerable.Min*>, and \<xref:System.Linq.Enumerable.Max*>. You can create your own aggregate method by adding an extension method to the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>double<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1*> interface.  
  
> [!NOTE]
>  In Visual Basic, you can either use a method call or standard query syntax for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause. For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md) and [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md).  
  
 The following code example shows how to use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method for an array of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Overloading an Aggregate Method to Accept Various Types  
 You can overload your aggregate method so that it accepts sequences of various types. The standard approach is to create an overload for each type. Another approach is to create an overload that will take a generic type and convert it to a specific type by using a delegate. You can also combine both approaches.  
  
#### To create an overload for each type  
 You can create a specific overload for each type that you want to support. The following code example shows an overload of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can now call the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> overloads for both <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> types, as shown in the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
#### To create a generic overload  
 You can also create an overload that accepts a sequence of generic objects. This overload takes a delegate as a parameter and uses it to convert a sequence of objects of a generic type to a specific type.  
  
 The following code shows an overload of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method that takes the <xref:System.Func<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>double<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>Group By<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>2*> delegate parameter to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method for each case.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Adding a Method That Returns a Collection  
 You can extend the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>1*>. Such methods can be used to apply filters or data transforms to a sequence of values.  
  
 The following example shows how to create an extension method named <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> that returns every other element in a collection, starting from the first element.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 You can call this extension method for any enumerable collection just as you would call other methods from the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>1*>   
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)