---
title: "GetXmlNamespace Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.GetXmlNamespace"
  - "GetXmlNamespace"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "GetXmlNamespace operator"
  - "GetXmlNamespace keyword"
ms.assetid: d0d28cfd-0755-4896-ae0b-4981aa35517c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetXmlNamespace Operator (Visual Basic)
Gets the \<xref:System.Xml.Linq.XNamespace*> object that corresponds to the specified XML namespace prefix.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. The string that identifies the XML namespace prefix. If supplied, this string must be a valid XML identifier. For more information, see [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md). If no prefix is specified, the default namespace is returned. If no default namespace is specified, the empty namespace is returned.  
  
## Return Value  
 The \<xref:System.Xml.Linq.XNamespace*> object that corresponds to the XML namespace prefix.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator gets the \<xref:System.Xml.Linq.XNamespace*> object that corresponds to the XML namespace prefix <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 You can use XML namespace prefixes directly in XML literals and XML axis properties. However, you must use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator to convert a namespace prefix to an \<xref:System.Xml.Linq.XNamespace*> object before you can use it in your code. You can append an unqualified element name to an \<xref:System.Xml.Linq.XNamespace*> object to get a fully qualified \<xref:System.Xml.Linq.XName*> object, which many [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] methods require.  
  
## Example  
 The following example imports <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as an XML namespace prefix. It then uses the prefix of the namespace to create an XML literal and access the first child node that has the qualified name <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It then passes that child node to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> subroutine, which constructs a qualified name by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> subroutine then passes the qualified name to the \<xref:System.Xml.Linq.XNode.Ancestors*> method to get the parent <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> node.  
  
 [!code[VbXMLSamples#38](../vs140/codesnippet/VisualBasic/getxmlnamespace-operator--visual-basic-_1.vb)]  
  
 When you call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, it displays a message box that contains the following text:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## See Also  
 [Imports Statement (XML Namespace Prefix)](../vs140/imports-statement--xml-namespace-.md)   
 [Accessing XML in Visual Basic](../vs140/accessing-xml-in-visual-basic.md)