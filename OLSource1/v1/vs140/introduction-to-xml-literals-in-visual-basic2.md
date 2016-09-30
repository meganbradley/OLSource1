---
title: "Introduction to XML Literals in Visual Basic2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Introduction to XML Literals in Visual Basic"
dev_langs: 
  - "VB"
ms.assetid: 94fc0e03-978e-4c08-ab6c-0dc3c1e64f10
caps.latest.revision: 7
---
# Introduction to XML Literals in Visual Basic2
This section provides information about creating XML trees in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
 For information about using the results of LINQ queries as the content for an XML tree, see [Functional Construction (LINQ to XML) (Visual Basic)](../vs140/functional-construction--linq-to-xml---visual-basic-.md).  
  
 For more information on XML literals in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], see [Overview of LINQ to XML in Visual Basic](../vs140/overview-of-linq-to-xml-in-visual-basic.md).  
  
## Creating XML Trees  
 The following example shows how to create an \<xref:System.Xml.Linq.XElement*>, in this case <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Creating an XElement with Simple Content  
 You can create an \<xref:System.Xml.Linq.XElement*> that contains simple content, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Creating an Empty Element  
 You can create an empty \<xref:System.Xml.Linq.XElement*>, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Using Embedded Expressions  
 An important feature of XML literals is that they allow embedded expressions. Embedded expressions enable you to evaluate an expression and insert the results of the expression into the XML tree. If the expression evaluates to a type of \<xref:System.Xml.Linq.XElement*>, an element is inserted into the tree. If the expression evaluates to a type of \<xref:System.Xml.Linq.XAttribute*>, an attribute is inserted into the tree. You can insert elements and attributes into the tree only where they are valid.  
  
 It is important to note that only a single expression can go into an embedded expression. You cannot embed multiple statements. If an expression extends beyond a single line, you must use the line continuation character.  
  
 If you use an embedded expression to add existing nodes (including elements) and attributes to a new XML tree and if the existing nodes are already parented, the nodes are cloned. The newly cloned nodes are attached to the new XML tree. If the existing nodes are not parented, the nodes are simply attached to the new XML tree. The last example in this topic demonstrates this.  
  
 The following example uses an embedded expression to insert an element into the tree:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Using Embedded Expressions for Content  
 You can use an embedded expression to supply the content of an element:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Using a LINQ Query in an Embedded Expression  
 You can use the results of a LINQ query for the content of an element:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Using Embedded Expressions for Node Names  
 You can also use embedded expressions to calculate attribute names, attribute values, element names, and element values:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Cloning vs. Attaching  
 As mentioned earlier, if you use an embedded expression to add existing nodes (including elements) and attributes to a new XML tree, if the existing nodes are already parented, the nodes are cloned and the newly cloned nodes are attached to the new XML tree. If the existing nodes are not parented, they are simply attached to the new XML tree.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md)