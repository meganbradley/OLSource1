---
title: "Iterators (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: c93f6dd4-e72a-4a06-be1c-a98b3255b734
caps.latest.revision: 7
---
# Iterators (C#)
An *iterator* can be used to step through collections such as lists and arrays.  
  
 An iterator method or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> accessor performs a custom iteration over a collection. An iterator method uses the [yield return](../vs140/yield--csharp-reference-.md) statement to return each element one at a time. When a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement is reached, the current location in code is remembered. Execution is restarted from that location the next time the iterator function is called.  
  
 You consume an iterator from client code by using a [foreach](../vs140/foreach--in--csharp-reference-.md) statement or by using a LINQ query.  
  
 In the following example, the first iteration of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop causes execution to proceed  in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> iterator method until the first <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement is reached. This iteration returns a value of 3, and the current location in the iterator method is retained. On the next iteration of the loop, execution in the iterator method continues from where it left off, again stopping when it reaches a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement. This iteration returns a value of 5, and the current location in the iterator method is again retained. The loop completes when the end of the iterator method is reached.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The return type of an iterator method or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> accessor can be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>1*>.  
  
 You can use a<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement to end the iteration.  
  
 Iterators were introduced in C# in Visual Studio 2005.  
  
 **In this topic**  
  
-   [Simple Iterator](#BKMK_SimpleIterator)  
  
-   [Creating a Collection Class](#BKMK_CollectionClass)  
  
-   [Using Iterators with a Generic List](#BKMK_GenericList)  
  
-   [Syntax Information](#BKMK_SyntaxInformation)  
  
-   [Technical Implementation](#BKMK_Technical)  
  
-   [Use of Iterators](#BKMK_UseOfIterators)  
  
> [!NOTE]
>  For all examples in this topic except the Simple Iterator example, include [using](../vs140/using-directive--csharp-reference-.md) directives for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> namespaces.  
  
##  \<a name="BKMK_SimpleIterator">\</a> Simple Iterator  
 The following example has a single <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement that is inside a [for](../vs140/for--csharp-reference-.md) loop. In <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, each iteration of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement body creates a call to the iterator function, which proceeds to the next <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CollectionClass">\</a> Creating a Collection Class  
 In the following example, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class implements the \<xref:System.Collections.IEnumerable*> interface, which requires a \<xref:System.Collections.IEnumerable.GetEnumerator*> method. The compiler implicitly calls the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method, which returns an \<xref:System.Collections.IEnumerator*>.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method returns each string one at a time by using the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example creates a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class that contains a collection of animals.  
  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement that refers to the class instance (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) implicitly calls the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statements that refer to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> properties use the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> named iterator method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="BKMK_GenericList">\</a> Using Iterators with a Generic List  
 In the following example, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> generic class implements the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>Push<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>1.GetEnumerator*> method returns the array values by using the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement.  
  
 In addition to the generic <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>1*> inherits from \<xref:System.Collections.IEnumerable*>. The non-generic implementation defers to the generic implementation.  
  
 The example uses named iterators to support various ways of iterating through the same collection of data. These named iterators are the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> properties, and the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method.  
  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> property uses an iterator in a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> accessor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="BKMK_SyntaxInformation">\</a> Syntax Information  
 An iterator can occur as a method or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> accessor. An iterator cannot occur in an event, instance constructor, static constructor, or static destructor.  
  
 An implicit conversion must exist from the expression type in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement to the return type of the iterator.  
  
 In C#, an iterator method cannot have any <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameters.  
  
 In C#, "yield" is not a reserved word and has special meaning only when it is used before a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> keyword.  
  
##  \<a name="BKMK_Technical">\</a> Technical Implementation  
 Although you write an iterator as a method, the compiler translates it into a nested class that is, in effect, a state machine. This class keeps track of the position of the iterator as long the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> loop in the client code continues.  
  
 To see what the compiler does, you can use the Ildasm.exe tool to view the Microsoft intermediate language code that is generated for an iterator method.  
  
 When you create an iterator for a [class](../vs140/class--csharp-reference-.md) or [struct](../vs140/struct--csharp-reference-.md), you do not have to implement the whole \<xref:System.Collections.IEnumerator*> interface. When the compiler detects the iterator, it automatically generates the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> methods of the \<xref:System.Collections.IEnumerator*> or <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>IEnumerator.MoveNext<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>yield break<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>1*>   
 [foreach, in](../vs140/foreach--in--csharp-reference-.md)   
 [yield (C# Reference)](../vs140/yield--csharp-reference-.md)   
 [Using Foreach with Arrays (Visual C#)](../vs140/using-foreach-with-arrays--csharp-programming-guide-.md)   
 [Generics (C# Programmer's Reference)](../vs140/generics--csharp-programming-guide-.md)