---
title: "Finding the Default Paragraph Style (Visual Basic)"
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
ms.assetid: 9d094a4a-ec8c-41b0-b7ab-a3deb2a01d45
caps.latest.revision: 5
---
# Finding the Default Paragraph Style (Visual Basic)
The first task in the Manipulating Information in a WordprocessingML Document tutorial is to find the default style of paragraphs in the document.  
  
## Example  
  
### Description  
 The following example opens an Office Open XML WordprocessingML document, finds the document and style parts of the package, and then executes a query that finds the default style name. For information about Office Open XML document packages, and the parts they consist of, see [Details of Office Open XML WordprocessingML Documents (Visual Basic)](../vs140/details-of-office-open-xml-wordprocessingml-documents--visual-basic-.md).  
  
 The query finds a node named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that has an attribute named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with a value of "paragraph", and also has an attribute named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with a value of "1". Because there will be only one XML node with these attributes, the query uses the \<xref:System.Linq.Enumerable.First*?displayProperty=fullName> operator to convert a collection to a singleton. It then gets the value of the attribute with the name <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Comments  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Next Steps  
 In the next example, you'll create a similar query that finds all the paragraphs in a document and their styles:  
  
-   [Retrieving the Paragraphs and Their Styles (Visual Basic)](../vs140/retrieving-the-paragraphs-and-their-styles--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)