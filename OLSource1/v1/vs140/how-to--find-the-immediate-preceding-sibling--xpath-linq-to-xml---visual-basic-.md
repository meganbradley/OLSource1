---
title: "How to: Find the Immediate Preceding Sibling (XPath-LINQ to XML) (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
ms.assetid: ec046283-9fe2-4440-b295-860bf700099d
caps.latest.revision: 7
---
# How to: Find the Immediate Preceding Sibling (XPath-LINQ to XML) (Visual Basic)
Sometimes you want to find the immediate preceding sibling to a node. Due to the difference in the semantics of positional predicates for the preceding sibling axes in XPath as opposed to [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], this is one of the more interesting comparisons.  
  
## Example  
 In this example, the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query uses the <xref:System.Linq.Enumerable.Last?qualifyHint=False> operator to find the last node in the collection returned by <xref:System.Xml.Linq.XNode.ElementsBeforeSelf?qualifyHint=False>. By contrast, the XPath expression uses a predicate with a value of 1 to find the immediately preceding element.  
  
```vb  
Dim root As XElement = _   
    <Root>  
        <Child1/>  
        <Child2/>  
        <Child3/>  
        <Child4/>  
    </Root>  
Dim child4 As XElement = root.Element("Child4")  
  
' LINQ to XML query  
Dim el1 As XElement = child4.ElementsBeforeSelf().Last()  
  
' XPath expression  
Dim el2 As XElement = _  
    DirectCast(child4.XPathEvaluate("preceding-sibling::*[1]"),  _  
    IEnumerable).Cast(Of XElement)().First()  
  
If el1 Is el2 Then  
    Console.WriteLine("Results are identical")  
Else  
    Console.WriteLine("Results differ")  
End If  
Console.WriteLine(el1)  
  
```  
  
 This example produces the following output:  
  
```  
Results are identical  
<Child3 />  
```  
  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)