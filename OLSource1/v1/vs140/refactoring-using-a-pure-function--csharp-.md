---
title: "Refactoring Using a Pure Function (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: a3416a45-9e12-4e4a-9747-897f06eef510
caps.latest.revision: 7
---
# Refactoring Using a Pure Function (C#)
The following example refactors the previous example, [Refactoring Using an Extension Method (C#)](../vs140/refactoring-using-an-extension-method--csharp-.md), to use a pure function In this example, the code to find the text of a paragraph is moved to the pure static method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 This example processes a WordprocessingML document, retrieving the paragraph nodes from a WordprocessingML document. It also identifies the style of each paragraph. This example builds on the previous examples in this tutorial. The refactored code is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (C#)](../vs140/creating-the-source-office-open-xml-document--csharp-.md).  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the same output as before the refactoring:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Next Steps  
 The next example shows how to project XML into a different shape:  
  
-   [Projecting XML in a Different Shape (C#)](../vs140/projecting-xml-in-a-different-shape--csharp-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (C#)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--csharp-.md)   
 [Refactoring Using an Extension Method (C#)](../vs140/refactoring-using-an-extension-method--csharp-.md)   
 [Refactoring Into Pure Functions (C#)](../vs140/refactoring-into-pure-functions--csharp-.md)