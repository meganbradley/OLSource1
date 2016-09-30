---
title: "How to: Return Subsets of Element Properties in a Query (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "anonymous types [C#], for subsets of element properties"
ms.assetid: fabdf349-f443-4e3f-8368-6c471be1dd7b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Return Subsets of Element Properties in a Query (C# Programming Guide)
Use an anonymous type in a query expression when both of these conditions apply:  
  
-   You want to return only some of the properties of each source element.  
  
-   You do not have to store the query results outside the scope of the method in which the query is executed.  
  
 If you only want to return one property or field from each source element, then you can just use the dot operator in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause. For example, to return only the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, write the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use an anonymous type to return only a subset of the properties of each source element that matches the specified condition.  
  
 [!code[csProgGuideLINQ#31](../vs140/codesnippet/CSharp/how-to--return-subsets-of-element-properties-in-a-query--csharp-programming-guide-_1.cs)]  
  
 Note that the anonymous type uses the source element's names for its properties if no names are specified. To give new names to the properties in the anonymous type, write the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you try this in the previous example, then the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement must also change:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Compiling the Code  
  
-   To run this code, copy and paste the class into a Visual C# console application project that has been created in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)]. By default, this project targets version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and it will have a reference to System.Core.dll and a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive for System.Linq. If one or more of these requirements are missing from the project, you can add them manually. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)