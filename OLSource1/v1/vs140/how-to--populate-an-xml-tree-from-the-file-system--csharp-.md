---
title: "How to: Populate an XML Tree from the File System (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 2aa2ccac-4a22-47ae-9107-3bb8df232576
caps.latest.revision: 7
---
# How to: Populate an XML Tree from the File System (C#)
A common and useful application of XML trees is as a hierarchical name/value data store. You can populate an XML tree with hierarchical data, and then query it, transform it, and if necessary, serialize it. In this usage scenario, many of the XML specific semantics, such as namespaces and white space behavior, are not important. Instead, you are using the XML tree as a small, in memory, single user hierarchical database.  
  
## Example  
 The following example populates an XML tree from the local file system using recursion. It then queries the tree, calculating the total of the sizes of all files in the tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces output similar to the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (C#)](../vs140/advanced-query-techniques--linq-to-xml---csharp-.md)