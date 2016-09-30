---
title: "LINQ and Generic Types (C#)"
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
  - "LINQ [C#], generic types"
  - "generic types [LINQ]"
  - "generics [LINQ]"
ms.assetid: 660e3799-25ca-462c-8c4a-8bce04fbb031
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LINQ and Generic Types (C#)
[!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries are based on generic types, which were introduced in version 2.0 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. You do not need an in-depth knowledge of generics before you can start writing queries. However, you may want to understand two basic concepts:  
  
1.  When you create an instance of a generic collection class such as <xref:System.Collections.Generic.List<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>List<string><CodeContentPlaceHolder>1\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>List<Customer><CodeContentPlaceHolder>3\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>List<string><CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> is the interface that enables generic collection classes to be enumerated by using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement. Generic collection classes support <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> or a derived type such as <xref:System.Linq.IQueryable<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>IEnumerable<Customer><CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>var<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>var<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>var`, realize that it can make your code more difficult for others to read. For more information, see [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md).  
  
## See Also  
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [Generics (C# Programming Guide)](../vs140/generics--csharp-programming-guide-.md)