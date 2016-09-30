---
title: "Compiler Error CS1922"
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
  - "CS1922"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1922"
ms.assetid: a4098a25-6581-4966-b61d-318cd12f76d3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1922
Collection initializer requires its type 'type' to implement System.Collections.IEnumerable.  
  
 In order to use a collection initializer with a type, the type must implement <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. This error can occur if you accidentally use collection initializer syntax when you meant to use an object initializer.  
  
### To correct this error  
  
-   If the type does not represent a collection, use object initializer syntax instead of collection initializer syntax.  
  
-   If the type does represent a collection, modify it to implement <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> before you can use collection initializers to initialize objects of that type.  
  
-   If the type represents a collection and you do not have access to the source code, just initialize its elements by using their class constructors or other initialization methods.  
  
## Example  
 The following code produces CS1922:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)