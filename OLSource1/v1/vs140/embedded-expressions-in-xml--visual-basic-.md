---
title: "Embedded Expressions in XML (Visual Basic)"
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
  - "vb.XmlEmbeddedExpression"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "embedded expressions [Visual Basic]"
  - "LINQ to XML [Visual Basic], embedded expressions"
  - "XML literals [Visual Basic], embedded expressions"
ms.assetid: bf2eb779-b751-4b7c-854f-9f2161482352
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Embedded Expressions in XML (Visual Basic)
Embedded expressions enable you to create XML literals that contain expressions that are evaluated at run time. The syntax for an embedded expression is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is the same as the syntax used in [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)].  
  
 For example, you can create an XML element literal, combining embedded expressions with literal text content.  
  
 [!code[VbXMLSamples#27](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_1.vb)]  
  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains the integer 12345 and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> contains the date 3/5/2006, when this code executes, the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Embedded Expression Location and Validation  
 Embedded expressions can appear only at certain locations within XML literal expressions. The expression location controls which types the expression can return and how <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is handled. The following table describes the allowed locations and types of embedded expressions.  
  
||||  
|-|-|-|  
|Location in literal|Type of expression|Handling of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|XML element name|\<xref:System.Xml.Linq.XName*>|Error|  
|XML element content|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or array of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Ignored|  
|XML element attribute name|\<xref:System.Xml.Linq.XName*>|Error, unless the attribute value is also <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|XML element attribute value|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Attribute declaration ignored|  
|XML element attribute|\<xref:System.Xml.Linq.XAttribute*> or a collection of \<xref:System.Xml.Linq.XAttribute*>|Ignored|  
|XML document root element|\<xref:System.Xml.Linq.XElement*> or a collection of one \<xref:System.Xml.Linq.XElement*> object and an arbitrary number of \<xref:System.Xml.Linq.XProcessingInstruction*> and \<xref:System.Xml.Linq.XComment*> objects|Ignored|  
  
-   Example of an embedded expression in an XML element name:  
  
     [!code[VbXMLSamples#32](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_2.vb)]  
  
-   Example of an embedded expression in the content of an XML element:  
  
     [!code[VbXMLSamples#33](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_3.vb)]  
  
-   Example of an embedded expression in an XML element attribute name:  
  
     [!code[VbXMLSamples#34](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_4.vb)]  
  
-   Example of an embedded expression in an XML element attribute value:  
  
     [!code[VbXMLSamples#35](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_5.vb)]  
  
-   Example of an embedded expression in an XML element attribute:  
  
     [!code[VbXMLSamples#36](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_6.vb)]  
  
-   Example of an embedded expression in an XML document root element:  
  
     [!code[VbXMLSamples#37](../vs140/codesnippet/VisualBasic/embedded-expressions-in-xml--visual-basic-_7.vb)]  
  
 If you enable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the compiler checks that the type of each embedded expression widens to the required type. The only exception is for the root element of an XML document, which is verified when the code runs. If you compile without <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, you can embed expressions of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and their type is verified at run time.  
  
 In locations where content is optional, embedded expressions that contain <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are ignored. This means you do not have to check that element content, attribute values, and array elements are not <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> before you use an XML literal. Required values, such as element and attribute names, cannot be <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 For more information about using an embedded expression in a particular type of literal, see [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md), [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md).  
  
## Scoping Rules  
 The compiler converts each XML literal into a constructor call for the appropriate literal type. The literal content and embedded expressions in an XML literal are passed as arguments to the constructor. This means that all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] programming elements available to an XML literal are also available to its embedded expressions.  
  
 Within an XML literal, you can access the XML namespace prefixes declared with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement. You can declare a new XML namespace prefix, or shadow an existing XML namespace prefix, in an element by using the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute. The new namespace is available to the child nodes of that element, but not to XML literals in embedded expressions.  
  
> [!NOTE]
>  When you declare an XML namespace prefix by using the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> namespace attribute, the attribute value must be a constant string. In this regard, using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute is like using the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement to declare an XML namespace. You cannot use an embedded expression to specify the XML namespace value.  
  
## See Also  
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md)   
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [XML Literals Overview](../vs140/xml-literals-overview--visual-basic-.md)