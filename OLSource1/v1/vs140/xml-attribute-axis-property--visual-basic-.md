---
title: "XML Attribute Axis Property (Visual Basic)"
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
  - "vb.XmlPropertyAttributeAxis"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "attribute axis property [Visual Basic]"
  - "Visual Basic code, accessing XML"
  - "XML attribute axis property [Visual Basic]"
  - "XML axis [Visual Basic], attribute"
  - "XML [Visual Basic], accessing"
ms.assetid: 7a4777e1-0618-4de9-9510-fb9ace2bf4db
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Attribute Axis Property (Visual Basic)
Provides access to the value of an attribute for an \<xref:System.Xml.Linq.XElement*> object or to the first element in a collection of \<xref:System.Xml.Linq.XElement*> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. An \<xref:System.Xml.Linq.XElement*> object or a collection of \<xref:System.Xml.Linq.XElement*> objects.  
  
 .@  
 Required. Denotes the start of an attribute axis property.  
  
 <  
 Optional. Denotes the beginning of the name of the attribute when <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not a valid identifier in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. Name of the attribute to access, of the form [<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:]<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Part|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. XML namespace prefix for the attribute. Must be a global XML namespace defined with an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. Local attribute name. See [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md).|  
  
 \>  
 Optional. Denotes the end of the name of the attribute when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not a valid identifier in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
## Return Value  
 A string that contains the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the attribute name does not exist, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is returned.  
  
## Remarks  
 You can use an XML attribute axis property to access the value of an attribute by name from an \<xref:System.Xml.Linq.XElement*> object or from the first element in a collection of \<xref:System.Xml.Linq.XElement*> objects. You can retrieve an attribute value by name, or add a new attribute to an element by specifying a new name preceded by the @ identifier.  
  
 When you refer to an XML attribute using the @ identifier, the attribute value is returned as a string and you do not need to explicitly specify the \<xref:System.Xml.Linq.XAttribute.Value*> property.  
  
 The naming rules for XML attributes differ from the naming rules for [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] identifiers. To access an XML attribute that has a name that is not a valid Visual Basic identifier, enclose the name in angle brackets (\< and >).  
  
## XML Namespaces  
 The name in an attribute axis property can use only XML namespace prefixes declared globally by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement. It cannot use XML namespace prefixes declared locally within XML element literals. For more information, see [Imports Statement (XML Namespace Prefix)](../vs140/imports-statement--xml-namespace-.md).  
  
## Example  
 The following example shows how to get the values of the XML attributes named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> from a collection of XML elements that are named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [!code[VbXMLSamples#12](../vs140/codesnippet/VisualBasic/xml-attribute-axis-property--visual-basic-_1.vb)]  
  
 This code displays the following text:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Example  
 The following example shows how to create attributes for an XML element both declaratively, as part of the XML, and dynamically by adding an attribute to an instance of an \<xref:System.Xml.Linq.XElement*> object. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute is created declaratively and the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>r attribute is created dynamically.  
  
 [!code[VbXMLSamples#44](../vs140/codesnippet/VisualBasic/xml-attribute-axis-property--visual-basic-_2.vb)]  
  
 This code displays the following text:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example uses the angle bracket syntax to get the value of the XML attribute named <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, which is not a valid identifier in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
 [!code[VbXMLSamples#13](../vs140/codesnippet/VisualBasic/xml-attribute-axis-property--visual-basic-_3.vb)]  
  
 This code displays the following text:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Example  
 The following example declares <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> as an XML namespace prefix. It then uses the prefix of the namespace to create an XML literal and access the first child node with the qualified name "<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>".  
  
 [!code[VbXMLSamples#14](../vs140/codesnippet/VisualBasic/xml-attribute-axis-property--visual-basic-_4.vb)]  
  
 This code displays the following text:  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md)