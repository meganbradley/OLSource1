---
title: "Collections (C#)"
ms.custom: na
ms.date: "10/07/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "CSharp"
ms.assetid: 317d7dc3-8587-4873-8b3e-556f86497939
caps.latest.revision: 3
ms.author: "shoag"
manager: "wpickett"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Collections (C#)
\<?xml version="1.0" encoding="UTF-8"?>
\<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd" xmlns:xlink="http://www.w3.org/1999/xlink">
    <introduction>
    <para>For many applications, you want to create and manage groups of related objects. There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.</para>
    <para>Arrays are most useful for creating and working with a fixed number of strongly-typed objects. For information about arrays, see \<link xlink:href="bb79bdde-e570-4c30-adb0-1dd5759ae041">Arrays (C# Programming Guide)</link>.</para>
    <para>Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.</para>
    <para>A collection is a class, so you must declare an instance of the class before you can add elements to that collection.</para>
    <para>If your collection contains elements of only one data type, you can use one of the classes in the <codeEntityReference qualifyHint="true" autoUpgrade="true">N:System.Collections.Generic</codeEntityReference> namespace. A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.</para>
    <alert class="note">
      <para>For the examples in this topic, include\<legacyLink xlink:href="b42b8e61-5e7e-439c-bb71-370094b44ae8">using</legacyLink> directives for the <unmanagedCodeEntityReference>System.Collections.Generic</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>System.Linq</unmanagedCodeEntityReference> namespaces.</para>
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
      <para>The following example creates a list of strings and then iterates through the strings by using a or <legacyLink xlink:href="5a9c5ddc-5fd3-457a-9bb6-9abffcd874ec">foreach</legacyLink> statement.</para>
      <code language="c#">// Create a list of strings.
var salmons = new List&lt;string&gt;();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye</code>
      <para>If the contents of a collection are known in advance, you can use a <newTerm>collection initializer</newTerm> to initialize the collection. For more information, see <link xlink:href="c58f3db5-d7d4-4651-bd2d-5a3a97357f61">Object and Collection Initializers (C# Programming Guide)</link>.</para>
      <para>The following example is the same as the previous example, except a collection initializer is used to add elements to the collection.</para>
      <code language="c#">// Create a list of strings by using a
// collection initializer.
var salmons = new List&lt;string&gt; { "chinook", "coho", "pink", "sockeye" };

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye</code>
      <para>You can use a <legacyLink xlink:href="34041a40-2c87-467a-9ffb-a0417d8f67a8">for</legacyLink> statement instead of a <languageKeyword>foreach</languageKeyword> statement to iterate through a collection. You accomplish this by accessing the collection elements by the index position. The index of the elements starts at 0 and ends at the element count minus 1.</para>
      <para>The following example iterates through the elements of a collection by using <languageKeyword>for</languageKeyword> instead of <languageKeyword>foreach</languageKeyword>.</para>
      <code language="c#">// Create a list of strings by using a
// collection initializer.
var salmons = new List&lt;string&gt; { "chinook", "coho", "pink", "sockeye" };

for (var index = 0; index &lt; salmons.Count; index++)
{
    Console.Write(salmons[index] + " ");
}
// Output: chinook coho pink sockeye</code>
      <para>The following example removes an element from the collection by specifying the object to remove.</para>
      <code language="c#">// Create a list of strings by using a
// collection initializer.
var salmons = new List&lt;string&gt; { "chinook", "coho", "pink", "sockeye" };

// Remove an element from the list by specifying
// the object.
salmons.Remove("coho");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook pink sockeye</code>
      <para>The following example removes elements from a generic list. Instead of a <languageKeyword>foreach</languageKeyword> statement, a <legacyLink xlink:href="34041a40-2c87-467a-9ffb-a0417d8f67a8">for</legacyLink> statement that iterates in descending order is used. This is because the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.List`1.RemoveAt(System.Int32)</codeEntityReference> method causes elements after a removed element to have a lower index value.</para>
      <code language="c#">var numbers = new List&lt;int&gt; { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Remove odd numbers.
for (var index = numbers.Count - 1; index &gt;= 0; index--)
{
    if (numbers[index] % 2 == 1)
    {
        // Remove the element by specifying
        // the zero-based index in the list.
        numbers.RemoveAt(index);
    }
}

// Iterate through the list.
// A lambda expression is placed in the ForEach method
// of the List(T) object.
numbers.ForEach(
    number =&gt; Console.Write(number + " "));
// Output: 0 2 4 6 8</code>
      <para>For the type of elements in the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference>, you can also define your own class. In the following example, the <codeInline>Galaxy</codeInline> class that is used by the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference> is defined in the code.</para>
      <code language="c#">private static void IterateThroughList()
{
    var theGalaxies = new List&lt;Galaxy&gt;
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            new Galaxy() { Name="Milky Way", MegaLightYears=0},
            new Galaxy() { Name="Andromeda", MegaLightYears=3}
        };

    foreach (Galaxy theGalaxy in theGalaxies)
    {
        Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
    }

    // Output:
    //  Tadpole  400
    //  Pinwheel  25
    //  Milky Way  0
    //  Andromeda  3
}

public class Galaxy
{
    public string Name { get; set; }
    public int MegaLightYears { get; set; }
}</code>
    </content>
  </section>
    <section address="BKMK_KindsOfCollections">
    <title>Kinds of Collections</title>
    <content>
      <para>Many common collections are provided by the .NET Framework. For a complete list, see System.Collections namespace.  Each type of collection is designed for a specific purpose.</para>
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
      
    </sections>
  </section><section address="BKMK_KeyValuePairs">
    <title>Implementing a Collection of Key/Value Pairs</title>
    <content>
      <para>The <codeEntityReference autoUpgrade="true">T:System.Collections.Generic.Dictionary`2</codeEntityReference> generic collection enables you to access to elements in a collection by using the key of each element. Each addition to the dictionary consists of a value and its associated key. Retrieving a value by using its key is fast because the <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> class is implemented as a hash table.</para>
      <para>The following example creates a <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> collection and iterates through the dictionary by using a <languageKeyword>foreach</languageKeyword> statement.</para>
      <code language="c#">private static void IterateThruDictionary()
{
    Dictionary&lt;string, Element&gt; elements = BuildDictionary();

    foreach (KeyValuePair&lt;string, Element&gt; kvp in elements)
    {
        Element theElement = kvp.Value;

        Console.WriteLine("key: " + kvp.Key);
        Console.WriteLine("values: " + theElement.Symbol + " " +
            theElement.Name + " " + theElement.AtomicNumber);
    }
}

private static Dictionary&lt;string, Element&gt; BuildDictionary()
{
    var elements = new Dictionary&lt;string, Element&gt;();

    AddToDictionary(elements, "K", "Potassium", 19);
    AddToDictionary(elements, "Ca", "Calcium", 20);
    AddToDictionary(elements, "Sc", "Scandium", 21);
    AddToDictionary(elements, "Ti", "Titanium", 22);

    return elements;
}

private static void AddToDictionary(Dictionary&lt;string, Element&gt; elements,
    string symbol, string name, int atomicNumber)
{
    Element theElement = new Element();

    theElement.Symbol = symbol;
    theElement.Name = name;
    theElement.AtomicNumber = atomicNumber;

    elements.Add(key: theElement.Symbol, value: theElement);
}

public class Element
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public int AtomicNumber { get; set; }
}</code>
      <para>To instead use a collection initializer to build the <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> collection, you can replace the <codeInline>BuildDictionary</codeInline> and <codeInline>AddToDictionary</codeInline> methods with the following method.</para>
      <code language="c#">private static Dictionary&lt;string, Element&gt; BuildDictionary2()
{
    return new Dictionary&lt;string, Element&gt;
    {
        {"K",
            new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
        {"Ca",
            new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
        {"Sc",
            new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
        {"Ti",
            new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
    };
}</code>
      <para>The following example uses the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.Dictionary`2.ContainsKey(`0)</codeEntityReference> method and the <codeEntityReference autoUpgrade="true" qualifyHint="false">P:System.Collections.Generic.Dictionary`2.Item(`0)</codeEntityReference> property of <unmanagedCodeEntityReference>Dictionary</unmanagedCodeEntityReference> to quickly find an item by key. The <unmanagedCodeEntityReference>Item</unmanagedCodeEntityReference> property enables you to access an item in the <codeInline>elements</codeInline> collection by using the <codeInline>elements[symbol]</codeInline> in C#.</para>
      <code language="c#">private static void FindInDictionary(string symbol)
{
    Dictionary&lt;string, Element&gt; elements = BuildDictionary();

    if (elements.ContainsKey(symbol) == false)
    {
        Console.WriteLine(symbol + " not found");
    }
    else
    {
        Element theElement = elements[symbol];
        Console.WriteLine("found: " + theElement.Name);
    }
}</code>
      <para>The following example instead uses the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.Dictionary`2.TryGetValue(`0,`1@)</codeEntityReference> method quickly find an item by key.</para>
      <code language="c#">private static void FindInDictionary2(string symbol)
{
    Dictionary&lt;string, Element&gt; elements = BuildDictionary();

    Element theElement = null;
    if (elements.TryGetValue(symbol, out theElement) == false)
        Console.WriteLine(symbol + " not found");
    else
        Console.WriteLine("found: " + theElement.Name);
}</code>
    </content>
  </section><section address="BKMK_LINQ">
    <title>Using LINQ to Access a Collection</title>
    <content>
      <para>LINQ (Language-Integrated Query) can be used to access collections. LINQ queries provide filtering, ordering, and grouping capabilities. For more information, see  \<link xlink:href="b8700c1f-05c9-4380-b6eb-e34c4da38e54">Getting Started with LINQ in C#</link>.</para>
      <para>The following example runs a LINQ query against a generic <unmanagedCodeEntityReference>List</unmanagedCodeEntityReference>. The LINQ query returns a different collection that contains the results.</para>
      <code language="c#">private static void ShowLINQ()
{
    List&lt;Element&gt; elements = BuildList();

    // LINQ Query.
    var subset = from theElement in elements
                 where theElement.AtomicNumber &lt; 22
                 orderby theElement.Name
                 select theElement;

    foreach (Element theElement in subset)
    {
        Console.WriteLine(theElement.Name + " " + theElement.AtomicNumber);
    }

    // Output:
    //  Calcium 20
    //  Potassium 19
    //  Scandium 21
}

private static List&lt;Element&gt; BuildList()
{
    return new List&lt;Element&gt;
    {
        { new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
        { new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
        { new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
        { new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
    };
}

public class Element
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public int AtomicNumber { get; set; }
}</code>
    </content>
  </section><section address="BKMK_Sorting">
    <title>Sorting a Collection</title>
    <content>
      <para>The following example illustrates a procedure for sorting a collection. The example sorts instances of the <codeInline>Car</codeInline> class that are stored in a <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference>. The <codeInline>Car</codeInline> class implements the <codeEntityReference>T:System.IComparable`1</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.IComparable`1.CompareTo(`0)</codeEntityReference> method be implemented.</para>
      <para>Each call to the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.IComparable`1.CompareTo(`0)</codeEntityReference> method makes a single comparison that is used for sorting. User-written code in the <unmanagedCodeEntityReference>CompareTo</unmanagedCodeEntityReference> method returns a value for each comparison of the current object with another object. The value returned is less than zero if the current object is less than the other object, greater than zero if the current object is greater than the other object, and zero if they are equal. This enables you to define in code the criteria for greater than, less than, and equal.</para>
      <para>In the <codeInline>ListCars</codeInline> method, the <codeInline>cars.Sort()</codeInline> statement sorts the list. This call to the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.Generic.List`1.Sort</codeEntityReference> method of the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.List`1</codeEntityReference> causes the <unmanagedCodeEntityReference>CompareTo</unmanagedCodeEntityReference> method to be called automatically for the <codeInline>Car</codeInline> objects in the <unmanagedCodeEntityReference>List</unmanagedCodeEntityReference>. </para>
      <code language="c#">private static void ListCars()
{
    var cars = new List&lt;Car&gt;
    {
        { new Car() { Name = "car1", Color = "blue", Speed = 20}},
        { new Car() { Name = "car2", Color = "red", Speed = 50}},
        { new Car() { Name = "car3", Color = "green", Speed = 10}},
        { new Car() { Name = "car4", Color = "blue", Speed = 50}},
        { new Car() { Name = "car5", Color = "blue", Speed = 30}},
        { new Car() { Name = "car6", Color = "red", Speed = 60}},
        { new Car() { Name = "car7", Color = "green", Speed = 50}}
    };

    // Sort the cars by color alphabetically, and then by speed
    // in descending order.
    cars.Sort();

    // View all of the cars.
    foreach (Car thisCar in cars)
    {
        Console.Write(thisCar.Color.PadRight(5) + " ");
        Console.Write(thisCar.Speed.ToString() + " ");
        Console.Write(thisCar.Name);
        Console.WriteLine();
    }

    // Output:
    //  blue  50 car4
    //  blue  30 car5
    //  blue  20 car1
    //  green 50 car7
    //  green 10 car3
    //  red   60 car6
    //  red   50 car2
}

public class Car : IComparable&lt;Car&gt;
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public int CompareTo(Car other)
    {
        // A call to this method makes a single comparison that is
        // used for sorting.

        // Determine the relative order of the objects being compared.
        // Sort by color alphabetically, and then by speed in
        // descending order.

        // Compare the colors.
        int compare;
        compare = String.Compare(this.Color, other.Color, true);

        // If the colors are the same, compare the speeds.
        if (compare == 0)
        {
            compare = this.Speed.CompareTo(other.Speed);

            // Use descending order for speed.
            compare = -compare;
        }

        return compare;
    }
}</code>
    </content>
  </section><section address="BKMK_CustomCollection">
    <title>Defining a Custom Collection</title>
    <content>
      <para>You can define a collection by implementing the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.Generic.IEnumerable`1</codeEntityReference> or <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerable</codeEntityReference> interface. For additional information, see \<link xlink:href="a6b9cf5c-6c8d-4223-b12c-288949434493">How to: Access a Collection Class with foreach (C# Programming Guide)</link>.</para>
      <para>Although you can define a custom collection, it is usually better to instead use the collections that are included in the .NET Framework, which are described in \<link xlink:href="e76533a9-5033-4a0b-b003-9c2be60d185b#BKMK_KindsOfCollections">Kinds of Collections</link> earlier in this topic.</para>
      <para>The following example defines a custom collection class named <codeInline>AllColors</codeInline>. This class implements the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerable</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerable.GetEnumerator</codeEntityReference> method be implemented.</para>
      <para>The <unmanagedCodeEntityReference>GetEnumerator</unmanagedCodeEntityReference> method returns an instance of the <codeInline>ColorEnumerator</codeInline> class. <codeInline>ColorEnumerator</codeInline> implements the <codeEntityReference autoUpgrade="true" qualifyHint="false">T:System.Collections.IEnumerator</codeEntityReference> interface, which requires that the <codeEntityReference autoUpgrade="true" qualifyHint="false">P:System.Collections.IEnumerator.Current</codeEntityReference> property, <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerator.MoveNext</codeEntityReference> method, and <codeEntityReference autoUpgrade="true" qualifyHint="false">M:System.Collections.IEnumerator.Reset</codeEntityReference> method be implemented.</para>
      <code language="c#">private static void ListColors()
{
    var colors = new AllColors();

    foreach (Color theColor in colors)
    {
        Console.Write(theColor.Name + " ");
    }
    Console.WriteLine();
    // Output: red blue green
}


// Collection class.
public class AllColors : System.Collections.IEnumerable
{
    Color[] _colors =
    {
        new Color() { Name = "red" },
        new Color() { Name = "blue" },
        new Color() { Name = "green" }
    };

    public System.Collections.IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(_colors);

        // Instead of creating a custom enumerator, you could
        // use the GetEnumerator of the array.
        //return _colors.GetEnumerator();
    }

    // Custom enumerator.
    private class ColorEnumerator : System.Collections.IEnumerator
    {
        private Color[] _colors;
        private int _position = -1;

        public ColorEnumerator(Color[] colors)
        {
            _colors = colors;
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return _colors[_position];
            }
        }

        bool System.Collections.IEnumerator.MoveNext()
        {
            _position++;
            return (_position &lt; _colors.Length);
        }

        void System.Collections.IEnumerator.Reset()
        {
            _position = -1;
        }
    }
}

// Element class.
public class Color
{
    public string Name { get; set; }
}</code>
    </content>
  </section><section address="BKMK_Iterators">
    <title>Iterators</title>
    <content>
      <para>An <newTerm>iterator</newTerm> is used to perform a custom iteration over a collection. An iterator can be a method or a <languageKeyword>get</languageKeyword> accessor. An iterator uses a \<legacyLink xlink:href="1089194f-9e53-46a2-8642-53ccbe9d414d">yield return</legacyLink> statement to return each element of the collection one at a time.</para>
      <para>You call an iterator by using a \<legacyLink xlink:href="5a9c5ddc-5fd3-457a-9bb6-9abffcd874ec">foreach</legacyLink> statement. Each iteration of the <languageKeyword>foreach</languageKeyword> loop calls the iterator. When a <languageKeyword>yield return</languageKeyword> statement is reached in the iterator, an expression is returned, and the current location in code is retained. Execution is restarted from that location the next time that the iterator is called.</para>
      <para>For more information, see \<link xlink:href="c93f6dd4-e72a-4a06-be1c-a98b3255b734">Iterators (C#)</link>.</para>
      <para>The following example uses an iterator method. The iterator method has a <languageKeyword>yield return</languageKeyword> statement that is inside a \<legacyLink xlink:href="34041a40-2c87-467a-9ffb-a0417d8f67a8">for</legacyLink> loop. In the <codeInline>ListEvenNumbers</codeInline> method, each iteration of the <languageKeyword>foreach</languageKeyword> statement body creates a call to the iterator method, which proceeds to the next <languageKeyword>yield return</languageKeyword> statement.</para>
      <code language="c#">private static void ListEvenNumbers()
{
    foreach (int number in EvenSequence(5, 18))
    {
        Console.Write(number.ToString() + " ");
    }
    Console.WriteLine();
    // Output: 6 8 10 12 14 16 18
}

private static IEnumerable&lt;int&gt; EvenSequence(
    int firstNumber, int lastNumber)
{
    // Yield even numbers in the range.
    for (var number = firstNumber; number &lt;= lastNumber; number++)
    {
        if (number % 2 == 0)
        {
            yield return number;
        }
    }
}</code>
    </content>
  </section><relatedTopics>
    

\<link xlink:href="c58f3db5-d7d4-4651-bd2d-5a3a97357f61">Object and Collection Initializers (C# Programming Guide)</link>
\<link xlink:href="3227afd5-4794-484b-b83b-0f1f94a0476b">Programming Concepts (C#)</link>
\<link xlink:href="5883e0c1-a920-4274-8e46-b0ff047eaee5">Option Strict Statement</link>
\<link xlink:href="c5c2c178-3529-4f6c-b3df-2d5267af7f22">LINQ to Objects (C#)</link>
\<link xlink:href="3d4d0cd3-bde4-490b-99e7-f4e41be96455">Parallel LINQ (PLINQ)</link>
\<link xlink:href="60cc581f-1db5-445b-ba04-a173396bf872">Collections and Data Structures</link>
\<legacyLink xlink:href="2065398e-eb1a-4821-9188-75f16e42e069">Creating and Manipulating Collections</legacyLink>
\<link xlink:href="ba049f9a-ce87-4cc4-b319-3f75c8ddac8a">Selecting a Collection Class</link>
\<link xlink:href="5e4d3b45-97f0-423c-a65f-c492ed40e73b">Comparisons and Sorts Within Collections</link>
\<link xlink:href="e7b868b1-11fe-4ac5-bed3-de68aca47739">When to Use Generic Collections</link>
\<link xlink:href="a6b9cf5c-6c8d-4223-b12c-288949434493">How to: Access a Collection Class with foreach (C# Programming Guide)</link>
</relatedTopics>
</developerConceptualDocument>
