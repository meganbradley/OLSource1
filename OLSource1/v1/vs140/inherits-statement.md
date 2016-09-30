---
title: "Inherits Statement"
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
  - "vb.Inherits"
  - "Inherits"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Inherits statement"
  - "Inherits statement, syntax"
ms.assetid: 9e6fe042-9af3-4341-8093-fc3537770cf2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inherits Statement
Causes the current class or interface to inherit the attributes, variables, properties, procedures, and events from another class or set of interfaces.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. The name of the class from which this class derives.\<br />\<br /> -or-\<br />\<br /> The names of the interfaces from which this interface derives. Use commas to separate multiple names.|  
  
## Remarks  
 If used, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement must be the first non-blank, non-comment line in a class or interface definition. It should immediately follow the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement.  
  
 You can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> only in a class or interface. This means the declaration context for an inheritance cannot be a source file, namespace, structure, module, procedure, or block.  
  
## Rules  
  
-   **Class Inheritance.** If a class uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, you can specify only one base class.  
  
     A class cannot inherit from a class nested within it.  
  
-   **Interface Inheritance.** If an interface uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement, you can specify one or more base interfaces. You can inherit from two interfaces even if they each define a member with the same name. If you do so, the implementing code must use name qualification to specify which member it is implementing.  
  
     An interface cannot inherit from another interface with a more restrictive access level. For example, a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface cannot inherit from a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface.  
  
     An interface cannot inherit from an interface nested within it.  
  
 An example of class inheritance in the .NET Framework is the \<xref:System.ArgumentException*> class, which inherits from the \<xref:System.SystemException*> class. This provides to \<xref:System.ArgumentException*> all the predefined properties and procedures required by system exceptions, such as the \<xref:System.Exception.Message*> property and the \<xref:System.Exception.ToString*> method.  
  
 An example of interface inheritance in the .NET Framework is the \<xref:System.Collections.ICollection*> interface, which inherits from the \<xref:System.Collections.IEnumerable*> interface. This causes \<xref:System.Collections.ICollection*> to inherit the definition of the enumerator required to traverse a collection.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement to show how a class named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> can inherit all the members of a base class named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrStatements#37](../vs140/codesnippet/VisualBasic/inherits-statement_1.vb)]  
  
## Example  
 The following example shows inheritance of multiple interfaces.  
  
 [!code[VbVbalrStatements#38](../vs140/codesnippet/VisualBasic/inherits-statement_2.vb)]  
  
 The interface named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> now includes all the definitions in the \<xref:System.IComparable*>, \<xref:System.IDisposable*>, and \<xref:System.IFormattable*> interfaces The inherited members provide respectively for type-specific comparison of two objects, releasing allocated resources, and expressing the value of an object as a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. A class that implements <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must implement every member of every base interface.  
  
## See Also  
 [MustInherit](../vs140/mustinherit--visual-basic-.md)   
 [NotInheritable](../vs140/notinheritable--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Interfaces (Visual Basic)](../vs140/interfaces--visual-basic-.md)