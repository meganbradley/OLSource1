---
title: "Collections (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "VB"
ms.assetid: 5f7749f3-aaf2-4319-b63c-bfa72e1e2b7a
caps.latest.revision: 4
ms.author: "shoag"
manager: "wpickett"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Collections (Visual Basic)
\<?xml version="1.0" encoding="UTF-8"?>
\<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd" xmlns:xlink="http://www.w3.org/1999/xlink">
    <introduction>
    <para>For many applications, you want to create and manage groups of related objects. There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.</para>
    <para>Arrays are most useful for creating and working with a fixed number of strongly-typed objects. For information about arrays, see \<link xlink:href="dbf29737-b589-4443-bee6-a27588d9c67e">Arrays in Visual Basic</link>.</para>
    <para>Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.</para>
    <para>A collection is a class, so you must declare an instance of the class before you can add elements to that collection.</para>
    <para>If your collection contains elements of only one data type, you can use one of the classes in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace. A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.</para>
    <alert class="note">
      <para>For the examples in this topic, include \<legacyLink xlink:href="7062f8aa-d890-4232-9eed-92836e13fb6e">Imports</legacyLink> statements for the <unmanagedCodeEntityReference>System.Collections.Generic</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>System.Linq</unmanagedCodeEntityReference> namespaces.</para>
    </alert>
    <para>
      <embeddedLabel>In this topic</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>
          \<link xlink:href="#BKMK_SimpleCollection">Using a Simple Collection</link>
        </para>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="e76533a9-5033-4a0b-b003-9c2be60d185b#BKMK_KindsOfCollections">Kinds of Collections</link>
        </para>
        <list class="bullet">
          <listItem>
            <para>
              \<link xlink:href="#BKMK_Generic">System.Collections.Generic Classes</link>
            </para>
          </listItem>
          <listItem>
            <para>
              \<link xlink:href="#BKMK_Concurrent">System.Collections.Concurrent Classes</link>
            </para>
          </listItem>
          <listItem>
            <para>
              \<link xlink:href="#BKMK_Collections">System.Collections Classes</link>
            </para>
          </listItem>
          <listItem>
            <para>
              \<link xlink:href="#BKMK_VisualBasic">Visual Basic Collection Class</link>
            </para>
          </listItem>
        </list>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="#BKMK_KeyValuePairs">Implementing a Collection of Key/Value Pairs</link>
        </para>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="#BKMK_LINQ">Using LINQ to Access a Collection</link>
        </para>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="#BKMK_Sorting">Sorting a Collection</link>
        </para>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="#BKMK_CustomCollection">Defining a Custom Collection</link>
        </para>
      </listItem>
      <listItem>
        <para>
          \<link xlink:href="#BKMK_Iterators">Iterators</link>
        </para>
      </listItem>
    </list>
  </introduction>
    <section address="BKMK_SimpleCollection">
    <title>Using a Simple Collection</title>
    <content>
      <para>The examples in this section use the generic <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference> class, which enables you to work with a strongly typed list of objects.</para>
      <para>The following example creates a list of strings and then iterates through the strings by using a <legacyLink xlink:href="ebce3120-95c3-42b1-b70b-fa7da40c75e2">For Each…Next</legacyLink> statement.</para>
      <code language="vb">' Create a list of strings.
Dim salmons As New List(Of String)
salmons.Add("chinook")
salmons.Add("coho")
salmons.Add("pink")
salmons.Add("sockeye")

' Iterate through the list.
For Each salmon As String In salmons
    Console.Write(salmon &amp; " ")
Next
'Output: chinook coho pink sockeye</code>
      <para>If the contents of a collection are known in advance, you can use a <newTerm>collection initializer</newTerm> to initialize the collection. For more information, see <link xlink:href="a9290329-77b0-4fdf-ae75-8fc17287f469">Collection Initializers Overview (Visual Basic)</link>.</para>
      <para>The following example is the same as the previous example, except a collection initializer is used to add elements to the collection.</para>
      <code language="vb">' Create a list of strings by using a
' collection initializer.
Dim salmons As New List(Of String) From
    {"chinook", "coho", "pink", "sockeye"}

For Each salmon As String In salmons
    Console.Write(salmon &amp; " ")
