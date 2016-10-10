---
title: "XML Element Literal (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
caps.latest.revision: 32
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# XML Element Literal (Visual Basic)
A literal that represents an \<xref:System.Xml.Linq.XElement> object.  
  
## Syntax  
  
```  
<name [ attributeList ] />  
-or-  
<name [ attributeList ] > [ elementContents ] </[ name ]>  
```  
  
## Parts  
  
-   `<`  
  
     Required. Opens the starting element tag.  
  
-   `name`  
  
     Required. Name of the element. The format is one of the following:  
  
    -   Literal text for the element name, of the form [`ePrefix``:`]`eName`, where:  
  
        |||  
        |-|-|  
        |Part|Description|  
        |`ePrefix`|Optional. XML namespace prefix for the element. Must be a global XML namespace that is defined with an `Imports` statement in the file or at the project level, or a local XML namespace that is defined in this element or a parent element.|  
        |`eName`|Required. Name of the element. The format is one of the following:<br /><br /> -   Literal text. See [Names of Declared XML Elements and Attributes](../VS_visualbasic/names-of-declared-xml-elements-and-attributes--visual-basic-.md).<br />-   Embedded expression of the form `<%=` e`NameExp` `%>`. The type of `eNameExp` must be `String` or a type that is implicitly convertible to \<xref:System.Xml.Linq.XName>.|  
  
    -   Embedded expression of the form `<%=` `nameExp` `%>`. The type of `nameExp` must be `String` or a type implicitly convertible to \<xref:System.Xml.Linq.XName>. An embedded expression is not allowed in a closing tag of an element.  
  
-   `attributeList`  
  
     Optional. List of attributes declared in the literal.  
  
     `attribute [ attribute ... ]`  
  
     Each `attribute` has one of the following syntaxes:  
  
    -   Attribute assignment, of the form [`aPrefix``:`]`aName``=``aValue`, where:  
  
        |||  
        |-|-|  
        |Part|Description|  
        |`aPrefix`|Optional. XML namespace prefix for the attribute. Must be a global XML namespace that is defined with an `Imports` statement, or a local XML namespace that is defined in this element or a parent element.|  
        |`aName`|Required. Name of the attribute. The format is one of the following:<br /><br /> -   Literal text. See [Names of Declared XML Elements and Attributes](../VS_visualbasic/names-of-declared-xml-elements-and-attributes--visual-basic-.md).<br />-   Embedded expression of the form `<%=` `aNameExp` `%>`. The type of `aNameExp` must be `String` or a type that is implicitly convertible to \<xref:System.Xml.Linq.XName>.|  
        |`aValue`|Optional. Value of the attribute. The format is one of the following:<br /><br /> -   Literal text, enclosed in quotation marks.<br />-   Embedded expression of the form `<%=` `aValueExp` `%>`. Any type is allowed.|  
  
    -   Embedded expression of the form `<%=` `aExp` `%>`.  
  
-   `/>`  
  
     Optional. Indicates that the element is an empty element, without content.  
  
-   `>`  
  
     Required. Ends the beginning or empty element tag.  
  
-   `elementContents`  
  
     Optional. Content of the element.  
  
     `content [ content ... ]`  
  
     Each `content` can be one of the following:  
  
    -   Literal text. All the white space in `elementContents` becomes significant if there is any literal text.  
  
    -   Embedded expression of the form `<%=` `contentExp` `%>`.  
  
    -   XML element literal.  
  
    -   XML comment literal. See [XML Comment Literal](../VS_visualbasic/xml-comment-literal--visual-basic-.md).  
  
    -   XML processing instruction literal. See [XML Processing Instruction Literal](../VS_visualbasic/xml-processing-instruction-literal--visual-basic-.md).  
  
    -   XML CDATA literal. See [XML CDATA Literal](../VS_visualbasic/xml-cdata-literal--visual-basic-.md).  
  
-   `</`[`name`]`>`  
  
     Optional. Represents the closing tag for the element. The optional `name` parameter is not allowed when it is the result of an embedded expression.  
  
