---
title: "XML Document Literal (Visual Basic)"
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
  - "vb.XmlLiteralDocument"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "XML document literal [Visual Basic]"
  - "XML literals [Visual Basic], document"
  - "XML documents [Visual Basic], creating"
  - "document literal [Visual Basic]"
ms.assetid: f7bbee56-0911-41de-b907-96f20450137b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Document Literal (Visual Basic)
A literal representing an \<xref:System.Xml.Linq.XDocument*> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional. Literal text declaring which encoding the document uses.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. Literal text. Must be "yes" or "no".|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional. List of XML processing instructions and XML comments. Takes the following format:\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>\<br />\<br /> Each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>can be one of the following:\<br />\<br /> -   [XML Processing Instruction Literal](../vs140/xml-processing-instruction-literal--visual-basic-.md).\<br />-   [XML Comment Literal](../vs140/xml-comment-literal--visual-basic-.md).|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. Root element of the document. The format is one of the following:\<br />\<br /> <ul><li>[XML Element Literal](../vs140/xml-element-literal--visual-basic-.md).\</li><li>Embedded expression of the form <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns one of the following:\<br />\<br /> <ul><li>An \<xref:System.Xml.Linq.XElement*> object.\</li><li>A collection that contains one \<xref:System.Xml.Linq.XElement*> object and any number of \<xref:System.Xml.Linq.XProcessingInstruction*> and \<xref:System.Xml.Linq.XComment*> objects.\</li>\</ul>\</li>\</ul>\<br /> For more information, see [Embedded Expressions In XML](../vs140/embedded-expressions-in-xml--visual-basic-.md).|  
  
## Return Value  
 An \<xref:System.Xml.Linq.XDocument*> object.  
  
## Remarks  
 An XML document literal is identified by the XML declaration at the start of the literal. Although each XML document literal must have exactly one root XML element, it can have any number of XML processing instructions and XML comments.  
  
 An XML document literal cannot appear in an XML element.  
  
> [!NOTE]
>  An XML literal can span multiple lines without using line continuation characters. This enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts the XML document literal into calls to the \<xref:System.Xml.Linq.XDocument.#ctor*> and \<xref:System.Xml.Linq.XDeclaration.#ctor*> constructors.  
  
## Example  
 The following example creates an XML document that has an XML declaration, a processing instruction, a comment, and an element that contains another element.  
  
 [!code[VbXMLSamples#30](../vs140/codesnippet/VisualBasic/xml-document-literal--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 \<xref:System.Xml.Linq.XProcessingInstruction*>   
 \<xref:System.Xml.Linq.XComment*>   
 \<xref:System.Xml.Linq.XDocument*>   
 [XML Processing Instruction Literal](../vs140/xml-processing-instruction-literal--visual-basic-.md)   
 [XML Comment Literal](../vs140/xml-comment-literal--visual-basic-.md)   
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Embedded Expressions in XML](../vs140/embedded-expressions-in-xml--visual-basic-.md)