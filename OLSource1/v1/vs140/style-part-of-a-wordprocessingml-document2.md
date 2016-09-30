---
title: "Style Part of a WordprocessingML Document2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Style Part of a WordprocessingML Document"
dev_langs: 
  - "VB"
ms.assetid: 292cc094-9483-4192-ac3b-a5dc51fbac12
caps.latest.revision: 7
---
# Style Part of a WordprocessingML Document2
This topic shows an example of the style part of the Office Open XML WordprocessingML document.  
  
## Example  
 The following example is the XML that makes up the style part of an Office Open XML WordprocessingML document.  
  
 The default paragraph style has an element with the following opening tag:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You need to know this information when you write the query to find the default style identifier, so that the query can identify the style of paragraphs that have the default style.  
  
 Note that these documents are very simple when compared to typical documents that Microsoft Word generates. In many cases, Word saves a great deal of additional information, additional formatting and metadata. Furthermore, Word does not format the lines to be easily readable as in this example; instead, the XML is saved without indentation. However, all WordprocessingML documents share the same basic XML shape. Because of this, the queries presented in this tutorial will work with more complicated documents.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Details of Office Open XML WordprocessingML Documents (Visual Basic)](../vs140/details-of-office-open-xml-wordprocessingml-documents--visual-basic-.md)