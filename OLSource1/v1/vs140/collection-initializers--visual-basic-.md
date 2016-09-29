---
title: "Collection Initializers (Visual Basic)"
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
  - "vb.CollectionInitializer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "collection initializers [Visual Basic]"
ms.assetid: a9290329-77b0-4fdf-ae75-8fc17287f469
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collection Initializers (Visual Basic)
*Collection initializers* provide a shortened syntax that enables you to create a collection and populate it with an initial set of values. Collection initializers are useful when you are creating a collection from a set of known values, for example, a list of menu options or categories, an initial set of numeric values, a static list of strings such as day or month names, or geographic locations such as a list of states that is used for validation.  
  
 For more information about collections, see [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md).  
  
 You identify a collection initializer by using the `From` keyword followed by braces (`{}`). This is similar to the array literal syntax that is described in [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md). The following examples show various ways to use collection initializers to create collections.  
  
 [!code[VbVbalrCollectionInitializers#1](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_1.vb)]  
  
> [!NOTE]
>  C# also provides collection initializers. C# collection initializers provide the same functionality as Visual Basic collection initializers. For more information about C# collection initializers, see [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md).  
  
## Syntax  
 A collection initializer consists of a list of comma-separated values that are enclosed in braces (`{}`), preceded by the `From` keyword, as shown in the following code.  
  
 [!code[VbVbalrCollectionInitializers#2](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_2.vb)]  
  
 When you create a collection, such as a <xref:System.Collections.Generic.List`1*> or a <xref:System.Collections.Generic.Dictionary`2*>, you must supply the collection type before the collection initializer, as shown in the following code.  
  
 [!code[VbVbalrCollectionInitializers#13](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_3.vb)]  
  
> [!NOTE]
>  You cannot combine both a collection initializer and an object initializer to initialize the same collection object. You can use object initializers to initialize objects in a collection initializer.  
  
## Creating a Collection by Using a Collection Intializer  
 When you create a collection by using a collection initializer, each value that is supplied in the collection initializer is passed to the appropriate `Add` method of the collection. For example, if you create a <xref:System.Collections.Generic.List`1*> by using a collection initializer, each string value in the collection initializer is passed to the <xref:System.Collections.Generic.List`1.Add*> method. If you want to create a collection by using a collection initializer, the specified type must be valid collection type. Examples of valid collection types include classes that implement the <xref:System.Collections.Generic.IEnumerable`1*> interface or inherit the <xref:System.Collections.CollectionBase*> class. The specified type must also expose an `Add` method that meets the following criteria.  
  
-   The `Add` method must be available from the scope in which the collection initializer is being called. The `Add` method does not have to be public if you are using the collection initializer in a scenario where non-public methods of the collection can be accessed.  
  
-   The `Add` method must be an instance member or `Shared` member of the collection class, or an extension method.  
  
-   An `Add` method must exist that can be matched, based on overload resolution rules, to the types that are supplied in the collection initializer.  
  
 For example, the following code example shows how to create a `List(Of Customer)` collection by using a collection initializer. When the code is run, each `Customer` object is passed to the `Add(Customer)` method of the generic list.  
  
 [!code[VbVbalrCollectionInitializers#9](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_4.vb)]  
  
 The following code example shows equivalent code that does not use a collection initializer.  
  
 [!code[VbVbalrCollectionInitializers#10](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_5.vb)]  
  
 If the collection has an `Add` method that has parameters that match the constructor for the `Customer` object, you could nest parameter values for the `Add` method within collection initializers, as discussed in the next section. If the collection does not have such an `Add` method, you can create one as an extension method. For an example of how to create an `Add` method as an extension method for a collection, see [How to: Create an Add Extension Method Used by a Collection Initializer](../vs140/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-.md). For an example of how to create a custom collection that can be used with a collection initializer, see [How to: Create a Collection Used by a Collection Initializer](../vs140/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-.md).  
  
## Nesting Collection Initializers  
 You can nest values within a collection initializer to identify a specific overload of an `Add` method for the collection that is being created. The values passed to the `Add` method must be separated by commas and enclosed in braces (`{}`), like you would do in an array literal or collection initializer.  
  
 When you create a collection by using nested values, each element of the nested value list is passed as an argument to the `Add` method that matches the element types. For example, the following code example creates a <xref:System.Collections.Generic.Dictionary`2*> in which the keys are of type `Integer` and the values are of type `String`. Each of the nested value lists is matched to the <xref:System.Collections.Generic.Dictionary`2.Add*> method for the `Dictionary`.  
  
 [!code[VbVbalrCollectionInitializers#5](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_6.vb)]  
  
 The previous code example is equivalent to the following code.  
  
 [!code[VbVbalrCollectionInitializers#6](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_7.vb)]  
  
 Only nested value lists from the first level of nesting are sent to the `Add` method for the collection type. Deeper levels of nesting are treated as array literals and the nested value lists are not matched to the `Add` method of any collection.  
  
## Related Topics  
  
|||  
|-|-|  
|Title|Description|  
|[How to: Create an Add Extension Method Used by a Collection Initializer (Visual Basic)](../vs140/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-.md)|Shows how to create an extension method called `Add` that can be used to populate a collection with values from a collection initializer.|  
|[How to: Create a Collection Used by a Collection Initializer (Visual Basic)](../vs140/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-.md)|Shows how to enable use of a collection initializer by including an `Add` method in a collection class that implements `IEnumerable`.|  
  
## See Also  
 [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)   
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [Auto-Implemented Properties](../vs140/auto-implemented-properties--visual-basic-.md)   
 [How to: Initialize an Array Variable](../vs140/how-to--initialize-an-array-variable-in-visual-basic.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Anonymous types](../vs140/anonymous-types--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [How to: Create a List of Items](../vs140/how-to--create-a-list-of-items.md)