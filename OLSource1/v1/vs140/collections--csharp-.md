---
title: "Collections (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "CSharp"
ms.assetid: 317d7dc3-8587-4873-8b3e-556f86497939
caps.latest.revision: 7
---
# Collections (C#)
For many applications, you want to create and manage groups of related objects. There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.  
  
 Arrays are most useful for creating and working with a fixed number of strongly-typed objects. For information about arrays, see [Arrays (C# Programming Guide)](../vs140/arrays--csharp-programming-guide-.md).  
  
 Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.  
  
 A collection is a class, so you must declare an instance of the class before you can add elements to that collection.  
  
 If your collection contains elements of only one data type, you can use one of the classes in the \<xref:System.Collections.Generic*?displayProperty=fullName> namespace. A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.  
  
> [!NOTE]
>  For the examples in this topic, include[using](../vs140/using-directive--csharp-reference-.md) directives for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> namespaces.  
  
 **In this topic**  
  
-   [Using a Simple Collection](#BKMK_SimpleCollection)  
  
-   [Kinds of Collections](../vs140/collections--csharp-and-visual-basic-.md#BKMK_KindsOfCollections)  
  
    -   [System.Collections.Generic Classes](#BKMK_Generic)  
  
    -   [System.Collections.Concurrent Classes](#BKMK_Concurrent)  
  
    -   [System.Collections Classes](#BKMK_Collections)  
  
-   [Implementing a Collection of Key/Value Pairs](#BKMK_KeyValuePairs)  
  
-   [Using LINQ to Access a Collection](#BKMK_LINQ)  
  
-   [Sorting a Collection](#BKMK_Sorting)  
  
-   [Defining a Custom Collection](#BKMK_CustomCollection)  
  
-   [Iterators](#BKMK_Iterators)  
  
##  \<a name="BKMK_SimpleCollection">\</a> Using a Simple Collection  
 The examples in this section use the generic <xref:System.Collections.Generic.List<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>for<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>1.RemoveAt*> method causes elements after a removed element to have a lower index value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For the type of elements in the <xref:System.Collections.Generic.List<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Galaxy<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>1*> is defined in the code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="BKMK_KindsOfCollections">\</a> Kinds of Collections  
 Many common collections are provided by the .NET Framework. For a complete list, see [collections namespace](assetId:///d97ad2aa-c360-4056-856f-19b8134e547c).  Each type of collection is designed for a specific purpose.  
  
 Some of the common collection classes are described in this section:  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> classes  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> classes  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> classes  
  
###  \<a name="BKMK_Generic">\</a> System.Collections.Generic Classes  
 You can create a generic collection by using one of the classes in the \<xref:System.Collections.Generic*> namespace. A generic collection is useful when every item in the collection has the same data type. A generic collection enforces strong typing by allowing only the desired data type to be added.  
  
 The following table lists some of the frequently used classes of the \<xref:System.Collections.Generic*?displayProperty=fullName> namespace:  
  
|||  
|-|-|  
|Class|Description|  
|<xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>1*>|Represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.|  
|<xref:System.Collections.Generic.Queue<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>2*>|Represents a collection of key/value pairs that are sorted by key based on the associated <xref:System.Collections.Generic.IComparer<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>1*>|Represents a last in, first out (LIFO) collection of objects.|  
  
 For additional information, see [Commonly Used Collection Types](assetId:///f5d4c6a4-0d7b-4944-a9fb-3b12d9ebfd55), [Selecting a Collection Class](assetId:///ba049f9a-ce87-4cc4-b319-3f75c8ddac8a), and \<xref:System.Collections.Generic*?displayProperty=fullName>.  
  
###  \<a name="BKMK_Concurrent">\</a> System.Collections.Concurrent Classes  
 In the .NET Framework 4 or newer, the collections in the \<xref:System.Collections.Concurrent*> namespace provide efficient thread-safe operations for accessing collection items from multiple threads.  
  
 The classes in the \<xref:System.Collections.Concurrent*> namespace should be used instead of the corresponding types in the \<xref:System.Collections.Generic*?displayProperty=fullName> and \<xref:System.Collections*?displayProperty=fullName> namespaces whenever multiple threads are accessing the collection concurrently. For more information, see [Thread-Safe Collections](assetId:///2e7ca21f-786c-4367-96be-0cf3f3dcc6bd) and \<xref:System.Collections.Concurrent*>.  
  
 Some classes included in the \<xref:System.Collections.Concurrent*> namespace are <xref:System.Collections.Concurrent.BlockingCollection<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>2*>, <xref:System.Collections.Concurrent.ConcurrentQueue<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>1*>.  
  
###  \<a name="BKMK_Collections">\</a> System.Collections Classes  
 The classes in the \<xref:System.Collections*?displayProperty=fullName> namespace do not store elements as specifically typed objects, but as objects of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Whenever possible, you should use the generic collections in the \<xref:System.Collections.Generic*?displayProperty=fullName> namespace or the \<xref:System.Collections.Concurrent*> namespace instead of the legacy types in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> namespace.  
  
 The following table lists some of the frequently used classes in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> namespace:  
  
|||  
|-|-|  
|Class|Description|  
|\<xref:System.Collections.ArrayList*>|Represents an array of objects whose size is dynamically increased as required.|  
|\<xref:System.Collections.Hashtable*>|Represents a collection of key/value pairs that are organized based on the hash code of the key.|  
|\<xref:System.Collections.Queue*>|Represents a first in, first out (FIFO) collection of objects.|  
|\<xref:System.Collections.Stack*>|Represents a last in, first out (LIFO) collection of objects.|  
  
 The \<xref:System.Collections.Specialized*> namespace provides specialized and strongly typed collection classes, such as string-only collections and linked-list and hybrid dictionaries.  
  
##  \<a name="BKMK_KeyValuePairs">\</a> Implementing a Collection of Key/Value Pairs  
 The <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>Dictionary<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>Dictionary<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>Dictionary<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>BuildDictionary<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>AddToDictionary<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>2.ContainsKey*> method and the <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>Dictionary<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>Item<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>elements<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>elements[symbol]<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>2.TryGetValue*> method quickly find an item by key.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="BKMK_LINQ">\</a> Using LINQ to Access a Collection  
 LINQ (Language-Integrated Query) can be used to access collections. LINQ queries provide filtering, ordering, and grouping capabilities. For more information, see  [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md).  
  
 The following example runs a LINQ query against a generic <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. The LINQ query returns a different collection that contains the results.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Sorting">\</a> Sorting a Collection  
 The following example illustrates a procedure for sorting a collection. The example sorts instances of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class that are stored in a <xref:System.Collections.Generic.List<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>Car<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>1*> interface, which requires that the <xref:System.IComparable<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>1.CompareTo*> method makes a single comparison that is used for sorting. User-written code in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> method returns a value for each comparison of the current object with another object. The value returned is less than zero if the current object is less than the other object, greater than zero if the current object is greater than the other object, and zero if they are equal. This enables you to define in code the criteria for greater than, less than, and equal.  
  
 In the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> statement sorts the list. This call to the <xref:System.Collections.Generic.List<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>1*> causes the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method to be called automatically for the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> objects in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CustomCollection">\</a> Defining a Custom Collection  
 You can define a collection by implementing the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>AllColors<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>GetEnumerator<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>ColorEnumerator<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>ColorEnumerator<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>get<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>ListEvenNumbers<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>yield return` statement.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)   
 [Programming Concepts (C#)](../vs140/programming-concepts--csharp-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)   
 [Parallel LINQ (PLINQ)](assetId:///3d4d0cd3-bde4-490b-99e7-f4e41be96455)   
 [Collections and Data Structures](assetId:///60cc581f-1db5-445b-ba04-a173396bf872)   
 [Creating and Manipulating Collections](assetId:///2065398e-eb1a-4821-9188-75f16e42e069)   
 [Selecting a Collection Class](assetId:///ba049f9a-ce87-4cc4-b319-3f75c8ddac8a)   
 [Comparisons and Sorts Within Collections](assetId:///5e4d3b45-97f0-423c-a65f-c492ed40e73b)   
 [When to Use Generic Collections](assetId:///e7b868b1-11fe-4ac5-bed3-de68aca47739)   
 [How to: Access a Collection Class with foreach (C# Programming Guide)](../vs140/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-.md)