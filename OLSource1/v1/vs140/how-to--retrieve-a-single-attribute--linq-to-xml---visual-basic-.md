---
title: "How to: Retrieve a Single Attribute (LINQ to XML) (Visual Basic)"
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
ms.assetid: 11b938d7-c011-4048-900e-8b9183c41c94
caps.latest.revision: 7
---
# How to: Retrieve a Single Attribute (LINQ to XML) (Visual Basic)
This topic explains how to retrieve a single attribute of an element, given the attribute name. This is useful for writing query expressions where you want to find an element that has a particular attribute.  
  
 The \<xref:System.Xml.Linq.XElement.Attribute*> method of the \<xref:System.Xml.Linq.XElement*> class returns the \<xref:System.Xml.Linq.XAttribute*> with the specified name.  
  
## Example  
 The following example uses the \<xref:System.Xml.Linq.XElement.Attribute*> method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example finds all the descendants in the tree named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and then finds the attribute named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 If you want to retrieve the value of the attribute, you can cast it, just as you do for with \<xref:System.Xml.Linq.XElement*> objects. The following example demonstrates this.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides explicit cast operators for the \<xref:System.Xml.Linq.XAttribute*> class to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows the same code for an attribute that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (Visual Basic)](../vs140/linq-to-xml-axes--visual-basic-.md)