Next
'Output: chinook coho pink sockeye</code>
      <para>You can use a <legacyLink xlink:href="f5fc0d51-67ce-4c36-9f09-31c9a91c94e9">For…Next</legacyLink> statement instead of a <languageKeyword>For Each</languageKeyword> statement to iterate through a collection. You accomplish this by accessing the collection elements by the index position. The index of the elements starts at 0 and ends at the element count minus 1.</para>
      <para>The following example iterates through the elements of a collection by using <languageKeyword>For…Next</languageKeyword> instead of <languageKeyword>For Each</languageKeyword>.</para>
      <code language="vb">Dim salmons As New List(Of String) From
    {"chinook", "coho", "pink", "sockeye"}

For index = 0 To salmons.Count - 1
    Console.Write(salmons(index) &amp; " ")
Next
'Output: chinook coho pink sockeye</code>
      <para>The following example removes an element from the collection by specifying the object to remove.</para>
      <code language="vb">' Create a list of strings by using a
' collection initializer.
Dim salmons As New List(Of String) From
    {"chinook", "coho", "pink", "sockeye"}

' Remove an element in the list by specifying
' the object.
salmons.Remove("coho")

For Each salmon As String In salmons
    Console.Write(salmon &amp; " ")
Next
'Output: chinook pink sockeye</code>
      <para>The following example removes elements from a generic list. Instead of a <languageKeyword>For Each</languageKeyword> statement, a <legacyLink xlink:href="f5fc0d51-67ce-4c36-9f09-31c9a91c94e9">For…Next</legacyLink> statement that iterates in descending order is used. This is because the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.List`1.RemoveAt(System.Int32)</codeEntityReference> method causes elements after a removed element to have a lower index value.</para>
      <code language="vb">Dim numbers As New List(Of Integer) From
    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}

' Remove odd numbers.
For index As Integer = numbers.Count - 1 To 0 Step -1
    If numbers(index) Mod 2 = 1 Then
        ' Remove the element by specifying
        ' the zero-based index in the list.
        numbers.RemoveAt(index)
    End If
Next

' Iterate through the list.
' A lambda expression is placed in the ForEach method
' of the List(T) object.
numbers.ForEach(
    Sub(number) Console.Write(number &amp; " "))
' Output: 0 2 4 6 8</code>
      <para>For the type of elements in the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference>, you can also define your own class. In the following example, the <codeInline>Galaxy</codeInline> class that is used by the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference> is defined in the code.</para>
      <code language="vb">Private Sub IterateThroughList()
    Dim theGalaxies As New List(Of Galaxy) From
        {
            New Galaxy With {.Name = "Tadpole", .MegaLightYears = 400},
            New Galaxy With {.Name = "Pinwheel", .MegaLightYears = 25},
            New Galaxy With {.Name = "Milky Way", .MegaLightYears = 0},
            New Galaxy With {.Name = "Andromeda", .MegaLightYears = 3}
        }

    For Each theGalaxy In theGalaxies
        With theGalaxy
            Console.WriteLine(.Name &amp; "  " &amp; .MegaLightYears)
        End With
    Next

    ' Output:
    '  Tadpole  400
    '  Pinwheel  25
    '  Milky Way  0
    '  Andromeda  3
End Sub

Public Class Galaxy
    Public Property Name As String
    Public Property MegaLightYears As Integer
End Class</code>
    </content>
  </section>
    <section address="BKMK_KindsOfCollections">
    <title>Kinds of Collections</title>
    <content>
      <para>Many common collections are provided by the .NET Framework. For a complete list, see collections namespace.  Each type of collection is designed for a specific purpose.</para>
      <para>Some of the common collection classes are described in this section:</para>
      <list class="bullet">
        <listItem>
          <para>
            <unmanagedCodeEntityReference>System.Collections.Generic</unmanagedCodeEntityReference> classes</para>
        </listItem>
        <listItem>
          <para>
            <unmanagedCodeEntityReference>System.Collections.Concurrent</unmanagedCodeEntityReference> classes</para>
        </listItem>
        <listItem>
          <para>
            <unmanagedCodeEntityReference>System.Collections</unmanagedCodeEntityReference> classes</para>
        </listItem>
        <listItem>
          <para>Visual Basic <languageKeyword>Collection</languageKeyword> class</para>
        </listItem>
      </list>
    </content>
    <sections>
      <section address="BKMK_Generic">
        <title>System.Collections.Generic Classes</title>
        <content>
          <para>You can create a generic collection by using one of the classes in the <codeEntityReference autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace. A generic collection is useful when every item in the collection has the same data type. A generic collection enforces strong typing by allowing only the desired data type to be added.</para>
          <para>The following table lists some of the frequently used classes of the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace:</para>
          <table>
            <tbody>
              <tr>
                <TD>
                  <para>Class</para>
                </TD>
                <TD>
                  <para>Description </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.Dictionary`2</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a collection of key/value pairs that are organized based on the key. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.List`1</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.Queue`1</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a first in, first out (FIFO) collection of objects. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.SortedList`2</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a collection of key/value pairs that are sorted by key based on the associated <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.IComparer`1</codeEntityReference> implementation. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.Stack`1</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a last in, first out (LIFO) collection of objects. </para>
                </TD>
              </tr>
            </tbody>
          </table>
          <para>For additional information, see \<link xlink:href="f5d4c6a4-0d7b-4944-a9fb-3b12d9ebfd55">Commonly Used Collection Types</link>, \<link xlink:href="ba049f9a-ce87-4cc4-b319-3f75c8ddac8a">Selecting a Collection Class</link>, and <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference>.</para>
        </content>
      </section>
      <section address="BKMK_Concurrent">
        <title>System.Collections.Concurrent Classes</title>
        <content>
          <para>In the .NET Framework 4 or newer, the collections in the <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference> namespace provide efficient thread-safe operations for accessing collection items from multiple threads.</para>
          <para>The classes in the <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference> namespace should be used instead of the corresponding types in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> and <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections</codeEntityReference> namespaces whenever multiple threads are accessing the collection concurrently. For more information, see \<link xlink:href="2e7ca21f-786c-4367-96be-0cf3f3dcc6bd">Thread-Safe Collections</link> and <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference>.</para>
          <para>Some classes included in the <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference> namespace are <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Concurrent.BlockingCollection`1</codeEntityReference>, <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Concurrent.ConcurrentDictionary`2</codeEntityReference>, <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Concurrent.ConcurrentQueue`1</codeEntityReference>, and <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Concurrent.ConcurrentStack`1</codeEntityReference>.</para>
        </content>
      </section>
      <section address="BKMK_Collections">
        <title>System.Collections Classes</title>
        <content>
          <para>The classes in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections</codeEntityReference> namespace do not store elements as specifically typed objects, but as objects of type <languageKeyword>Object</languageKeyword>.</para>
          <para>Whenever possible, you should use the generic collections in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace or the <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference> namespace instead of the legacy types in the <unmanagedCodeEntityReference>System.Collections</unmanagedCodeEntityReference> namespace.</para>
          <para>The following table lists some of the frequently used classes in the <unmanagedCodeEntityReference>System.Collections</unmanagedCodeEntityReference> namespace:</para>
          <table>
            <tbody>
              <tr>
                <TD>
                  <para>Class</para>
                </TD>
                <TD>
                  <para>Description </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.ArrayList</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents an array of objects whose size is dynamically increased as required. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Hashtable</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a collection of key/value pairs that are organized based on the hash code of the key. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Queue</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a first in, first out (FIFO) collection of objects. </para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>
                    <codeEntityReference autoUpgrade="true">T:System.Collections.Stack</codeEntityReference>
                  </para>
                </TD>
                <TD>
                  <para>Represents a last in, first out (LIFO) collection of objects. </para>
                </TD>
              </tr>
            </tbody>
          </table>
          <para>The <codeEntityReference autoUpgrade="true">N:System.Collections.Specialized</codeEntityReference> namespace provides specialized and strongly typed collection classes, such as string-only collections and linked-list and hybrid dictionaries.</para>
        </content>
      </section>
      <section address="BKMK_VisualBasic">
        <title>Visual Basic Collection Class</title>
        <content>
          <para>You can use the Visual Basic <codeEntityReference autoUpgrade="true" qualifyHint="false">T:Microsoft.VisualBasic.Collection</codeEntityReference> class to access a collection item by using either a numeric index or a <languageKeyword>String</languageKeyword> key. You can add items to a collection object either with or without specifying a key. If you add an item without a key, you must use its numeric index to access it.</para>
          <para>The Visual Basic <languageKeyword>Collection</languageKeyword> class stores all its elements as type <languageKeyword>Object</languageKeyword>, so you can add an item of any data type. There is no safeguard against inappropriate data types being added.</para>
          <para>When you use the Visual Basic <languageKeyword>Collection</languageKeyword> class, the first item in a collection has an index of 1. This differs from the .NET Framework collection classes, for which the starting index is 0.</para>
          <para>Whenever possible, you should use the generic collections in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace or the <codeEntityReference>N:System.Collections.Concurrent</codeEntityReference> namespace instead of the Visual Basic <languageKeyword>Collection</languageKeyword> class.</para>
          <para> For more information, see <codeEntityReference autoUpgrade="true">T:Microsoft.VisualBasic.Collection</codeEntityReference>.</para>
        </content>
      </section>
    </sections>
  </section><section address="BKMK_KeyValuePairs">
    <title>Implementing a Collection of Key/Value Pairs</title>
    <content>
      <para>The <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.Dictionary`2</codeEntityReference> generic collection enables you to access to elements in a collection by using the key of each element. Each addition to the dictionary consists of a value and its associated key. Retrieving a value by using its key is fast because the <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> class is implemented as a hash table.</para>
      <para>The following example creates a <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> collection and iterates through the dictionary by using a <languageKeyword>For Each</languageKeyword> statement.</para>
      <code language="vb">Private Sub IterateThroughDictionary()
    Dim elements As Dictionary(Of String, Element) = BuildDictionary()

    For Each kvp As KeyValuePair(Of String, Element) In elements
        Dim theElement As Element = kvp.Value

        Console.WriteLine("key: " &amp; kvp.Key)
        With theElement
            Console.WriteLine("values: " &amp; .Symbol &amp; " " &amp;
                .Name &amp; " " &amp; .AtomicNumber)
        End With
    Next
