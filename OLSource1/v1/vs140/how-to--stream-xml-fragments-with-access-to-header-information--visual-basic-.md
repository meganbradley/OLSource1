---
title: "How to: Stream XML Fragments with Access to Header Information (Visual Basic)"
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
ms.assetid: effd10df-87c4-4d7a-8a9a-1434d829dca5
caps.latest.revision: 7
---
# How to: Stream XML Fragments with Access to Header Information (Visual Basic)
Sometimes you have to read arbitrarily large XML files, and write your application so that the memory footprint of the application is predictable. If you attempt to populate an XML tree with a large XML file, your memory usage will be proportional to the size of the file—that is, excessive. Therefore, you should use a streaming technique instead.  
  
 One option is to write your application using \<xref:System.Xml.XmlReader*>. However, you might want to use [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] to query the XML tree. If this is the case, you can write your own custom axis method. For more information, see [How to: Write a LINQ to XML Axis Method (Visual Basic)](../vs140/how-to--write-a-linq-to-xml-axis-method--visual-basic-.md).  
  
 To write your own axis method, you write a small method that uses the \<xref:System.Xml.XmlReader*> to read nodes until it reaches one of the nodes in which you are interested. The method then calls \<xref:System.Xml.Linq.XNode.ReadFrom*>, which reads from the \<xref:System.Xml.XmlReader*> and instantiates an XML fragment. You can then write LINQ queries on your custom axis method.  
  
 Streaming techniques are best applied in situations where you need to process the source document only once, and you can process the elements in document order. Certain standard query operators, such as \<xref:System.Linq.Enumerable.OrderBy*>, iterate their source, collect all of the data, sort it, and then finally yield the first item in the sequence. Note that if you use a query operator that materializes its source before yielding the first item, you will not retain a small memory footprint.  
  
## Example  
 Sometimes the problem gets just a little more interesting. In the following XML document, the consumer of your custom axis method also has to know the name of the customer that each item belongs to.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The approach that this example takes is to also watch for this header information, save the header information, and then build a small XML tree that contains both the header information and the detail that you are enumerating. The axis method then yields this new, small XML tree. The query then has access to the header information as well as the detail information.  
  
 This approach has a small memory footprint. As each detail XML fragment is yielded, no references are kept to the previous fragment, and it is available for garbage collection. Note that this technique creates many short lived objects on the heap.  
  
 The following example shows how to implement and use a custom axis method that streams XML fragments from the file specified by the URI. This custom axis is specifically written such that it expects a document that has <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements, and that those elements will be arranged as in the above <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> document. It is a simplistic implementation. A more robust implementation would be prepared to parse an invalid document.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Advanced LINQ to XML Programming (Visual Basic)](../vs140/advanced-linq-to-xml-programming--visual-basic-.md)