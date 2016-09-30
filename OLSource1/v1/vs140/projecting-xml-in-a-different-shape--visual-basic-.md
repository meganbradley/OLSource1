---
title: "Projecting XML in a Different Shape (Visual Basic)"
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
ms.assetid: 2da7ec97-34f7-443d-9a48-b162ac58236b
caps.latest.revision: 3
---
# Projecting XML in a Different Shape (Visual Basic)
This topic shows an example of projecting XML that is in a different shape than the source XML.  
  
 Many typical XML transformations consist of chained queries, as in this example. It is common to start with some form of XML, project intermediate results as collections of anonymous types or named types, and then finally to project the results back into XML that is in an entirely different shape than the source XML.  
  
## Example  
 This example processes a WordprocessingML document, retrieving the paragraph nodes from a WordprocessingML document. It also identifies the style and text of each paragraph. Finally, the example projects XML with a different shape. This example builds on the previous examples in this tutorial. The new statement that does the projection is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Next Steps  
 In the next example, you'll query to find all the text in a Word document:  
  
-   [Finding Text in Word Documents (Visual Basic)](../vs140/finding-text-in-word-documents--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)