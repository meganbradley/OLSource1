---
title: "Projection Operations (C#)"
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
ms.assetid: 98df573a-aad9-4b8c-9a71-844be2c4fb41
caps.latest.revision: 3
---
# Projection Operations (C#)
Projection refers to the operation of transforming an object into a new form that often consists only of those properties that will be subsequently used. By using projection, you can construct a new type that is built from each object. You can project a property and perform a mathematical function on it. You can also project the original object without changing it.  
  
 The standard query operator methods that perform projection are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|Select|Projects values that are based on a transform function.|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.Select*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Select*?displayProperty=fullName>|  
|SelectMany|Projects sequences of values that are based on a transform function and then flattens them into one sequence.|Use multiple <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clauses|\<xref:System.Linq.Enumerable.SelectMany*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.SelectMany*?displayProperty=fullName>|  
  
## Query Expression Syntax Examples  
  
### Select  
 The following example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause to project the first letter from each string in a list of strings.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### SelectMany  
 The following example uses multiple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clauses  to project each word from each string in a list of strings.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Select versus SelectMany  
 The work of both <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is to produce a result value (or values) from source values. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> produces one result value for every source value. The overall result is therefore a collection that has the same number of elements as the source collection. In contrast, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> produces a single overall result that contains concatenated sub-collections from each source value. The transform function that is passed as an argument to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must return an enumerable sequence of values for each source value. These enumerable sequences are then concatenated by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to create one large sequence.  
  
 The following two illustrations show the conceptual difference between the actions of these two methods. In each case, assume that the selector (transform) function selects the array of flowers from each source value.  
  
 This illustration depicts how <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns a collection that has the same number of elements as the source collection.  
  
 ![Conceptual illustration of the action of Select&#40;&#41;](../vs140/media/selectaction.png "SelectAction")  
  
 This illustration depicts how <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> concatenates the intermediate sequence of arrays into one final result value that contains each value from each intermediate array.  
  
 ![Graphic showing the action of SelectMany&#40;&#41;.](../vs140/media/selectmany.png "SelectMany")  
  
### Code Example  
 The following example compares the behavior of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The code creates a "bouquet" of flowers by taking the first two items from each list of flower names in the source collection. In this example, the "single value" that the transform function <xref:System.Linq.Enumerable.Select<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>1})> uses is itself a collection of values. This requires the extra <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> loop in order to enumerate each string in each sub-sequence.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Linq*>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [select clause (C# Reference)](../vs140/select-clause--csharp-reference-.md)   
 [How to: Populate Object Collections from Multiple Sources (LINQ) (C#)](../vs140/how-to--populate-object-collections-from-multiple-sources--linq---csharp-.md)   
 [How to: Split a File Into Many Files by Using Groups (LINQ) (C#)](../vs140/how-to--split-a-file-into-many-files-by-using-groups--linq---csharp-.md)