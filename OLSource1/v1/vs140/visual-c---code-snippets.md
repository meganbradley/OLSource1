---
title: "Visual C++ Code Snippets"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 74e26fd4-e5ca-4611-a816-0a521b4947a0
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual C++ Code Snippets
In Visual Studio, you can use code snippets to add commonly-used code to your C++ code files. In general, you can use code snippets in much the same way as in C#, but the set of default code snippets is different.  
  
 You can either add a code snippet at a particular location in your code (insertion) or surround some selected code with a code snippet.  
  
## Inserting a Code Snippet  
 To insert a code snippet, open a C++ code file (.cpp or .h), click somewhere inside the file, and do one of the following:  
  
-   Right-click to get the context menu and select **Insert Snippet**  
  
-   In the **Edit / IntelliSense** menu, select **Insert Snippet**  
  
-   Use the hotkeys: **CTRL + K + X**  
  
 You should see a list of choices beginning with **#if**. When you select **#if**, you should see the following code added to the file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can then replace the 0 with the correct condition.  
  
## Using a Code Snippet to Surround Selected Code  
 To use a code snippet to surround selected code, select a line (or multiple lines) and do one of the following:  
  
1.  Right-click to get the context menu and select **Surround With**  
  
2.  In the **Edit / IntelliSense** menu, select **Surround With**  
  
3.  Use the hotkeys: **CTRL + K + S**  
  
 Select **#if**. You should see something like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can then replace the 0 with the correct condition.  
  
## Where can I find a complete list of the C++ code snippets?  
 You can find the complete list of C++ code snippets by going to the **Code Snippets Manager** (on the **Tools** menu) and setting the **Language** to **Visual C++**. In the window below, expand **Visual C++**. You should see the names of all the C++ code snippets in alphabetical order.  
  
 The names of most code snippets are self-explanatory, but some names might be confusing.  
  
## Class vs. classi  
 The **class** snippet provides the definition of a class named MyClass, with the appropriate default constructor and destructor, where the definitions of the constructor and destructor are located outside the class:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The classi code snippet also provides the definition of a class named MyClass, but the default constructor and destructor are defined inside the class definition:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## For vs. foreach vs. forr vs rfor  
 There are four different for snippets that provide different kinds of for loops.  
  
 The **for** snippet provides a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> loop in which the condition is based on the length (in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) of an object:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The **foreach** snippet provides a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> loop that iterates over the members of a collection:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The **forr** snippet provides a reverse <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> loop in which the condition is based on the length (in integers) of an object:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The **rfor** snippet provides a [range-based](../vs140/range-based-for-statement--c---.md) for loop (link):  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## The destructor snippet (~)  
 The destructor snippet (**~**) shows different behavior in different contexts. If you insert this snippet inside a class, it provides a destructor for that class. For example, given the following code:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 If you insert the destructor snippet, it provides a destructor for SomeClass:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 If you try to insert the destructor snippet outside a class, it provides a destructor with a placeholder name:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>