End Sub

Private Function BuildDictionary() As Dictionary(Of String, Element)
    Dim elements As New Dictionary(Of String, Element)

    AddToDictionary(elements, "K", "Potassium", 19)
    AddToDictionary(elements, "Ca", "Calcium", 20)
    AddToDictionary(elements, "Sc", "Scandium", 21)
    AddToDictionary(elements, "Ti", "Titanium", 22)

    Return elements
End Function

Private Sub AddToDictionary(ByVal elements As Dictionary(Of String, Element),
ByVal symbol As String, ByVal name As String, ByVal atomicNumber As Integer)
    Dim theElement As New Element

    theElement.Symbol = symbol
    theElement.Name = name
    theElement.AtomicNumber = atomicNumber

    elements.Add(Key:=theElement.Symbol, value:=theElement)
End Sub

Public Class Element
    Public Property Symbol As String
    Public Property Name As String
    Public Property AtomicNumber As Integer
End Class</code>
      <para>To instead use a collection initializer to build the <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> collection, you can replace the <codeInline>BuildDictionary</codeInline> and <codeInline>AddToDictionary</codeInline> methods with the following method.</para>
      <code language="vb">Private Function BuildDictionary2() As Dictionary(Of String, Element)
    Return New Dictionary(Of String, Element) From
        {
            {"K", New Element With
                {.Symbol = "K", .Name = "Potassium", .AtomicNumber = 19}},
            {"Ca", New Element With
                {.Symbol = "Ca", .Name = "Calcium", .AtomicNumber = 20}},
            {"Sc", New Element With
                {.Symbol = "Sc", .Name = "Scandium", .AtomicNumber = 21}},
            {"Ti", New Element With
                {.Symbol = "Ti", .Name = "Titanium", .AtomicNumber = 22}}
        }
