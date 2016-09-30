---
title: "WordprocessingML Document with Styles3"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "WordprocessingML Document with Styles"
dev_langs: 
  - "CSharp"
ms.assetid: 40e35de6-ac93-4bba-88ab-a018cbe93873
caps.latest.revision: 7
---
# WordprocessingML Document with Styles3
More complicated WordprocessingML documents have paragraphs that are formatted with styles.  
  
 A few notes about the makeup of WordprocessingML documents are helpful. WordprocessingML documents are stored in packages. Packages have multiple parts (parts have an explicit meaning when used in the context of packages; essentially, parts are files that are zipped together to comprise a package). If a document contains paragraphs that are formatted with styles, there will be a document part that contains paragraphs that have styles applied to them. There will also be a style part that contains the styles that are referred to by the document.  
  
 When accessing packages, it is important that you do so through the relationships between parts, rather than using an arbitrary path. This issue is beyond the scope of the Manipulating Content in a WordprocessingML Document tutorial, but the example programs that are included in this tutorial demonstrate the correct approach.  
  
## A Document that Uses Styles  
 The WordML example presented in the [Shape of WordprocessingML Documents (C#)](../vs140/shape-of-wordprocessingml-documents--csharp-.md) topic is a very simple one. The following document is more complicated: It has paragraphs that are formatted with styles. The easiest way to see the XML that makes up an Office Open XML document is to run the [Example that Outputs Office Open XML Document Parts (C#)](../vs140/example-that-outputs-office-open-xml-document-parts--csharp-.md).  
  
 In the following document, the first paragraph has the style <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. There are a number of paragraphs that have the default style. There are also a number of paragraphs that have the style <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Because of this relative complexity, this is a more interesting document to parse with LINQ to XML.  
  
 In those paragraphs with non-default styles, the paragraph elements have a child element named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which in turn has a child element <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. That element has an attribute, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which contains the style name. If the paragraph has the default style, it means that the paragraph element does not have a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> child element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Details of Office Open XML WordprocessingML Documents (C#)](../vs140/details-of-office-open-xml-wordprocessingml-documents--csharp-.md)