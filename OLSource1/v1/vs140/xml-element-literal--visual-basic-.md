---
title: "XML Element Literal (Visual Basic)"
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
  - "vb.XmlLiteralElement"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "XML element literal [Visual Basic]"
  - "element literal [Visual Basic]"
  - "XML literals [Visual Basic], element"
ms.assetid: 95039642-7893-48b7-b23f-45a6c55d8f67
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Element Literal (Visual Basic)
A literal that represents an \<xref:System.Xml.Linq.XElement*> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     Required. Opens the starting element tag.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     Required. Name of the element. The format is one of the following:  
  
    -   Literal text for the element name, of the form [<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where:  
  
        |||  
        |-|-|  
        |Part|Description|  
        |<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional. XML namespace prefix for the element. Must be a global XML namespace that is defined with an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement in the file or at the project level, or a local XML namespace that is defined in this element or a parent element.|  
        |<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required. Name of the element. The format is one of the following:\<br />\<br /> -   Literal text. See [Declared XML Element and Attribute Names](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md).\<br />-   Embedded expression of the form <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> e<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or a type that is implicitly convertible to \<xref:System.Xml.Linq.XName*>.|  
  
    -   Embedded expression of the form <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or a type implicitly convertible to \<xref:System.Xml.Linq.XName*>. An embedded expression is not allowed in a closing tag of an element.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
     Optional. List of attributes declared in the literal.  
  
     <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> has one of the following syntaxes:  
  
    -   Attribute assignment, of the form [<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, where:  
  
        |||  
        |-|-|  
        |Part|Description|  
        |<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional. XML namespace prefix for the attribute. Must be a global XML namespace that is defined with an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement, or a local XML namespace that is defined in this element or a parent element.|  
        |<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Required. Name of the attribute. The format is one of the following:\<br />\<br /> -   Literal text. See [Declared XML Element and Attribute Names](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md).\<br />-   Embedded expression of the form <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or a type that is implicitly convertible to \<xref:System.Xml.Linq.XName*>.|  
        |<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Optional. Value of the attribute. The format is one of the following:\<br />\<br /> -   Literal text, enclosed in quotation marks.\<br />-   Embedded expression of the form <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Any type is allowed.|  
  
    -   Embedded expression of the form <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
     Optional. Indicates that the element is an empty element, without content.  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
     Required. Ends the beginning or empty element tag.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
     Optional. Content of the element.  
  
     <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> can be one of the following:  
  
    -   Literal text. All the white space in <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> becomes significant if there is any literal text.  
  
    -   Embedded expression of the form <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
    -   XML element literal.  
  
    -   XML comment literal. See [XML Comment Literal](../vs140/xml-comment-literal--visual-basic-.md).  
  
    -   XML processing instruction literal. See [XML Processing Instruction Literal](../vs140/xml-processing-instruction-literal--visual-basic-.md).  
  
    -   XML CDATA literal. See [XML CDATA Literal](../vs140/xml-cdata-literal--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
     Optional. Represents the closing tag for the element. The optional <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter is not allowed when it is the result of an embedded expression.  
  
## Return Value  
 An \<xref:System.Xml.Linq.XElement*> object.  
  
## Remarks  
 You can use the XML element literal syntax to create \<xref:System.Xml.Linq.XElement*> objects in your code.  
  
> [!NOTE]
>  An XML literal can span multiple lines without using line continuation characters. This feature enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program.  
  
 Embedded expressions of the form <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> enable you to add dynamic information to an XML element literal. For more information, see [Embedded Expressions in XML](../vs140/embedded-expressions-in-xml--visual-basic-.md).  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts the XML element literal into calls to the \<xref:System.Xml.Linq.XElement.#ctor*> constructor and, if it is required, the \<xref:System.Xml.Linq.XAttribute.#ctor*> constructor.  
  
## XML Namespaces  
 XML namespace prefixes are useful when you have to create XML literals with elements from the same namespace many times in code. You can use global XML namespace prefixes, which you define by using the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement, or local prefixes, which you define by using the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>="<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>" attribute syntax. For more information, see [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md).  
  
 In accordance with the scoping rules for XML namespaces, local prefixes take precedence over global prefixes. However, if an XML literal defines an XML namespace, that namespace is not available to expressions that appear in an embedded expression. The embedded expression can access only the global XML namespace.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts each global XML namespace that is used by an XML literal into a one local namespace definition in the generated code. Global XML namespaces that are not used do not appear in the generated code.  
  
## Example  
 The following example shows how to create a simple XML element that has two nested empty elements.  
  
 [!code[VbXMLSamples#20](../vs140/codesnippet/VisualBasic/xml-element-literal--visual-basic-_1.vb)]  
  
 The example displays the following text. Notice that the literal preserves the structure of the empty elements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use embedded expressions to name an element and create attributes.  
  
 [!code[VbXMLSamples#21](../vs140/codesnippet/VisualBasic/xml-element-literal--visual-basic-_2.vb)]  
  
 This code displays the following text:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example declares <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> as an XML namespace prefix. It then uses the prefix of the namespace to create an XML literal and displays the element's final form.  
  
 [!code[VbXMLSamples#22](../vs140/codesnippet/VisualBasic/xml-element-literal--visual-basic-_3.vb)]  
  
 This code displays the following text:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Notice that the compiler converted the prefix of the global XML namespace into a prefix definition for the XML namespace. The \<ns:middle> element redefines the XML namespace prefix for the \<ns:inner1> element. However, the \<ns:inner2> element uses the namespace defined by the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement.  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 [Declared XML Element and Attribute Names](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md)   
 [XML Comment Literal](../vs140/xml-comment-literal--visual-basic-.md)   
 [XML CDATA Literal](../vs140/xml-cdata-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Embedded Expressions in XML](../vs140/embedded-expressions-in-xml--visual-basic-.md)   
 [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md)