End Function</code>
      <para>The following example uses the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.Dictionary`2.ContainsKey(`0)</codeEntityReference> method and the <codeEntityReference autoUpgrade="true" qualifyHint="false">P:System.Collections.Generic.Dictionary`2.Item(`0)</codeEntityReference> property of <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> to quickly find an item by key. The <unmanagedCodeEntityReference>Item</unmanagedCodeEntityReference> property enables you to access an item in the <codeInline>elements</codeInline> collection by using the <codeInline>elements(symbol)</codeInline> code in Visual Basic.</para>
      <code language="vb">Private Sub FindInDictionary(ByVal symbol As String)
    Dim elements As Dictionary(Of String, Element) = BuildDictionary()

    If elements.ContainsKey(symbol) = False Then
        Console.WriteLine(symbol &amp; " not found")
    Else
        Dim theElement = elements(symbol)
        Console.WriteLine("found: " &amp; theElement.Name)
    End If
End Sub</code>
      <para>The following example instead uses the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.Dictionary`2.TryGetValue(`0,`1@)</codeEntityReference> method quickly find an item by key.</para>
      <code language="vb">Private Sub FindInDictionary2(ByVal symbol As String)
    Dim elements As Dictionary(Of String, Element) = BuildDictionary()

    Dim theElement As Element = Nothing
    If elements.TryGetValue(symbol, theElement) = False Then
        Console.WriteLine(symbol &amp; " not found")
    Else
        Console.WriteLine("found: " &amp; theElement.Name)
    End If
End Sub</code>
    </content>
  </section><section address="BKMK_LINQ">
    <title>Using LINQ to Access a Collection</title>
    <content>
      <para>LINQ (Language-Integrated Query) can be used to access collections. LINQ queries provide filtering, ordering, and grouping capabilities. For more information, see \<link xlink:href="53c66373-ff43-431f-b4bb-f98362830279">Getting Started with LINQ in Visual Basic</link>.</para>
      <para>The following example runs a LINQ query against a generic <unmanagedCodeEntityReference>List</unmanagedCodeEntityReference>. The LINQ query returns a different collection that contains the results.</para>
      <code language="vb">Private Sub ShowLINQ()
    Dim elements As List(Of Element) = BuildList()

    ' LINQ Query.
    Dim subset = From theElement In elements
                  Where theElement.AtomicNumber &lt; 22
                  Order By theElement.Name

    For Each theElement In subset
        Console.WriteLine(theElement.Name &amp; " " &amp; theElement.AtomicNumber)
    Next

    ' Output:
    '  Calcium 20
    '  Potassium 19
    '  Scandium 21
End Sub

Private Function BuildList() As List(Of Element)
    Return New List(Of Element) From
        {
            {New Element With
                {.Symbol = "K", .Name = "Potassium", .AtomicNumber = 19}},
            {New Element With
                {.Symbol = "Ca", .Name = "Calcium", .AtomicNumber = 20}},
            {New Element With
                {.Symbol = "Sc", .Name = "Scandium", .AtomicNumber = 21}},
            {New Element With
                {.Symbol = "Ti", .Name = "Titanium", .AtomicNumber = 22}}
        }
End Function

Public Class Element
    Public Property Symbol As String
    Public Property Name As String
    Public Property AtomicNumber As Integer
End Class</code>
    </content>
  </section><section address="BKMK_Sorting">
    <title>Sorting a Collection</title>
    <content>
      <para>The following example illustrates a procedure for sorting a collection. The example sorts instances of the <codeInline>Car</codeInline> class that are stored in a <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference>. The <codeInline>Car</codeInline> class implements the <codeEntityReference>T:System.IComparable`1</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.IComparable`1.CompareTo(`0)</codeEntityReference> method be implemented.</para>
      <para>Each call to the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.IComparable`1.CompareTo(`0)</codeEntityReference> method makes a single comparison that is used for sorting. User-written code in the <unmanagedCodeEntityReference>CompareTo</unmanagedCodeEntityReference> method returns a value for each comparison of the current object with another object. The value returned is less than zero if the current object is less than the other object, greater than zero if the current object is greater than the other object, and zero if they are equal. This enables you to define in code the criteria for greater than, less than, and equal.</para>
      <para>In the <codeInline>ListCars</codeInline> method, the <codeInline>cars.Sort()</codeInline> statement sorts the list. This call to the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.List`1.Sort</codeEntityReference> method of the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference> causes the <unmanagedCodeEntityReference>CompareTo</unmanagedCodeEntityReference> method to be called automatically for the <codeInline>Car</codeInline> objects in the <unmanagedCodeEntityReference>List</unmanagedCodeEntityReference>. </para>
      <code language="vb">Public Sub ListCars()

    ' Create some new cars.
    Dim cars As New List(Of Car) From
    {
        New Car With {.Name = "car1", .Color = "blue", .Speed = 20},
        New Car With {.Name = "car2", .Color = "red", .Speed = 50},
        New Car With {.Name = "car3", .Color = "green", .Speed = 10},
        New Car With {.Name = "car4", .Color = "blue", .Speed = 50},
        New Car With {.Name = "car5", .Color = "blue", .Speed = 30},
        New Car With {.Name = "car6", .Color = "red", .Speed = 60},
        New Car With {.Name = "car7", .Color = "green", .Speed = 50}
    }

    ' Sort the cars by color alphabetically, and then by speed
    ' in descending order.
    cars.Sort()

    ' View all of the cars.
    For Each thisCar As Car In cars
        Console.Write(thisCar.Color.PadRight(5) &amp; " ")
        Console.Write(thisCar.Speed.ToString &amp; " ")
        Console.Write(thisCar.Name)
        Console.WriteLine()
    Next

    ' Output:
    '  blue  50 car4
    '  blue  30 car5
    '  blue  20 car1
    '  green 50 car7
    '  green 10 car3
    '  red   60 car6
    '  red   50 car2
End Sub

Public Class Car
    Implements IComparable(Of Car)

    Public Property Name As String
    Public Property Speed As Integer
    Public Property Color As String

    Public Function CompareTo(ByVal other As Car) As Integer _
        Implements System.IComparable(Of Car).CompareTo
        ' A call to this method makes a single comparison that is
        ' used for sorting.

        ' Determine the relative order of the objects being compared.
        ' Sort by color alphabetically, and then by speed in
        ' descending order.

        ' Compare the colors.
        Dim compare As Integer
        compare = String.Compare(Me.Color, other.Color, True)

        ' If the colors are the same, compare the speeds.
        If compare = 0 Then
            compare = Me.Speed.CompareTo(other.Speed)

            ' Use descending order for speed.
            compare = -compare
        End If

        Return compare
    End Function
End Class</code>
    </content>
  </section><section address="BKMK_CustomCollection">
    <title>Defining a Custom Collection</title>
    <content>
      <para>You can define a collection by implementing the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.IEnumerable`1</codeEntityReference> or <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerable</codeEntityReference> interface. For additional information, see \<legacyLink xlink:href="71807ea7-9180-48a6-916f-35a5251d477f">Enumerating a Collection</legacyLink>.</para>
      <para>Although you can define a custom collection, it is usually better to instead use the collections that are included in the .NET Framework, which are described in \<link xlink:href="e76533a9-5033-4a0b-b003-9c2be60d185b#BKMK_KindsOfCollections">Kinds of Collections</link> earlier in this topic.</para>
      <para>The following example defines a custom collection class named <codeInline>AllColors</codeInline>. This class implements the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerable</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerable.GetEnumerator</codeEntityReference> method be implemented.</para>
      <para>The <unmanagedCodeEntityReference>GetEnumerator</unmanagedCodeEntityReference> method returns an instance of the <codeInline>ColorEnumerator</codeInline> class. <codeInline>ColorEnumerator</codeInline> implements the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerator</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">P:System.Collections.IEnumerator.Current</codeEntityReference> property, <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerator.MoveNext</codeEntityReference> method, and <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerator.Reset</codeEntityReference> method be implemented.</para>
      <code language="vb">Public Sub ListColors()
    Dim colors As New AllColors()

    For Each theColor As Color In colors
        Console.Write(theColor.Name &amp; " ")
    Next
    Console.WriteLine()
    ' Output: red blue green
