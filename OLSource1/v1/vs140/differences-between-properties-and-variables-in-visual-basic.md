---
title: "Differences Between Properties and Variables in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "property values"
  - "variables [Visual Basic]"
  - "Visual Basic code, procedures"
  - "values, properties"
  - "variables [Visual Basic], definition"
  - "Visual Basic code, variables"
  - "Visual Basic code, properties"
  - "properties [Visual Basic], values"
  - "properties [Visual Basic], defined"
  - "variables [Visual Basic], and properties"
  - "properties [Visual Basic], and variables"
ms.assetid: 7a03a8be-5381-431f-bd7c-16e887e4e07b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Differences Between Properties and Variables in Visual Basic
Variables and properties both represent values that you can access. However, there are differences in storage and implementation.  
  
## Variables  
 A *variable* corresponds directly to a memory location. You define a variable with a single declaration statement. A variable can be a *local variable*, defined inside a procedure and available only within that procedure, or it can be a *member variable*, defined in a module, class, or structure but not inside any procedure. A member variable is also called a *field*.  
  
## Properties  
 A *property* is a data element defined on a module, class, or structure. You define a property with a code block between the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements. The code block contains a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure, or both. These procedures are called *property procedures* or *property accessors*. In addition to retrieving or storing the property's value, they can also perform custom actions, such as updating an access counter.  
  
## Differences  
 The following table shows some important differences between variables and properties.  
  
|Point of difference|Variable|Property|  
|-------------------------|--------------|--------------|  
|Declaration|Single declaration statement|Series of statements in a code block|  
|Implementation|Single storage location|Executable code (property procedures)|  
|Storage|Directly associated with variable's value|Typically has internal storage not available outside the property's containing class or module\<br />\<br /> Property's value might or might not exist as a stored element <sup>1\</sup>|  
|Executable code|None|Must have at least one procedure|  
|Read and write access|Read/write or read-only|Read/write, read-only, or write-only|  
|Custom actions (in addition to accepting or returning value)|Not possible|Can be performed as part of setting or retrieving property value|  
  
 <sup>1\</sup> Unlike a variable, the value of a property might not correspond directly to a single item of storage. The storage might be split into pieces for convenience or security, or the value might be stored in an encrypted form. In these cases the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> procedure would assemble the pieces or decrypt the stored value, and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure would encrypt the new value or split it into the constituent storage. A property value might be ephemeral, like time of day, in which case the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> procedure would calculate it on the fly each time you access the property.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [How to: Create a Property](../vs140/how-to--create-a-property--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [How to: Call a Property Procedure](../vs140/how-to--call-a-property-procedure--visual-basic-.md)   
 [How to: Declare and Call a Default Property in Visual Basic](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)   
 [How to: Put a Value in a Property](../vs140/how-to--put-a-value-in-a-property--visual-basic-.md)   
 [How to: Get a Value from a Property](../vs140/how-to--get-a-value-from-a-property--visual-basic-.md)