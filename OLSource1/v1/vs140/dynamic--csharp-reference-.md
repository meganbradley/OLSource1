---
title: "dynamic (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "dynamic_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "dynamic [C#]"
  - "dynamic keyword [C#]"
ms.assetid: 9e797102-cc83-4964-bf58-afe4f54d16bc
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dynamic (C# Reference)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type enables the operations in which it occurs to bypass compile-time type checking. Instead, these operations are resolved at run time. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type simplifies access to COM APIs such as the Office Automation APIs, and also to dynamic APIs such as IronPython libraries, and to the HTML Document Object Model (DOM).  
  
 Type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> behaves like type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in most circumstances. However, operations that contain expressions of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are not resolved or type checked by the compiler. The compiler packages together information about the operation, and that information is later used to evaluate the operation at run time. As part of the process, variables of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are compiled into variables of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Therefore, type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> exists only at compile time, not at run time.  
  
 The following example contrasts a variable of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to a variable of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. To verify the type of each variable at compile time, place the mouse pointer over <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statements. IntelliSense shows **dynamic** for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and **object** for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsTypes#21](../vs140/codesnippet/CSharp/dynamic--csharp-reference-_1.cs)]  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statements display the run-time types of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. At that point, both have the same type, integer. The following output is produced:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 To see the difference between <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> at compile time, add the following two lines between the declarations and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statements in the previous example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A compiler error is reported for the attempted addition of an integer and an object in expression <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. However, no error is reported for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The expression that contains <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not checked at compile time because the type of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Context  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword can appear directly or as a component of a constructed type in the following situations:  
  
-   In declarations, as the type of a property, field, indexer, parameter, return value, local variable, or type constraint. The following class definition uses <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in several different declarations.  
  
     [!code[csrefKeywordsTypes#22](../vs140/codesnippet/CSharp/dynamic--csharp-reference-_2.cs)]  
  
-   In explicit type conversions, as the target type of a conversion.  
  
     [!code[csrefKeywordsTypes#23](../vs140/codesnippet/CSharp/dynamic--csharp-reference-_3.cs)]  
  
-   In any context where types serve as values, such as on the right side of an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator or an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator, or as the argument to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> as part of a constructed type. For example, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> can be used in the following expressions.  
  
     [!code[csrefKeywordsTypes#24](../vs140/codesnippet/CSharp/dynamic--csharp-reference-_4.cs)]  
  
## Example  
 The following example uses <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in several declarations. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method also contrasts compile-time type checking with run-time type checking.  
  
 [!code[csrefKeywordsTypes#25](../vs140/codesnippet/CSharp/dynamic--csharp-reference-_5.cs)]  
  
 For more information and examples, see [Dynamic Types (C# Programming Guide)](../vs140/using-type-dynamic--csharp-programming-guide-.md).  
  
## See Also  
 \<xref:System.Dynamic.ExpandoObject*?displayProperty=fullName>   
 \<xref:System.Dynamic.DynamicObject*?displayProperty=fullName>   
 [Dynamic Types (C# Programming Guide)](../vs140/using-type-dynamic--csharp-programming-guide-.md)   
 [object (C# Reference)](../vs140/object--csharp-reference-.md)   
 [is (C# Reference)](../vs140/is--csharp-reference-.md)   
 [as (C# Reference)](../vs140/as--csharp-reference-.md)   
 [typeof (C# Reference)](../vs140/typeof--csharp-reference-.md)   
 [How to: Safely Cast by Using as and is Operators (C# Programming Guide)](../vs140/how-to--safely-cast-by-using-as-and-is-operators--csharp-programming-guide-.md)   
 [Walkthrough: Creating and Using Dynamic Objects (C# and Visual Basic)](../vs140/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-.md)