End Sub

' Collection class.
Public Class AllColors
    Implements System.Collections.IEnumerable

    Private _colors() As Color =
    {
        New Color With {.Name = "red"},
        New Color With {.Name = "blue"},
        New Color With {.Name = "green"}
    }

    Public Function GetEnumerator() As System.Collections.IEnumerator _
        Implements System.Collections.IEnumerable.GetEnumerator

        Return New ColorEnumerator(_colors)

        ' Instead of creating a custom enumerator, you could
        ' use the GetEnumerator of the array.
        'Return _colors.GetEnumerator
    End Function

    ' Custom enumerator.
    Private Class ColorEnumerator
        Implements System.Collections.IEnumerator

        Private _colors() As Color
        Private _position As Integer = -1

        Public Sub New(ByVal colors() As Color)
            _colors = colors
        End Sub

        Public ReadOnly Property Current() As Object _
            Implements System.Collections.IEnumerator.Current
            Get
                Return _colors(_position)
            End Get
        End Property

        Public Function MoveNext() As Boolean _
            Implements System.Collections.IEnumerator.MoveNext
            _position += 1
            Return (_position &lt; _colors.Length)
        End Function

        Public Sub Reset() Implements System.Collections.IEnumerator.Reset
            _position = -1
        End Sub
    End Class
