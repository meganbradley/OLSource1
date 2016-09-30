---
title: "Nullable Types (C# Programming Guide)"
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
  - "nullable types [C#]"
  - "C# language, nullable types"
  - "types [C#], nullable"
ms.assetid: e473cb01-28ca-42be-9cea-f717055d72c6
caps.latest.revision: 48
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable Types (C# Programming Guide)
Nullable types are instances of the <xref:System.Nullable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>Nullable<Int32><CodeContentPlaceHolder>2\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>Nullable<bool><CodeContentPlaceHolder>4\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>num = Null<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 For more examples, see [Using Nullable Types (C# Programming Guide)](../vs140/using-nullable-types--csharp-programming-guide-.md)  
  
## Nullable Types Overview  
 Nullable types have the following characteristics:  
  
-   Nullable types represent value-type variables that can be assigned the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You cannot create a nullable type based on a reference type. (Reference types already support the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value.)  
  
-   The syntax <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is shorthand for <xref:System.Nullable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>int? x = 10;<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>double? d = 4.108<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>int? x = null.<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>1.GetValueOrDefault*?displayProperty=fullName> method to return either the assigned value, or the default value for the underlying type if the value is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
-   Use the <xref:System.Nullable<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>1.Value*> read-only properties to test for null and retrieve the value, as shown in the following example: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
    -   The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> property returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if the variable contains a value, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if it is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
    -   The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> property returns a value if one is assigned. Otherwise, a \<xref:System.InvalidOperationException*?displayProperty=fullName> is thrown.  
  
    -   The default value for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> property has no default value.  
  
    -   You can also use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operators with a nullable type, as shown in the following example: <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
-   Use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> operator to assign a default value that will be applied when a nullable type whose current value is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is assigned to a non-nullable type, for example <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
-   Nested nullable types are not allowed. The following line will not compile: <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Related Sections  
 For more information:  
  
-   [Using Nullable Types (C#)](../vs140/using-nullable-types--csharp-programming-guide-.md)  
  
-   [Boxing Nullable Types (C# Programming Guide)](../vs140/boxing-nullable-types--csharp-programming-guide-.md)  
  
-   [?? operator (C# Programming Guide)](../vs140/---operator--csharp-reference-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Nullable*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Visual C#](../vs140/csharp.md)   
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [What exactly does 'lifted' mean?](http://go.microsoft.com/fwlink/?LinkId=112382)