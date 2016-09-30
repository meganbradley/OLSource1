---
title: "for each, in"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "cliext::foreach"
  - "for"
  - "each"
  - "in"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "for each keyword [C++]"
ms.assetid: 0c3a364b-2747-43f3-bb8d-b7d3b7023f79
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for each, in
Iterates through an array or collection. This non-standard keyword is available in both C++/CLI and native C++ projects. However, its use is not recommended. Consider using a standard [Range-based for Statement (C++)](../vs140/range-based-for-statement--c---.md) instead.  
  
## All Runtimes  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The iteration variable that represents the collection element.  When <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a [Tracking Reference Operator (C++ Component Extensions)](../vs140/tracking-reference-operator--c---component-extensions-.md), you can modify the element.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An array expression or collection. The collection element must be such that the compiler can convert it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 One or more statements to be executed.  
  
 **Remarks**  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement is used to iterate through a collection. You can modify elements in a collection, but you cannot add or delete elements.  
  
 The *statements* are executed for each element in the array or collection. After the iteration has been completed for all the elements in the collection, control is transferred to the statement that follows the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are [context-sensitive keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md).  
  
 For more information:  
  
-   [How to: Iterate Over STL Collection with for each](../vs140/iterating-over-stl-collection-by-using-for-each.md)  
  
-   [How to: Iterate Over Arrays with for each](../vs140/how-to--iterate-over-arrays-with-for-each.md)  
  
-   [How to: Iterate Over a Generic Collection with for each](../vs140/how-to--iterate-over-a-generic-collection-with-for-each.md)  
  
-   [How to: Iterate Over a User-Defined Collection with for each](../vs140/how-to--iterate-over-a-user-defined-collection-with-for-each.md)  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
  
### Requirements  
 Compiler option: **/ZW**  
  
### Example  
 This example shows how to use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to iterate through a string.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **abcd**  
**Testing**   
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 The CLR syntax is the same as the **All Runtimes** syntax, except as follows.  
  
 *expression*  
 A managed array expression or collection. The collection element must be such that the compiler can convert it from \<xref:System.Object*> to the *identifier* type.  
  
 *expression* evaluates to a type that implements \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>GetEnumerator<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>IEnumerator<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>for each` to iterate through a string.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **abcd**  
**Testing**    
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)