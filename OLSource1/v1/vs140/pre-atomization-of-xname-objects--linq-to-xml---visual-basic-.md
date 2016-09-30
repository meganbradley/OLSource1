---
title: "Pre-Atomization of XName Objects (LINQ to XML) (Visual Basic)"
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
ms.assetid: 06ea104b-f44c-4bb2-9c34-889ae025c80d
caps.latest.revision: 7
---
# Pre-Atomization of XName Objects (LINQ to XML) (Visual Basic)
One way to improve performance in LINQ to XML is to pre-atomize \<xref:System.Xml.Linq.XName*> objects. Pre-atomization means that you assign a string to an \<xref:System.Xml.Linq.XName*> object before you create the XML tree by using the constructors of the \<xref:System.Xml.Linq.XElement*> and  \<xref:System.Xml.Linq.XAttribute*> classes. Then, instead of passing a string to the constructor, which would use the implicit conversion from string to \<xref:System.Xml.Linq.XName*>, you pass the initialized \<xref:System.Xml.Linq.XName*> object.  
  
 This improves performance when you create a large XML tree in which specific names are repeated. To do this, you declare and initialize \<xref:System.Xml.Linq.XName*> objects before you construct the XML tree, and then use the \<xref:System.Xml.Linq.XName*> objects instead of specifying strings for the element and attribute names. This technique can yield significant performance gains if you are creating a large number of elements (or attributes) with the same name.  
  
 You should test pre-atomization with your scenario to decide if you should use it.  
  
## Example  
 The following example demonstrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example shows the same technique where the XML document is in a namespace:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following example is more similar to what you will likely encounter in the real world. In this example, the content of the element is supplied by a query:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The previous example performs better than the following example, in which names are not pre-atomized:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Performance (LINQ to XML) (Visual Basic)](../vs140/performance--linq-to-xml---visual-basic-.md)   
 [Atomized XName and XNamespace Objects (LINQ to XML) (Visual Basic)](../vs140/atomized-xname-and-xnamespace-objects--linq-to-xml---visual-basic-.md)