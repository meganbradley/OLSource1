---
title: "How to: Filter on an Optional Element (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: a74b76ad-6889-4185-a189-d6ef2c63841e
caps.latest.revision: 7
---
# How to: Filter on an Optional Element (Visual Basic)
Sometimes you want to filter for an element even though you are not sure it exists in your XML document. The search should be executed so that if the particular element does not have the child element, you do not trigger a null reference exception by filtering for it. In the following example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element does not have a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> child element, but the query still executes correctly.  
  
## Example  
 This example uses the \<xref:System.Xml.Linq.Extensions.Elements*> extension method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.Attribute*?displayProperty=fullName>   
 \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName>   
 \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName>   
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)   
 [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md)   
 [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md)   
 [XML Value Property](../vs140/xml-value-property--visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Projection Operations (Visual Basic)](../vs140/projection-operations--visual-basic-.md)