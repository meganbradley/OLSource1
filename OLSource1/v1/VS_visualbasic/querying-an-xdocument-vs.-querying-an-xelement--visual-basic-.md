---
title: "Querying an XDocument vs. Querying an XElement (Visual Basic)"
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
ms.assetid: 2d111f84-0ded-4cde-8d93-5440557a726d
caps.latest.revision: 5
---
# Querying an XDocument vs. Querying an XElement (Visual Basic)
When you load a document via <xref:System.Xml.Linq.XDocument.Load*?displayProperty=fullName>, you will notice that you have to write queries slightly differently than when you load via <xref:System.Xml.Linq.XElement.Load*?displayProperty=fullName>.  
  
## Comparison of XDocument.Load and XElement.Load  
 When you load an XML document into an <xref:System.Xml.Linq.XElement*> via <xref:System.Xml.Linq.XElement.Load*?displayProperty=fullName>, the <xref:System.Xml.Linq.XElement*> at the root of the XML tree contains the root element of the loaded document. However, when you load the same XML document into an <xref:System.Xml.Linq.XDocument*> via <xref:System.Xml.Linq.XDocument.Load*?displayProperty=fullName>, the root of the tree is an <xref:System.Xml.Linq.XDocument*> node, and the root element of the loaded document is the one allowed child <xref:System.Xml.Linq.XElement*> node of the <xref:System.Xml.Linq.XDocument*>. The [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)] axes operate relative to the root node.  
  
 This first example loads an XML tree using <xref:System.Xml.Linq.XElement.Load*>. It then queries for the child elements of the root of the tree.  
  
```vb  
' Create a simple document and  write it to a file  
File.WriteAllText("Test.xml", "<Root>" + Environment.NewLine + _  
    "    <Child1>1</Child1>" + Environment.NewLine + _  
    "    <Child2>2</Child2>" + Environment.NewLine + _  
    "    <Child3>3</Child3>" + Environment.NewLine + _  
    "</Root>")  
  
Console.WriteLine("Querying tree loaded with XElement.Load")  
Console.WriteLine("----")  
Dim doc As XElement = XElement.Load("Test.xml")  
Dim childList As IEnumerable(Of XElement) = _  
        From el In doc.Elements() _  
        Select el  
For Each e As XElement In childList  
    Console.WriteLine(e)  
Next  
```  
  
 As expected, this example produces the following output:  
  
```  
Querying tree loaded with XElement.Load  
----  
<Child1>1</Child1>  
<Child2>2</Child2>  
<Child3>3</Child3>  
```  
  
 The following example is the same as the one above, with the exception that the XML tree is loaded into an <xref:System.Xml.Linq.XDocument*> instead of an <xref:System.Xml.Linq.XElement*>.  
  
```vb  
' Create a simple document and  write it to a file  
File.WriteAllText("Test.xml", "<Root>" + Environment.NewLine + _  
    "    <Child1>1</Child1>" + Environment.NewLine + _  
    "    <Child2>2</Child2>" + Environment.NewLine + _  
    "    <Child3>3</Child3>" + Environment.NewLine + _  
    "</Root>")  
  
Console.WriteLine("Querying tree loaded with XDocument.Load")  
Console.WriteLine("----")  
Dim doc As XDocument = XDocument.Load("Test.xml")  
Dim childList As IEnumerable(Of XElement) = _  
        From el In doc.Elements() _  
        Select el  
For Each e As XElement In childList  
    Console.WriteLine(e)  
Next  
```  
  
 This example produces the following output:  
  
```  
Querying tree loaded with XDocument.Load  
----  
<Root>  
  <Child1>1</Child1>  
  <Child2>2</Child2>  
  <Child3>3</Child3>  
</Root>  
```  
  
 Notice that the same query returned the one `Root` node instead of the three child nodes.  
  
 One approach to dealing with this is to use the <xref:System.Xml.Linq.XDocument.Root*> property before accessing the axes methods, as follows:  
  
```vb  
' Create a simple document and  write it to a file  
File.WriteAllText("Test.xml", "<Root>" + Environment.NewLine + _  
    "    <Child1>1</Child1>" + Environment.NewLine + _  
    "    <Child2>2</Child2>" + Environment.NewLine + _  
    "    <Child3>3</Child3>" + Environment.NewLine + _  
    "</Root>")  
  
Console.WriteLine("Querying tree loaded with XDocument.Load")  
Console.WriteLine("----")  
Dim doc As XDocument = XDocument.Load("Test.xml")  
Dim childList As IEnumerable(Of XElement) = _  
        From el In doc.Root.Elements() _  
        Select el  
For Each e As XElement In childList  
    Console.WriteLine(e)  
Next  
```  
  
 This query now performs in the same way as the query on the tree rooted in <xref:System.Xml.Linq.XElement*>. The example produces the following output:  
  
```  
Querying tree loaded with XDocument.Load  
----  
<Child1>1</Child1>  
<Child2>2</Child2>  
<Child3>3</Child3>  
```  
  
## See Also  
 [Basic Queries (LINQ to XML) (Visual Basic)](../VS_csharp/basic-queries--linq-to-xml---visual-basic-.md)