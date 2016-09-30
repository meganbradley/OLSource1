---
title: "How to: Transform XML by Using LINQ (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "XML [Visual Basic], transforming"
  - "LINQ to XML [Visual Basic], transforming XML"
ms.assetid: 815687f4-0bc2-4c0b-adc6-d78744aa356f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Transform XML by Using LINQ (Visual Basic)
[XML Literals](../vs140/xml-literals--visual-basic-.md) make it easy to read XML from one source and transform it to a new XML format. You can take advantage of LINQ queries to retrieve the content to transform, or change content in an existing document to a new XML format.  
  
 The example in this topic transforms content from an XML source document to HTML to be viewed in a browser.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To transform an XML document  
  
1.  In Visual Studio, create a new Visual Basic project in the **Console Application** project template.  
  
2.  Double-click the Module1.vb file created in the project to modify the Visual Basic code. Add the following code to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> module. This code creates the source XML document as an \<xref:System.Xml.Linq.XDocument*> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     [Applications typically load XML from an external source such as a string passed as a parameter, or a supplied file or stream. For a demonstration of how to load XML from an external source, see How to: Load XML from a File, String, or Stream (Visual Basic)](../vs140/how-to--load-xml-from-a-file--string--or-stream--visual-basic-.md).  
  
3.  After the code to create the source XML document, add the following code to retrieve all the \<Book> elements from the object and transform them into an HTML document. The list of \<Book> elements is created by using a LINQ query that returns a collection of \<xref:System.Xml.Linq.XElement*> objects that contain the transformed HTML. You can use embedded expressions to put the values from the source document in the new XML format.  
  
     The resulting HTML document is written to a file by using the \<xref:System.Xml.Linq.XElement.Save*> method.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  After <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, add a new method (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) to transform a \<Description> node into the specified HTML format. This method is called by the code in the previous step and is used to preserve the format of the \<Description> elements.  
  
     This method replaces sub-elements of the \<Description> element with HTML. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method is used to preserve the location of the sub-elements. The transformed content of the \<Description> element is included in an HTML paragraph (\<p>) element. The \<xref:System.Xml.Linq.XContainer.Nodes*> property is used to retrieve the transformed content of the \<Description> element. This ensures that sub-elements are included in the transformed content.  
  
     Add the following code after <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  Save your changes.  
  
6.  Press F5 to run the code. The resulting saved document will resemble the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Manipulating XML in Visual Basic](../vs140/manipulating-xml-in-visual-basic.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [How to: Load XML from Files (Visual Basic)](../vs140/how-to--load-xml-from-a-file--string--or-stream--visual-basic-.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)