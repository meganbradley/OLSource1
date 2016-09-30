---
title: "How to: Modify an Office Open XML Document (C#)"
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
ms.assetid: 467d489c-2b1b-453b-a757-8ac180e82a96
caps.latest.revision: 7
---
# How to: Modify an Office Open XML Document (C#)
This topic presents an example that opens an Office Open XML document, modifies it, and saves it.  
  
 For more information on Office Open XML, see [www.openxmldeveloper.org](http://go.microsoft.com/fwlink/?LinkID=95573).  
  
## Example  
 This example finds the first paragraph element in the document. It retrieves the text from the paragraph, and then deletes all text runs in the paragraph. It creates a new text run that consists of the first paragraph text that has been converted to upper case. It then serializes the changed XML into the Open XML package and closes it.  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you open <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> after running this program, you can see that this program converted the first paragraph in the document to upper case.  
  
 When run with the sample Open XML document described in [Creating the Source Office Open XML Document (C#)](../vs140/creating-the-source-office-open-xml-document--csharp-.md), this example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (C#)](../vs140/advanced-query-techniques--linq-to-xml---csharp-.md)