---
title: "How to: Create a Document with Namespaces (LINQ to XML) (Visual Basic)1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Create a Document with Namespaces (LINQ to XML) (Visual Basic)"
dev_langs: 
  - "VB"
ms.assetid: cc5b0d4d-360c-4ada-94fa-2d2916e989be
caps.latest.revision: 7
---
# How to: Create a Document with Namespaces (LINQ to XML) (Visual Basic)1
This topic shows how to create a document with namespaces in Visual Basic.  
  
 When using XML literals in Visual Basic, users can define one global default XML namespace. This namespace is the default namespace for both XML literals and XML properties. The default XML namespace can be defined at either the project level or the file level. If it is defined at the file level, it overrides the default namespace at the project level.  
  
 You can also define other namespaces, and specify the namespace prefixes for those namespaces.  
  
 You define both default namespaces and namespaces with a prefix by using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword.  
  
 For more information, see [Introduction to XML Literals in Visual Basic](../vs140/introduction-to-xml-literals-in-visual-basic2.md).  
  
 Note that the default XML namespace only applies to elements and not to attributes. Attributes are by default always in no namespace. However, you can use a namespace prefix to put an attribute in a namespace.  
  
## Example  
 This example creates a document that contains a namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example creates a document that contains two namespaces, one of which is the default namespace.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following example creates a document that contains multiple namespaces, both with namespace prefixes.  
  
 When serializing an XML tree, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] emits namespace declarations as required so that each element is in its designated namespace.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md)