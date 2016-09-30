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
  
 You identify a collection initializer by using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword followed by braces (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>). This is similar to the array literal syntax that is described in [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md). The following examples show various ways to use collection initializers to create collections.  
  
 [!code[VbVbalrCollectionInitializers#1](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_1.vb)]  
  
> [!NOTE]
>  C# also provides collection initializers. C# collection initializers provide the same functionality as Visual Basic collection initializers. For more information about C# collection initializers, see [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md).  
  
## Syntax  
 A collection initializer consists of a list of comma-separated values that are enclosed in braces (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), preceded by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword, as shown in the following code.  
  
 [!code[VbVbalrCollectionInitializers#2](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_2.vb)]  
  
 When you create a collection, such as a <xref:System.Collections.Generic.List<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>2*>, you must supply the collection type before the collection initializer, as shown in the following code.  
  
 [!code[VbVbalrCollectionInitializers#13](../vs140/codesnippet/VisualBasic/collection-initializers--visual-basic-_3.vb)]  
  
> [!NOTE]
>  You cannot combine both a collection initializer and an object initializer to initialize the same collection object. You can use object initializers to initialize objects in a collection initializer.  
  
## Creating a Collection by Using a Collection Intializer  
 When you create a collection by using a collection initializer, each value that is supplied in the collection initializer is passed to the appropriate <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method of the collection. For example, if you create a <xref:System.Collections.Generic.List<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1.Add*> method. If you want to create a collection by using a collection initializer, the specified type must be valid collection type. Examples of valid collection types include classes that implement the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Shared<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>List(Of Customer)<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Add(Customer)<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>{}<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>2*> in which the keys are of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and the values are of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Each of the nested value lists is matched to the <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>Dictionary<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>IEnumerable`.|  
  
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