## Return Value  
 An \<xref:System.Xml.Linq.XElement> object.  
  
## Remarks  
 You can use the XML element literal syntax to create \<xref:System.Xml.Linq.XElement> objects in your code.  
  
> [!NOTE]
>  An XML literal can span multiple lines without using line continuation characters. This feature enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] program.  
  
 Embedded expressions of the form `<%=` `exp` `%>` enable you to add dynamic information to an XML element literal. For more information, see [Embedded Expressions in XML](../VS_visualbasic/embedded-expressions-in-xml--visual-basic-.md).  
  
 The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler converts the XML element literal into calls to the \<xref:System.Xml.Linq.XElement.#ctor*> constructor and, if it is required, the \<xref:System.Xml.Linq.XAttribute.#ctor*> constructor.  
  
## XML Namespaces  
 XML namespace prefixes are useful when you have to create XML literals with elements from the same namespace many times in code. You can use global XML namespace prefixes, which you define by using the `Imports` statement, or local prefixes, which you define by using the `xmlns:``xmlPrefix`="`xmlNamespace`" attribute syntax. For more information, see [Imports Statement (XML Namespace)](../VS_visualbasic/imports-statement--xml-namespace-.md).  
  
 In accordance with the scoping rules for XML namespaces, local prefixes take precedence over global prefixes. However, if an XML literal defines an XML namespace, that namespace is not available to expressions that appear in an embedded expression. The embedded expression can access only the global XML namespace.  
  
 The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler converts each global XML namespace that is used by an XML literal into a one local namespace definition in the generated code. Global XML namespaces that are not used do not appear in the generated code.  
  
## Example  
 The following example shows how to create a simple XML element that has two nested empty elements.  
  
 [!code[VbXMLSamples#20](../VS_visualbasic/codesnippet/VisualBasic/xml-element-literal--visual-basic-_1.vb)]  
  
 The example displays the following text. Notice that the literal preserves the structure of the empty elements.  
  
```  
<outer>  
  <inner1></inner1>  
  <inner2 />  
</outer>  
```  
  
## Example  
 The following example shows how to use embedded expressions to name an element and create attributes.  
  
 [!code[VbXMLSamples#21](../VS_visualbasic/codesnippet/VisualBasic/xml-element-literal--visual-basic-_2.vb)]  
  
 This code displays the following text:  
  
```  
<book isbn="1234" author="My Author" year="1999" title="My Book" />  
```  
  
## Example  
 The following example declares `ns` as an XML namespace prefix. It then uses the prefix of the namespace to create an XML literal and displays the element's final form.  
  
 [!code[VbXMLSamples#22](../VS_visualbasic/codesnippet/VisualBasic/xml-element-literal--visual-basic-_3.vb)]  
  
 This code displays the following text:  
  
```  
<ns:outer xmlns:ns="http://SomeNamespace">  
  <ns:middle xmlns:ns="http://NewNamespace">  
    <ns:inner1 />  
    <inner2 xmlns="http://SomeNamespace" />  
  </ns:middle>  
</ns:outer>  
```  
  
 Notice that the compiler converted the prefix of the global XML namespace into a prefix definition for the XML namespace. The \<ns:middle> element redefines the XML namespace prefix for the \<ns:inner1> element. However, the \<ns:inner2> element uses the namespace defined by the `Imports` statement.  
  
## See Also  
 \<xref:System.Xml.Linq.XElement>   
 [Names of Declared XML Elements and Attributes](../VS_visualbasic/names-of-declared-xml-elements-and-attributes--visual-basic-.md)   
 [XML Comment Literal](../VS_visualbasic/xml-comment-literal--visual-basic-.md)   
 [XML CDATA Literal](../VS_visualbasic/xml-cdata-literal--visual-basic-.md)   
 [XML Literals](../VS_visualbasic/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../VS_visualbasic/creating-xml-in-visual-basic.md)   
 [Embedded Expressions in XML](../VS_visualbasic/embedded-expressions-in-xml--visual-basic-.md)   
 [Imports Statement (XML Namespace)](../VS_visualbasic/imports-statement--xml-namespace-.md)