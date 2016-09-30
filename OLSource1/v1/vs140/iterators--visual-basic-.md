---
title: "Iterators (Visual Basic)"
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
ms.assetid: f26b5c1e-fe9d-4004-b287-da7919d717ae
caps.latest.revision: 5
---
# Iterators (Visual Basic)
An *iterator* can be used to step through collections such as lists and arrays.  
  
 An iterator method or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> accessor performs a custom iteration over a collection. An iterator method uses the [Yield](../vs140/yield-statement--visual-basic-.md) statement to return each element one at a time. When a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement is reached, the current location in code is remembered. Execution is restarted from that location the next time the iterator function is called.  
  
 You consume an iterator from client code by using a [For Each…Next](../vs140/for-each...next-statement--visual-basic-.md) statement, or by using a LINQ query.  
  
 In the following example, the first iteration of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> loop causes execution to proceed  in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> iterator method until the first <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement is reached. This iteration returns a value of 3, and the current location in the iterator method is retained. On the next iteration of the loop, execution in the iterator method continues from where it left off, again stopping when it reaches a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement. This iteration returns a value of 5, and the current location in the iterator method is again retained. The loop completes when the end of the iterator method is reached.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The return type of an iterator method or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> accessor can be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>1*>.  
  
 You can use an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement to end the iteration.  
  
 A Visual Basic iterator function or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> accessor declaration includes an [Iterator](../vs140/iterator--visual-basic-.md) modifier.  
  
 Iterators were introduced in Visual Basic in Visual Studio 2012.  
  
 **In this topic**  
  
-   [Simple Iterator](#BKMK_SimpleIterator)  
  
-   [Creating a Collection Class](#BKMK_CollectionClass)  
  
-   [Try Blocks](#BKMK_TryBlocks)  
  
-   [Anonymous Methods](#BKMK_AnonymousMethods)  
  
-   [Using Iterators with a Generic List](#BKMK_GenericList)  
  
-   [Syntax Information](#BKMK_SyntaxInformation)  
  
-   [Technical Implementation](#BKMK_Technical)  
  
-   [Use of Iterators](#BKMK_UseOfIterators)  
  
> [!NOTE]
>  For all examples in the topic except the Simple Iterator example, include [Imports](../vs140/imports-statement--.net-namespace-and-type-.md) statements for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> namespaces.  
  
##  \<a name="BKMK_SimpleIterator">\</a> Simple Iterator  
 The following example has a single <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement that is inside a [For…Next](../vs140/for...next-statement--visual-basic-.md) loop. In <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, each iteration of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement body creates a call to the iterator function, which proceeds to the next <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CollectionClass">\</a> Creating a Collection Class  
 In the following example, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class implements the \<xref:System.Collections.IEnumerable*> interface, which requires a \<xref:System.Collections.IEnumerable.GetEnumerator*> method. The compiler implicitly calls the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method, which returns an \<xref:System.Collections.IEnumerator*>.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method returns each string one at a time by using the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement, and  an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> modifier is in the function declaration.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example creates a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class that contains a collection of animals.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement that refers to the class instance (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>) implicitly calls the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statements that refer to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> properties use the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> named iterator method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="BKMK_TryBlocks">\</a> Try Blocks  
 Visual Basic allows a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> block of a [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md). A <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block that has a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement can have <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> blocks, and can have a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> block.  
  
 The following example includes <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> blocks in an iterator function. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> block in the iterator function executes before the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> iteration finishes.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement cannot be inside a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> block or a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> block.  
  
 If the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> body (instead of the iterator method) throws an exception, a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> block in the iterator function is not executed, but a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> block in the iterator function is executed. A <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> block inside an iterator function catches only exceptions that occur inside the iterator function.  
  
##  \<a name="BKMK_AnonymousMethods">\</a> Anonymous Methods  
 In Visual Basic, an anonymous function can be an iterator function. The following example illustrates this.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following example has a non-iterator method that validates the arguments. The method returns the result of an anonymous iterator that describes the collection elements.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If validation is instead inside the iterator function, the validation cannot be performed until the start of the first iteration of the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> body.  
  
##  \<a name="BKMK_GenericList">\</a> Using Iterators with a Generic List  
 In the following example, the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> generic class implements the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>Push<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>1.GetEnumerator*> method returns the array values by using the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement.  
  
 In addition to the generic <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>1*> inherits from \<xref:System.Collections.IEnumerable*>. The non-generic implementation defers to the generic implementation.  
  
 The example uses named iterators to support various ways of iterating through the same collection of data. These named iterators are the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> properties, and the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> method.  
  
 The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> property declaration includes the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> keyword.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="BKMK_SyntaxInformation">\</a> Syntax Information  
 An iterator can occur as a method or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> accessor. An iterator cannot occur in an event, instance constructor, static constructor, or static destructor.  
  
 An implicit conversion must exist from the expression type in the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> statement to the return type of the iterator.  
  
 In Visual Basic, an iterator method cannot have any <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameters.  
  
 In Visual Basic, "Yield" is not a reserved word and has special meaning only when it is used in an <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> method or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> accessor.  
  
##  \<a name="BKMK_Technical">\</a> Technical Implementation  
 Although you write an iterator as a method, the compiler translates it into a nested class that is, in effect, a state machine. This class keeps track of the position of the iterator as long the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> loop in the client code continues.  
  
 To see what the compiler does, you can use the Ildasm.exe tool to view the Microsoft intermediate language code that is generated for an iterator method.  
  
 When you create an iterator for a [class](../vs140/class--csharp-reference-.md) or [struct](../vs140/struct--csharp-reference-.md), you do not have to implement the whole \<xref:System.Collections.IEnumerator*> interface. When the compiler detects the iterator, it automatically generates the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> methods of the \<xref:System.Collections.IEnumerator*> or <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>For Each…Next<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>IEnumerator.MoveNext<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>Yield<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>Yield<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>Exit Function<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>Return<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>1*>   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)   
 [Yield Statement (Visual Basic)](../vs140/yield-statement--visual-basic-.md)   
 [Iterator (Visual Basic)](../vs140/iterator--visual-basic-.md)