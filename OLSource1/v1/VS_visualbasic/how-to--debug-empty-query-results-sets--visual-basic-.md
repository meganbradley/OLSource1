---
title: "How to: Debug Empty Query Results Sets (Visual Basic)"
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
ms.assetid: b242c90a-d2b8-4309-8a1e-e4e70736c727
caps.latest.revision: 7
---
# How to: Debug Empty Query Results Sets (Visual Basic)
One of the most common problems when querying XML trees is that if the XML tree has a default namespace, the developer sometimes writes the query as though the XML were not in a namespace.  
  
 The first set of examples in this topic shows a typical way that XML in a default namespace is loaded, and is queried improperly.  
  
 The second set of examples show the necessary corrections so that you can query XML in a namespace.  
  
 For more information, see [Working with XML Namespaces (Visual Basic)](../VS_csharp/working-with-xml-namespaces--visual-basic-.md).  
  
## Example  
 This example shows creation of XML in a namespace, and a query that returns an empty result set.  
  
```vb  
Dim root As XElement = _  
    <Root xmlns='http://www.adventure-works.com'>  
        <Child>1</Child>  
        <Child>2</Child>  
        <Child>3</Child>  
        <AnotherChild>4</AnotherChild>  
        <AnotherChild>5</AnotherChild>  
        <AnotherChild>6</AnotherChild>  
    </Root>  
Dim c1 As IEnumerable(Of XElement) = _  
        From el In root.<Child> _  
        Select el  
Console.WriteLine("Result set follows:")  
For Each el As XElement In c1  
    Console.WriteLine(el.Value)  
Next  
Console.WriteLine("End of result set")  
```  
  
 This example produces the following result:  
  
```  
Result set follows:  
End of result set  
```  
  
## Example  
 This example shows creation of XML in a namespace, and a query that is coded properly.  
  
 The solution is to declare and initialize a global default namespace. This places all XML properties in the default namespace. No other modifications are required to the example to make it work properly.  
  
```vb  
Imports <xmlns="http://www.adventure-works.com">  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = _  
            <Root xmlns='http://www.adventure-works.com'>  
                <Child>1</Child>  
                <Child>2</Child>  
                <Child>3</Child>  
                <AnotherChild>4</AnotherChild>  
                <AnotherChild>5</AnotherChild>  
                <AnotherChild>6</AnotherChild>  
            </Root>  
        Dim c1 As IEnumerable(Of XElement) = _  
                From el In root.<Child> _  
                Select el  
        Console.WriteLine("Result set follows:")  
        For Each el As XElement In c1  
            Console.WriteLine(CInt(el))  
        Next  
        Console.WriteLine("End of result set")  
    End Sub  
End Module  
```  
  
 This example produces the following result:  
  
```  
Result set follows:  
1  
2  
3  
End of result set  
```  
  
## See Also  
 [Basic Queries (LINQ to XML) (Visual Basic)](../VS_csharp/basic-queries--linq-to-xml---visual-basic-.md)