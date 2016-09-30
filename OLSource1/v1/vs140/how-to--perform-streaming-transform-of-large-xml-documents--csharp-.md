---
title: "How to: Perform Streaming Transform of Large XML Documents (C#)"
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
ms.assetid: 5f16d1f8-5370-4b55-b0c8-e497df163037
caps.latest.revision: 7
---
# How to: Perform Streaming Transform of Large XML Documents (C#)
Sometimes you have to transform large XML files, and write your application so that the memory footprint of the application is predictable. If you try to populate an XML tree with a very large XML file, your memory usage will be proportional to the size of the file (that is, excessive). Therefore, you should use a streaming technique instead.  
  
 Streaming techniques are best applied in situations where you need to process the source document only once, and you can process the elements in document order. Certain standard query operators, such as \<xref:System.Linq.Enumerable.OrderBy*>, iterate their source, collect all of the data, sort it, and then finally yield the first item in the sequence. Note that if you use a query operator that materializes its source before yielding the first item, you will not retain a small memory footprint for your application.  
  
 Even if you use the technique described in [How to: Stream XML Fragments with Access to Header Information (C#)](../vs140/how-to--stream-xml-fragments-with-access-to-header-information--csharp-.md), if you try to assemble an XML tree that contains the transformed document, memory usage will be too great.  
  
 There are two main approaches. One approach is to use the deferred processing characteristics of \<xref:System.Xml.Linq.XStreamingElement*>. Another approach is to create an \<xref:System.Xml.XmlWriter*>, and use the capabilities of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] to write elements to an \<xref:System.Xml.XmlWriter*>. This topic demonstrates both approaches.  
  
## Example  
 The following example builds on the example in [How to: Stream XML Fragments with Access to Header Information (C#)](../vs140/how-to--stream-xml-fragments-with-access-to-header-information--csharp-.md).  
  
 This example uses the deferred execution capabilities of \<xref:System.Xml.Linq.XStreamingElement*> to stream the output. This example can transform a very large document while maintaining a small memory footprint.  
  
 Note that the custom axis (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) is specifically written so that it expects a document that has <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements, and that those elements will be arranged as in the following Source.xml document. A more robust implementation, however, would be prepared to parse an invalid document.  
  
 The following is the source document, Source.xml:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example also builds on the example in [How to: Stream XML Fragments with Access to Header Information (C#)](../vs140/how-to--stream-xml-fragments-with-access-to-header-information--csharp-.md).  
  
 This example uses the capability of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] to write elements to an \<xref:System.Xml.XmlWriter*>. This example can transform a very large document while maintaining a small memory footprint.  
  
 Note that the custom axis (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) is specifically written so that it expects a document that has <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elements, and that those elements will be arranged as in the following Source.xml document. A more robust implementation, however, would either validate the source document with an XSD, or would be prepared to parse an invalid document.  
  
 This example uses the same source document, Source.xml, as the previous example in this topic. It also produces exactly the same output.  
  
 Using \<xref:System.Xml.Linq.XStreamingElement*> for streaming the output XML is preferred over writing to an \<xref:System.Xml.XmlWriter*>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Advanced LINQ to XML Programming (C#)](../vs140/advanced-linq-to-xml-programming--csharp-.md)