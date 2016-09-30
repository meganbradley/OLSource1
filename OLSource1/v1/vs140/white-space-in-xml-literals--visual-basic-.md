---
title: "White Space in XML Literals (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "white space [XML in Visual Basic]"
  - "XML literals [Visual Basic], white space"
ms.assetid: dfe3a9ff-d69a-418e-a6b5-476f4ed84219
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# White Space in XML Literals (Visual Basic)
The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler incorporates only the significant white space characters from an XML literal when it creates a [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object. The insignificant white space characters are not incorporated.  
  
## Significant and Insignificant White Space  
 White space characters in XML literals are significant in only three areas:  
  
-   When they are in an attribute value.  
  
-   When they are part of an element's text content and the text also contains other characters.  
  
-   When they are in an embedded expression for an element's text content.  
  
 Otherwise, the compiler treats white space characters as insignificant and does not include then in the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object for the literal.  
  
 To include insignificant white space in an XML literal, use an embedded expression that contains a string literal with the white space.  
  
> [!NOTE]
>  If the `xml:space` attribute appears in an XML element literal, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler includes the attribute in the \<xref:System.Xml.Linq.XElement*> object, but adding this attribute does not change how the compiler treats white space.  
  
## Examples  
 The following example contains two XML elements, outer and inner. Both elements contain white space in their text content. The white space in the outer element is insignificant because it contains only white space and an XML element. The white space in the inner element is significant because it contains white space and text.  
  
 [!code[VbXMLSamples#29](../vs140/codesnippet/VisualBasic/white-space-in-xml-literals--visual-basic-_1.vb)]  
  
 When run, this code displays the following text.  
  
```  
<outer>  
  <inner>  
                                          Inner text  
                                      </inner>  
</outer>  
```  
  
## See Also  
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)