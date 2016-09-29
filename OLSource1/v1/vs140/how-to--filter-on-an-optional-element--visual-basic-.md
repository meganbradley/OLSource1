---
title: "How to: Filter on an Optional Element (Visual Basic)"
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
ms.assetid: a74b76ad-6889-4185-a189-d6ef2c63841e
caps.latest.revision: 7
---
# How to: Filter on an Optional Element (Visual Basic)
Sometimes you want to filter for an element even though you are not sure it exists in your XML document. The search should be executed so that if the particular element does not have the child element, you do not trigger a null reference exception by filtering for it. In the following example, the `Child5` element does not have a `Type` child element, but the query still executes correctly.  
  
## Example  
 This example uses the <xref:System.Xml.Linq.Extensions.Elements*> extension method.  
  
```vb  
Dim root As XElement = _   
    <Root>  
        <Child1>  
            <Text>Child One Text</Text>  
            <Type Value="Yes"/>  
        </Child1>  
        <Child2>  
            <Text>Child Two Text</Text>  
            <Type Value="Yes"/>  
        </Child2>  
        <Child3>  
            <Text>Child Three Text</Text>  
            <Type Value="No"/>  
        </Child3>  
        <Child4>  
            <Text>Child Four Text</Text>  
            <Type Value="Yes"/>  
        </Child4>  
        <Child5>  
            <Text>Child Five Text</Text>  
        </Child5>  
    </Root>  
Dim cList As IEnumerable(Of String) = _  
    From typeElement In root.Elements().<Type> _  
    Where typeElement.@Value = "Yes" _  
    Select typeElement.Parent.<Text>.Value  
Dim str As String  
For Each str In cList  
    Console.WriteLine(str)  
Next  
```  
  
 This code produces the following output:  
  
```  
Child One Text  
Child Two Text  
Child Four Text  
```  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
```vb  
Imports <xmlns='http://www.adatum.com'>  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = _  
            <Root>  
                <Child1>  
                    <Text>Child One Text</Text>  
                    <Type Value="Yes"/>  
                </Child1>  
                <Child2>  
                    <Text>Child Two Text</Text>  
                    <Type Value="Yes"/>  
                </Child2>  
                <Child3>  
                    <Text>Child Three Text</Text>  
                    <Type Value="No"/>  
                </Child3>  
                <Child4>  
                    <Text>Child Four Text</Text>  
                    <Type Value="Yes"/>  
                </Child4>  
                <Child5>  
                    <Text>Child Five Text</Text>  
                </Child5>  
            </Root>  
        Dim cList As IEnumerable(Of String) = _  
            From typeElement In root.Elements().<Type> _  
            Where typeElement.@Value = "Yes" _  
            Select typeElement.Parent.<Text>.Value  
        Dim str As String  
        For Each str In cList  
            Console.WriteLine(str)  
        Next  
    End Sub  
End Module  
```  
  
 This code produces the following output:  
  
```  
Child One Text  
Child Two Text  
Child Four Text  
```  
  
## See Also  
 <xref:System.Xml.Linq.XElement.Attribute*?displayProperty=fullName>   
 <xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName>   
 <xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName>   
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)   
 [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md)   
 [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md)   
 [XML Value Property](../vs140/xml-value-property--visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Projection Operations (Visual Basic)](../vs140/projection-operations--visual-basic-.md)