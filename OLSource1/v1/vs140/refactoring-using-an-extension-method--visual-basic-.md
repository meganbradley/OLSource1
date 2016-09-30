---
title: "Refactoring Using an Extension Method (Visual Basic)"
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
ms.assetid: d87ae99a-cfa9-4a31-a5e4-9d6437be6810
caps.latest.revision: 3
---
# Refactoring Using an Extension Method (Visual Basic)
This example builds on the previous example, [Retrieving the Text of the Paragraphs (Visual Basic)](../vs140/retrieving-the-text-of-the-paragraphs--visual-basic-.md), by refactoring the concatenation of strings using a pure function that is implemented as an extension method.  
  
 The previous example used the \<xref:System.Linq.Enumerable.Aggregate*> standard query operator to concatenate multiple strings into one string. However, it is more convenient to write an extension method to do this, because the resulting query smaller and more simple.  
  
## Example  
 This example processes a WordprocessingML document, retrieving the paragraphs, the style of each paragraph, and the text of each paragraph. This example builds on the previous examples in this tutorial.  
  
 The example contains multiple overloads of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
 You can find instructions for creating the source document for this example in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 There are four overloads of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method. One overload simply takes a collection of strings and returns a single string. Another overload can take a collection of any type, and a delegate that projects from a singleton of the collection to a string. There are two more overloads that allow you to specify a separator string.  
  
 The following code uses all four overloads.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 Now, the example can be modified to take advantage of the new extension method:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This example produces the following output when applied to the document described in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Note that this refactoring is a variant of refactoring into a pure function. The next topic will introduce the idea of factoring into pure functions in more detail.  
  
## Next Steps  
 The next example shows how to refactor this code in another way, by using pure functions:  
  
-   [Refactoring Using a Pure Function (Visual Basic)](../vs140/refactoring-using-a-pure-function--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)   
 [Refactoring Into Pure Functions (Visual Basic)](../vs140/refactoring-into-pure-functions--visual-basic-.md)