End Class

' Element class.
Public Class Color
    Public Property Name As String
End Class</code>
    </content>
  </section><section address="BKMK_Iterators">
    <title>Iterators</title>
    <content>
      <para>An <newTerm>iterator</newTerm> is used to perform a custom iteration over a collection. An iterator can be a method or a <languageKeyword>get</languageKeyword> accessor. An iterator uses a \<legacyLink xlink:href="f33126c5-d7c4-43e2-8e36-4ae3f0703d97">Yield</legacyLink> statement to return each element of the collection one at a time.</para>
      <para>You call an iterator by using a \<legacyLink xlink:href="ebce3120-95c3-42b1-b70b-fa7da40c75e2">For Each…Next</legacyLink> statement. Each iteration of the <languageKeyword>For Each</languageKeyword> loop calls the iterator. When a <languageKeyword>Yield</languageKeyword> statement is reached in the iterator, an expression is returned, and the current location in code is retained. Execution is restarted from that location the next time that the iterator is called.</para>
      <para>For more information, see \<link xlink:href="f26b5c1e-fe9d-4004-b287-da7919d717ae">Iterators (Visual Basic)</link>.</para>
      <para>The following example uses an iterator method. The iterator method has a <languageKeyword>Yield</languageKeyword> statement that is inside a \<legacyLink xlink:href="f5fc0d51-67ce-4c36-9f09-31c9a91c94e9">For…Next</legacyLink> loop. In the <codeInline>ListEvenNumbers</codeInline> method, each iteration of the <languageKeyword>For Each</languageKeyword> statement body creates a call to the iterator method, which proceeds to the next <languageKeyword>Yield</languageKeyword> statement.</para>
      <code language="vb">Public Sub ListEvenNumbers()
    For Each number As Integer In EvenSequence(5, 18)
        Console.Write(number &amp; " ")
    Next
    Console.WriteLine()
    ' Output: 6 8 10 12 14 16 18
