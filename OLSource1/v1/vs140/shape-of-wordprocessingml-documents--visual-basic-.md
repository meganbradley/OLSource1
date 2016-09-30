---
title: "Shape of WordprocessingML Documents (Visual Basic)"
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
ms.assetid: 2dfb446b-5a07-4c00-9ab3-a74ba734ff3a
caps.latest.revision: 7
---
# Shape of WordprocessingML Documents (Visual Basic)
This topic introduces the XML shape of a WordprocessingML document.  
  
## Microsoft Office Formats  
 The native file format for the 2007 Microsoft Office system is Office Open XML (commonly called Open XML). Open XML is an XML-based format that an Ecma standard and is currently going through the ISO-IEC standards process. The markup language for word processing files within Open XML is called WordprocessingML. This tutorial uses WordprocessingML source files as input for the examples.  
  
 If you are using Microsoft Office 2003, you can save documents in the Office Open XML format if you have installed the the Microsoft Office Compatibility Pack for Word, Excel, and PowerPoint 2007 File Formats.  
  
## The Shape of WordprocessingML Documents  
 The first thing to understand is the shape of WordprocessingML documents. A WordprocessingML document contains a body element (named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) that contains the paragraphs of the document. Each paragraph contains one or more text runs (named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). Each text run contains one or more text pieces (named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 The following is a very simple WordprocessingML document:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This document contains two paragraphs. They both contain a single text run, and each text run contains a single text piece.  
  
 The easiest way to see the contents of a WordprocessingML document in XML form is to create one using Microsoft Word, save it, and then run the following program that prints the XML to the console.  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## External Resources  
 [Introducing the Office (2007) Open XML File Formats](http://go.microsoft.com/fwlink/?LinkId=98093)  
  
 [Overview of WordprocessingML](http://go.microsoft.com/fwlink/?LinkId=98094)  
  
 [Office 2003: XML Reference Schemas Download page](http://go.microsoft.com/fwlink/?LinkId=98095)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)