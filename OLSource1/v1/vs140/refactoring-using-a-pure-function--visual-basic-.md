---
title: "Refactoring Using a Pure Function (Visual Basic)"
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
ms.assetid: af0ea62f-4f57-4868-b624-a85524055935
caps.latest.revision: 7
---
# Refactoring Using a Pure Function (Visual Basic)
The following example refactors the previous example, [Refactoring Using an Extension Method (Visual Basic)](../vs140/refactoring-using-an-extension-method--visual-basic-.md), to use a pure function In this example, the code to find the text of a paragraph is moved to the pure static method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 This example processes a WordprocessingML document, retrieving the paragraph nodes from a WordprocessingML document. It also identifies the style of each paragraph. This example builds on the previous examples in this tutorial. The refactored code is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the same output as before the refactoring:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Next Steps  
 The next example shows how to project XML into a different shape:  
  
-   [Projecting XML in a Different Shape (Visual Basic)](../vs140/projecting-xml-in-a-different-shape--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)   
 [Refactoring Using an Extension Method (Visual Basic)](../vs140/refactoring-using-an-extension-method--visual-basic-.md)   
 [Refactoring Into Pure Functions (Visual Basic)](../vs140/refactoring-into-pure-functions--visual-basic-.md)