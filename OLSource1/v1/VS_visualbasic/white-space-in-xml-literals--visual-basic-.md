---
title: "White Space in XML Literals (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 14
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
# White Space in XML Literals (Visual Basic)
The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler incorporates only the significant white space characters from an XML literal when it creates a [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] object. The insignificant white space characters are not incorporated.  
  
## Significant and Insignificant White Space  
 White space characters in XML literals are significant in only three areas:  
  
-   When they are in an attribute value.  
  
-   When they are part of an element's text content and the text also contains other characters.  
  
-   When they are in an embedded expression for an element's text content.  
  
 Otherwise, the compiler treats white space characters as insignificant and does not include then in the [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] object for the literal.  
  
 To include insignificant white space in an XML literal, use an embedded expression that contains a string literal with the white space.  
  
> [!NOTE]
>  If the `xml:space` attribute appears in an XML element literal, the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler includes the attribute in the \<xref:System.Xml.Linq.XElement> object, but adding this attribute does not change how the compiler treats white space.  
  
## Examples  
 The following example contains two XML elements, outer and inner. Both elements contain white space in their text content. The white space in the outer element is insignificant because it contains only white space and an XML element. The white space in the inner element is significant because it contains white space and text.  
  
 [!code[VbXMLSamples#29](../VS_visualbasic/codesnippet/VisualBasic/white-space-in-xml-literals--visual-basic-_1.vb)]  
  
 When run, this code displays the following text.  
  
```  
<outer>  
  <inner>  
                                          Inner text  
                                      </inner>  
</outer>  
```  
  
## See Also  
 [Creating XML in Visual Basic](../VS_visualbasic/creating-xml-in-visual-basic.md)