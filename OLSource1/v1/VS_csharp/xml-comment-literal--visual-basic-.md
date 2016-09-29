---
title: "XML Comment Literal (Visual Basic)"
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
  - "vb.XmlLiteralComment"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "comment literal [Visual Basic]"
  - "XML comments, adding [Visual Basic]"
  - "XML comment literal [Visual Basic]"
  - "XML literals [Visual Basic], comment"
ms.assetid: 634c1cee-5e01-48d0-88d7-2dd55e4a9e52
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Comment Literal (Visual Basic)
A literal representing an <xref:System.Xml.Linq.XComment*> object.  
  
## Syntax  
  
```  
<!-- content -->  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`<!--`|Required. Denotes the start of the XML comment.|  
|`content`|Required. Text to appear in the XML comment. Cannot contain a series of two hyphens (--) or end with a hyphen adjacent to the closing tag.|  
|`-->`|Required. Denotes the end of the XML comment.|  
  
## Return Value  
 An <xref:System.Xml.Linq.XComment*> object.  
  
## Remarks  
 XML comment literals do not contain document content; they contain information about the document. The XML comment section ends with the sequence "-->". This implies the following points:  
  
-   You cannot use an embedded expression in an XML comment literal because the embedded expression delimiters are valid XML comment content.  
  
-   XML comment sections cannot be nested, because `content` cannot contain the value "-->".  
  
 You can assign an XML comment literal to a variable, or you can include it in an XML element literal.  
  
> [!NOTE]
>  An XML literal can span multiple lines without using line continuation characters. This feature enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] program.  
  
 The [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] compiler converts the XML comment literal to a call to the <xref:System.Xml.Linq.XComment.#ctor*> constructor.  
  
## Example  
 The following example creates an XML comment that contains the text "This is a comment".  
  
 [!code[VbXMLSamples#9](../VS_csharp/codesnippet/VisualBasic/xml-comment-literal--visual-basic-_1.vb)]  
  
## See Also  
 <xref:System.Xml.Linq.XComment*>   
 [XML Element Literal](../VS_csharp/xml-element-literal--visual-basic-.md)   
 [XML Literals](../VS_csharp/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../VS_csharp/creating-xml-in-visual-basic.md)