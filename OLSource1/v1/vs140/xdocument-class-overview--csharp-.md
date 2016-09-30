---
title: "XDocument Class Overview (C#)"
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
ms.assetid: 63305603-ab54-49fc-84e4-f76eecc59549
caps.latest.revision: 5
---
# XDocument Class Overview (C#)
This topic introduces the \<xref:System.Xml.Linq.XDocument*> class.  
  
## Overview of the XDocument class  
 The \<xref:System.Xml.Linq.XDocument*> class contains the information necessary for a valid XML document. This includes an XML declaration, processing instructions, and comments.  
  
 Note that you only have to create \<xref:System.Xml.Linq.XDocument*> objects if you require the specific functionality provided by the \<xref:System.Xml.Linq.XDocument*> class. In many circumstances, you can work directly with \<xref:System.Xml.Linq.XElement*>. Working directly with \<xref:System.Xml.Linq.XElement*> is a simpler programming model.  
  
 \<xref:System.Xml.Linq.XDocument*> derives from \<xref:System.Xml.Linq.XContainer*>. Therefore, it can contain child nodes. However, \<xref:System.Xml.Linq.XDocument*> objects can have only one child \<xref:System.Xml.Linq.XElement*> node. This reflects the XML standard that there can be only one root element in an XML document.  
  
## Components of XDocument  
 An \<xref:System.Xml.Linq.XDocument*> can contain the following elements:  
  
-   One \<xref:System.Xml.Linq.XDeclaration*> object. \<xref:System.Xml.Linq.XDeclaration*> enables you to specify the pertinent parts of an XML declaration: the XML version, the encoding of the document, and whether the XML document is stand-alone.  
  
-   One \<xref:System.Xml.Linq.XElement*> object. This is the root node of the XML document.  
  
-   Any number of \<xref:System.Xml.Linq.XProcessingInstruction*> objects. A processing instruction communicates information to an application that processes the XML.  
  
-   Any number of \<xref:System.Xml.Linq.XComment*> objects. The comments will be siblings to the root element. The \<xref:System.Xml.Linq.XComment*> object cannot be the first argument in the list, because it is not valid for an XML document to start with a comment.  
  
-   One \<xref:System.Xml.Linq.XDocumentType*> for the DTD.  
  
 When you serialize an \<xref:System.Xml.Linq.XDocument*>, even if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the output will have an XML declaration if the writer has <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (the default).  
  
 By default, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] sets the version to "1.0", and sets the encoding to "utf-8".  
  
## Using XElement without XDocument  
 As previously mentioned, the \<xref:System.Xml.Linq.XElement*> class is the main class in the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] programming interface. In many cases, your application will not require that you create a document. By using the \<xref:System.Xml.Linq.XElement*> class, you can create an XML tree, add other XML trees to it, modify the XML tree, and save it.  
  
## Using XDocument  
 To construct an \<xref:System.Xml.Linq.XDocument*>, use functional construction, just like you do to construct \<xref:System.Xml.Linq.XElement*> objects.  
  
 The following code creates an \<xref:System.Xml.Linq.XDocument*> object and its associated contained objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you examine the file test.xml, you get the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Programming Overview (C#)](../vs140/linq-to-xml-programming-overview--csharp-.md)