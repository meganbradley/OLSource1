---
title: "How to: Populate an XML Tree from the File System (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 34eec79e-7945-4ba8-9f74-d05bb8ec67f6
caps.latest.revision: 7
---
# How to: Populate an XML Tree from the File System (Visual Basic)
A common and useful application of XML trees is as a hierarchical name/value data store. You can populate an XML tree with hierarchical data, and then query it, transform it, and if necessary, serialize it. In this usage scenario, many of the XML specific semantics, such as namespaces and white space behavior, are not important. Instead, you are using the XML tree as a small, in memory, single user hierarchical database.  
  
## Example  
 The following example populates an XML tree from the local file system using recursion. It then queries the tree, calculating the total of the sizes of all files in the tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces output similar to the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (Visual Basic)](../vs140/advanced-query-techniques--linq-to-xml---visual-basic-.md)