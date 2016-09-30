---
title: "Imports Statement (XML Namespace)"
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
  - "vb.ImportsXmlns"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "XML namespace [Visual Basic], importing"
  - "imports [Visual Basic]"
  - "Imports statement [Visual Basic]"
  - "namespaces [Visual Basic], importing"
ms.assetid: 1f4d50a6-08c7-4c2e-8206-ccae35fcd1b4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Imports Statement (XML Namespace)
Imports XML namespace prefixes for use in XML literals and XML axis properties.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The string by which XML elements and attributes can refer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is supplied, the imported XML namespace is the default XML namespace. Must be a valid XML identifier. For more information, see [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required. The string identifying the XML namespace being imported.  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement to define global XML namespaces that you can use with XML literals and XML axis properties, or as parameters passed to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator. (For information about using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement to import an alias that can be used where type names are used in your code, see [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md).) The syntax for declaring an XML namespace by using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement is identical to the syntax used in XML. Therefore, you can copy a namespace declaration from an XML file and use it in an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement.  
  
 XML namespace prefixes are useful when you want to repeatedly create XML elements that are from the same namespace. The XML namespace prefix declared with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement is global in the sense that it is available to all code in the file. You can use it when you create XML element literals and when you access XML axis properties. For more information, see [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md) and [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md).  
  
 If you define a global XML namespace without a namespace prefix (for example, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), that namespace is considered the default XML namespace. The default XML namespace is used for any XML element literals or XML attribute axis properties that do not explicitly specify a namespace. The default namespace is also used if the specified namespace is the empty namespace (that is, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). The default XML namespace does not apply to XML attributes in XML literals or to XML attribute axis properties that do not have a namespace.  
  
 XML namespaces that are defined in an XML literal, which are called *local XML namespaces*, take precedence over XML namespaces that are defined by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement as global. XML namespaces that are defined by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement take precedence over XML namespaces imported for a Visual Basic project. If an XML literal defines an XML namespace, that local namespace does not apply to embedded expressions.  
  
 Global XML namespaces follow the same scoping and definition rules as .NET Framework namespaces. As a result, you can include an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement to define a global XML namespace anywhere you can import a .NET Framework namespace. This includes both code files and project-level imported namespaces. For information about project-level imported namespaces, see [References Page, Project Designer (Visual Basic)](../vs140/references-page--project-designer--visual-basic-.md).  
  
 Each source file can contain any number of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statements. These must follow option declarations, such as the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement, and they must precede programming element declarations, such as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statements.  
  
## Example  
 The following example imports a default XML namespace and an XML namespace identified with the prefix <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. It then creates XML literals that use both namespaces.  
  
 [!code[VbXMLSamples#45](../vs140/codesnippet/VisualBasic/imports-statement--xml-namespace-_1.vb)]  
  
 This code displays the following text:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example imports the XML namespace prefix <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. It then creates an XML literal that uses the namespace prefix and displays the element's final form.  
  
 [!code[VbXMLSamples#22](../vs140/codesnippet/VisualBasic/imports-statement--xml-namespace-_2.vb)]  
  
 This code displays the following text:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Notice that the compiler converted the XML namespace prefix from a global prefix to a local prefix definition.  
  
## Example  
 The following example imports the XML namespace prefix <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. It then uses the prefix of the namespace to create an XML literal and access the first child node with the qualified name <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 [!code[VbXMLSamples#19](../vs140/codesnippet/VisualBasic/imports-statement--xml-namespace-_3.vb)]  
  
 This code displays the following text:  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## See Also  
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md)   
 [GetXmlNamespace Operator](../vs140/getxmlnamespace-operator--visual-basic-.md)