---
title: "Modifying XML Trees (LINQ to XML) (C#)"
ms.custom: na
ms.date: "10/03/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 8ec47e6d-2363-4694-be46-8d5ca4d15fc9
caps.latest.revision: 3
ms.author: "shoag"
manager: "wpickett"
---
# Modifying XML Trees (LINQ to XML) (C#)
[!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)] is an in-memory store for an XML tree. After you load or parse an XML tree from a source, [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)] lets you modify that tree in place, and then serialize the tree, perhaps saving it to a file or sending it to a remote server.  
  
 When you modify a tree in place, you use certain methods, such as \<xref:System.Xml.Linq.XContainer.Add*>.  
  
 However, there is another approach, which is to use functional construction to generate a new tree with a different shape. Depending on the types of changes that you need to make to your XML tree, and depending on the size of the tree, this approach can be more robust and easier to develop. The first topic in this section compares these two approaches.  
  
## In This Section  
  
|Topic|Description|  
|-----------|-----------------|  
|[In-Memory XML Tree Modification vs. Functional Construction (LINQ to XML) (C#)](../VS_csharp/in-memory-xml-tree-modification-vs.-functional-construction--linq-to-xml---csharp-.md)|Compares modifying an XML tree in memory to functional construction.|  
|[Adding Elements, Attributes, and Nodes to an XML Tree (C#)](../VS_csharp/adding-elements--attributes--and-nodes-to-an-xml-tree--csharp-.md)|Provides information about adding elements, attributes, or nodes to an XML tree.|  
|[Modifying Elements, Attributes, and Nodes in an XML Tree](../VS_csharp/modifying-elements--attributes--and-nodes-in-an-xml-tree3.md)|Provides information about modifying existing elements, attributes, or nodes.|  
|[Removing Elements, Attributes, and Nodes from an XML Tree (C#)](../VS_csharp/removing-elements--attributes--and-nodes-from-an-xml-tree--csharp-.md)|Provides information about removing elements, attributes, or nodes from the XML tree.|  
|[Maintaining Name/Value Pairs (C#)](../VS_csharp/maintaining-name-value-pairs--csharp-.md)|Describes how to maintain application information that is best kept as name/value pairs, such as configuration information or global settings.|  
|[How to: Change the Namespace for an Entire XML Tree (C#)](../VS_csharp/how-to--change-the-namespace-for-an-entire-xml-tree--csharp-.md)|Shows how to move an XML tree from one namespace into another.|  
  
## See Also  
 [Programming Guide (LINQ to XML) (C#)](../VS_csharp/programming-guide--linq-to-xml---csharp-.md)