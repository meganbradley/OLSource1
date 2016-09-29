---
title: "XML CDATA Literal (Visual Basic)"
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
  - "vb.XmlLiteralCdata"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "CDATA literal [Visual Basic]"
  - "XML CDATA literal [Visual Basic]"
  - "XML literals [Visual Basic], CDATA"
ms.assetid: 9eafb6a4-dd9d-4866-85e8-0654c65abc44
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML CDATA Literal (Visual Basic)
A literal representing an <xref:System.Xml.Linq.XCData*> object.  
  
## Syntax  
  
```  
<![CDATA[content]]>  
```  
  
## Parts  
 `<![CDATA[`  
 Required. Denotes the start of the XML CDATA section.  
  
 `content`  
 Required. Text content to appear in the XML CDATA section.  
  
 `]]>`  
 Required. Denotes the end of the section.  
  
## Return Value  
 An <xref:System.Xml.Linq.XCData*> object.  
  
## Remarks  
 XML CDATA sections contain raw text that should be included, but not parsed, with the XML that contains it. A XML CDATA section can contain any text. This includes reserved XML characters. The XML CDATA section ends with the sequence "]]>". This implies the following points:  
  
-   You cannot use an embedded expression in an XML CDATA literal because the embedded expression delimiters are valid XML CDATA content.  
  
-   XML CDATA sections cannot be nested, because `content` cannot contain the value "]]>".  
  
 You can assign an XML CDATA literal to a variable, or include it in an XML element literal.  
  
> [!NOTE]
>  An XML literal can span multiple lines but does not use line continuation characters. This enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts the XML CDATA literal to a call to the <xref:System.Xml.Linq.XCData.#ctor*> constructor.  
  
## Example  
 The following example creates a CDATA section that contains the text "Can contain literal <XML\> tags".  
  
 [!code[VbXMLSamples#23](../vs140/codesnippet/VisualBasic/xml-cdata-literal--visual-basic-_1.vb)]  
  
## See Also  
 <xref:System.Xml.Linq.XCData*>   
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)