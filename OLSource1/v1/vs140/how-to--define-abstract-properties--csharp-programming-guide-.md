---
title: "How to: Define Abstract Properties (C# Programming Guide)"
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
  - "properties [C#], abstract"
  - "abstract properties [C#]"
ms.assetid: 672a90eb-47b9-4ae0-9914-af53852fddcb
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define Abstract Properties (C# Programming Guide)
The following example shows how to define [abstract](../vs140/abstract--csharp-reference-.md) properties. An abstract property declaration does not provide an implementation of the property accessors -- it declares that the class supports properties, but leaves the accessor implementation to derived classes. The following example demonstrates how to implement the abstract properties inherited from a base class.  
  
 This sample consists of three files, each of which is compiled individually and its resulting assembly is referenced by the next compilation:  
  
-   abstractshape.cs: the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class that contains an abstract <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property.  
  
-   shapes.cs: The subclasses of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class.  
  
-   shapetest.cs: A test program to display the areas of some <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived objects.  
  
 To compile the example, use the following command:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 This will create the executable file shapetest.exe.  
  
## Example  
 This file declares the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class that contains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> property of the type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideInheritance#1](../vs140/codesnippet/CSharp/how-to--define-abstract-properties--csharp-programming-guide-_1.cs)]  
  
-   Modifiers on the property are placed on the property declaration itself. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   When declaring an abstract property (such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in this example), you simply indicate what property accessors are available, but do not implement them. In this example, only a [get](../vs140/get--csharp-reference-.md) accessor is available, so the property is read-only.  
  
## Example  
 The following code shows three subclasses of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and how they override the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property to provide their own implementation.  
  
 [!code[csProgGuideInheritance#2](../vs140/codesnippet/CSharp/how-to--define-abstract-properties--csharp-programming-guide-_2.cs)]  
  
## Example  
 The following code shows a test program that creates a number of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived objects and prints out their areas.  
  
 [!code[csProgGuideInheritance#3](../vs140/codesnippet/CSharp/how-to--define-abstract-properties--csharp-programming-guide-_3.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Abstract and Sealed Classes and Class Members](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)   
 [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)   
 [How to: Create and Use C# DLLs (C# Programming Guide)](../vs140/how-to--create-and-use-assemblies-using-the-command-line--csharp-and-visual-basic-.md)