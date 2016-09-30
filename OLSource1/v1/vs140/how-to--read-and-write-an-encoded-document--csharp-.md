---
title: "How to: Read and Write an Encoded Document (C#)"
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
ms.assetid: 84f64e71-39a6-42c6-ad68-f052bb158a03
caps.latest.revision: 7
---
# How to: Read and Write an Encoded Document (C#)
To create an encoded XML document, you add an \<xref:System.Xml.Linq.XDeclaration*> to the XML tree, setting the encoding to the desired code page name.  
  
 Any value returned by \<xref:System.Text.Encoding.WebName*> is a valid value.  
  
 If you read an encoded document, the \<xref:System.Xml.Linq.XDeclaration.Encoding*> property will be set to the code page name.  
  
 If you set \<xref:System.Xml.Linq.XDeclaration.Encoding*> to a valid code page name, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] will serialize with the specified encoding.  
  
## Example  
 The following example creates two documents, one with utf-8 encoding, and one with utf-16 encoding. It then loads the documents and prints the encoding to the console.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XDeclaration.Encoding*?displayProperty=fullName>   
 [Advanced LINQ to XML Programming (C#)](../vs140/advanced-linq-to-xml-programming--csharp-.md)