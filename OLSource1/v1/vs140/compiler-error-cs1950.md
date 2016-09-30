---
title: "Compiler Error CS1950"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1950"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1950"
ms.assetid: e37fb5b1-09e0-47a6-9db5-a48f90ea7bbb
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1950
The best overloaded Add method 'name' for the collection initializer has some invalid arguments.  
  
 To support collection initializers, a class must implement IEnumerable and have a public <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method. To initialize the type by using a collection initializer, the input parameter of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method must be compatible with the type of the object you are trying to add.  
  
### To correct this error  
  
-   Use a compatible type in the collection initializer.  
  
-   Modify the input parameter and/or accessibility of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method in the collection type.  
  
-   Add a new <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method with an input parameter that matches what you are passing in.  
  
-   Make your collection class generic so that it can have an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method that accepts any type you pass in.  
  
## Example  
 The following example generates CS1950:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)