End Sub

Private Iterator Function EvenSequence(
ByVal firstNumber As Integer, ByVal lastNumber As Integer) _
As IEnumerable(Of Integer)

' Yield even numbers in the range.
    For number = firstNumber To lastNumber
        If number Mod 2 = 0 Then
            Yield number
        End If
    Next
End Function</code>
    </content>
  </section><relatedTopics>
    
\<link xlink:href="a9290329-77b0-4fdf-ae75-8fc17287f469">Collection Initializers Overview (Visual Basic)</link>

\<link xlink:href="cc9cac84-61f6-476e-b8c7-9bae7749bd90">Programming Concepts (Visual Basic)</link>
\<link xlink:href="5883e0c1-a920-4274-8e46-b0ff047eaee5">Option Strict Statement</link>
\<link xlink:href="dd4c30bc-1c9b-4781-a482-b5eada38deb2">LINQ to Objects (Visual Basic)</link>
\<link xlink:href="3d4d0cd3-bde4-490b-99e7-f4e41be96455">Parallel LINQ (PLINQ)</link>
\<link xlink:href="60cc581f-1db5-445b-ba04-a173396bf872">Collections and Data Structures</link>
\<legacyLink xlink:href="2065398e-eb1a-4821-9188-75f16e42e069">Creating and Manipulating Collections</legacyLink>
\<link xlink:href="ba049f9a-ce87-4cc4-b319-3f75c8ddac8a">Selecting a Collection Class</link>
\<link xlink:href="5e4d3b45-97f0-423c-a65f-c492ed40e73b">Comparisons and Sorts Within Collections</link>
\<link xlink:href="e7b868b1-11fe-4ac5-bed3-de68aca47739">When to Use Generic Collections</link>

</relatedTopics>
</developerConceptualDocument>
