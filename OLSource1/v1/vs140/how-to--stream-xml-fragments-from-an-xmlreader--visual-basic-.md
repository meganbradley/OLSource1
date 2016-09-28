---
title: "How to: Stream XML Fragments from an XmlReader (Visual Basic)"
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
ms.assetid: f67ce598-4a12-4dcb-9a07-24deca02a111
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# How to: Stream XML Fragments from an XmlReader (Visual Basic)
When you have to process large XML files, it might not be feasible to load the whole XML tree into memory. This topic shows how to stream fragments using an <xref:System.Xml.XmlReader*>.  
  
 One of the most effective ways to use an <xref:System.Xml.XmlReader*> to read <xref:System.Xml.Linq.XElement*> objects is to write your own custom axis method. An axis method typically returns a collection such as <xref:System.Collections.Generic.IEnumerable`1*> of <xref:System.Xml.Linq.XElement*>, as shown in the example in this topic. In the custom axis method, after you create the XML fragment by calling the [ReadFrom](assetId:///M:System.Xml.Linq.XNode.ReadFrom(System.Xml.XmlReader)?qualifyHint=False&autoUpgrade=True) method, return the collection using `yield return`. This provides deferred execution semantics to your custom axis method.  
  
 When you create an XML tree from an <xref:System.Xml.XmlReader*> object, the <xref:System.Xml.XmlReader*> must be positioned on an element. The assetId:///M:System.Xml.Linq.XNode.ReadFrom(System.Xml.XmlReader)?qualifyHint=False&autoUpgrade=True method does not return until it has read the close tag of the element.  
  
 If you want to create a partial tree, you can instantiate an <xref:System.Xml.XmlReader*>, position the reader on the node that you want to convert to an <xref:System.Xml.Linq.XElement*> tree, and then create the <xref:System.Xml.Linq.XElement*> object.  
  
 The topic [How to: Stream XML Fragments with Access to Header Information (Visual Basic)](../vs140/how-to--stream-xml-fragments-with-access-to-header-information--visual-basic-.md) contains information and an example on how to stream a more complex document.  
  
 The topic [How to: Perform Streaming Transform of Large XML Documents (Visual Basic)](../vs140/how-to--perform-streaming-transform-of-large-xml-documents--visual-basic-.md) contains an example of using LINQ to XML to transform extremely large XML documents while maintaining a small memory footprint.  
  
## Example  
 This example creates a custom axis method. You can query it by using a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query. The custom axis method, `StreamRootChildDoc`, is a method that is designed specifically to read a document that has a repeating `Child` element.  
  
```vb  
Module Module1  
    Sub Main()  
        Dim markup = "<Root>" &  
                     "  <Child Key=""01"">" &  
                     "    <GrandChild>aaa</GrandChild>" &  
                     "  </Child>" &  
                     "  <Child Key=""02"">" &  
                     "    <GrandChild>bbb</GrandChild>" &  
                     "  </Child>" &  
                     "  <Child Key=""03"">" &  
                     "    <GrandChild>ccc</GrandChild>" &  
                     "  </Child>" &  
                     "</Root>"  
  
        Dim grandChildData =  
             From el In New StreamRootChildDoc(New IO.StringReader(markup))  
             Where CInt(el.@Key) > 1  
             Select el.<GrandChild>.Value  
  
        For Each s In grandChildData  
            Console.WriteLine(s)  
        Next  
    End Sub  
End Module  
  
Public Class StreamRootChildDoc  
    Implements IEnumerable(Of XElement)  
  
    Private _stringReader As IO.StringReader  
  
    Public Sub New(ByVal stringReader As IO.StringReader)  
        _stringReader = stringReader  
    End Sub  
  
    Public Function GetEnumerator() As IEnumerator(Of XElement) Implements IEnumerable(Of XElement).GetEnumerator  
        Return New StreamChildEnumerator(_stringReader)  
    End Function  
  
    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator  
        Return Me.GetEnumerator()  
    End Function  
End Class  
  
Public Class StreamChildEnumerator  
    Implements IEnumerator(Of XElement)  
  
    Private _current As XElement  
    Private _reader As Xml.XmlReader  
    Private _stringReader As IO.StringReader  
  
    Public Sub New(ByVal stringReader As IO.StringReader)  
        _stringReader = stringReader  
        _reader = Xml.XmlReader.Create(_stringReader)  
        _reader.MoveToContent()  
    End Sub  
  
    Public ReadOnly Property Current As XElement Implements IEnumerator(Of XElement).Current  
        Get  
            Return _current  
        End Get  
    End Property  
  
    Public ReadOnly Property Current1 As Object Implements IEnumerator.Current  
        Get  
            Return Me.Current  
        End Get  
    End Property  
  
    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext  
        While _reader.Read()  
            Select Case _reader.NodeType  
                Case Xml.XmlNodeType.Element  
                    Dim el = TryCast(XElement.ReadFrom(_reader), XElement)  
                    If el IsNot Nothing Then  
                        _current = el  
                        Return True  
                    End If  
            End Select  
        End While  
  
        Return False  
    End Function  
  
    Public Sub Reset() Implements IEnumerator.Reset  
        _reader = Xml.XmlReader.Create(_stringReader)  
        _reader.MoveToContent()  
    End Sub  
  
#Region "IDisposable Support"  
    Private disposedValue As Boolean ' To detect redundant calls  
  
    ' IDisposable  
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)  
        If Not Me.disposedValue Then  
            If disposing Then  
                _reader.Close()  
            End If  
        End If  
        Me.disposedValue = True  
    End Sub  
  
    Public Sub Dispose() Implements IDisposable.Dispose  
        Dispose(True)  
        GC.SuppressFinalize(Me)  
    End Sub  
#End Region  
  
End Class  
```  
  
 This example produces the following output:  
  
```  
bbb  
ccc  
```  
  
 In this example, the source document is very small. However, even if there were millions of `Child` elements, this example would still have a small memory footprint.  
  
## See Also  
 [Walkthrough: Implementing IEnumerable(Of T) in Visual Basic](../vs140/walkthrough--implementing-ienumerable-of-t--in-visual-basic.md)   
 [Parsing XML (Visual Basic)](../vs140/parsing-xml--visual-basic-.md)