---
title: "How to: Use Annotations to Transform LINQ to XML Trees in an XSLT Style (C#)"
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
ms.assetid: 12a95902-a6b7-4a1e-ad52-04a518db226f
caps.latest.revision: 5
---
# How to: Use Annotations to Transform LINQ to XML Trees in an XSLT Style (C#)
Annotations can be used to facilitate transforms of an XML tree.  
  
 Some XML documents are "document centric with mixed content." With such documents, you don't necessarily know the shape of child nodes of an element. For instance, a node that contains text may look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For any given text node, there may be any number of child <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements. This approach extends to a number of other situations: i.e. pages that can contain a variety of child elements, such as regular paragraphs, bulleted paragraphs, and bitmaps. Cells in a table may contain text, drop down lists, or bitmaps. One of the primary characteristics of document centric XML is that you do not know which child element any particular element will have.  
  
 If you want to transform elements in a tree where you don't necessarily know much about the children of the elements that you want to transform, then this approach that uses annotations is an effective approach.  
  
 The summary of the approach is:  
  
-   First, annotate elements in the tree with a replacement element.  
  
-   Second, iterate through the entire tree, creating a new tree where you replace each element with its annotation. This example implements the iteration and creation of the new tree in a function named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 In detail, the approach consists of:  
  
-   Execute one or more LINQ to XML queries that return the set of elements that you want to transform from one shape to another. For each element in the query, add a new \<xref:System.Xml.Linq.XElement*> object as an annotation to the element. This new element will replace the annotated element in the new, transformed tree. This is simple code to write, as demonstrated by the example.  
  
-   The new element that is added as an annotation can contain new child nodes; it can form a sub-tree with any desired shape.  
  
-   There is a special rule: If a child node of the new element is in a different namespace, a namespace that is made up for this purpose (in this example, the namespace is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>), then that child element is not copied to the new tree. Instead, if the namespace is the above mentioned special namespace, and the local name of the element is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, then the child nodes of the element in the source tree are iterated, and copied to the new tree (with the exception that annotated child elements are themselves transformed according to these rules).  
  
-   This is somewhat analogous to the specification of transforms in XSL. The query that selects a set of nodes is analogous to the XPath expression for a template. The code to create the new \<xref:System.Xml.Linq.XElement*> that is saved as an annotation is analogous to the sequence constructor in XSL, and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element is analogous in function to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element in XSL.  
  
-   One advantage to taking this approach - as you formulate queries, you are always writing queries on the unmodified source tree. You need not worry about how modifications to the tree affect the queries that you are writing.  
  
## Transforming a Tree  
 This first example renames all <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> nodes to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## A More Complicated Transform  
 The following example queries the tree and calculates the average and sum of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements, and adds them as new elements to the tree.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Effecting the Transform  
 A small function, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, creates a new transformed tree from the original, annotated tree.  
  
-   The pseudo code for the function is quite simple:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Following is the implementation of this function:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Complete Example  
 The following code is a complete example that includes the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function. It includes a few of the typical uses of this type of transform:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Advanced LINQ to XML Programming (C#)](../vs140/advanced-linq-to-xml-programming--csharp-.md)