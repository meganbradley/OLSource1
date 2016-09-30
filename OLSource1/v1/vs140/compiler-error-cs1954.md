---
title: "Compiler Error CS1954"
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
  - "CS1954"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1954"
ms.assetid: bdec399e-c43d-46d3-a01b-ef3572786fe5
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1954
The best overloaded method match 'method' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.  
  
 For a collection class to be initialized by using a collection initializer, the class must have a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method that is not a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
### To correct this error  
  
-   If you can modify the source code of the collection class, provide an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method that does not take a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
-   If you cannot modify the collection class, initialize it with the constructors it provides. You cannot use a collection initializer with it.  
  
## Example  
 The following example produces CS1954 because the only available overload of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> list in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)