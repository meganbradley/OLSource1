---
title: "Compiler Error CS0304"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0304"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0304"
ms.assetid: 22dc7211-57a8-4c92-96f6-fc1cf0263b68
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0304
Cannot create an instance of the variable type 'type' because it does not have the new() constraint  
  
 When you implement a generic class, and you want to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword to create a new instance of any type that is supplied for a type parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must apply the [new() constraint](../vs140/new--csharp-reference-.md) to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the class declaration, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> constraint enforces type safety by guaranteeing that any concrete type that is supplied for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has a default, parameterless constructor. CS0304 occurs if you attempt to use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator in the body of the class to create an instance of type parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not specify the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> constraint. On the client side, if code attempts to instantiate the generic class with a type that has no default constructor, that code will generate [CS0310](../vs140/compiler-error-cs0310.md).  
  
 The following example generates CS0304.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator also is not allowed in methods of the class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To avoid the error, declare the class by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> constraint, as shown in the following example.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Errors](../vs140/csharp-compiler-errors.md)