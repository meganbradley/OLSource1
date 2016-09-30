---
title: "sizeof (C# Reference)"
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
  - "sizeof_CSharpKeyword"
  - "sizeof"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "sizeof keyword [C#]"
ms.assetid: c548592c-677c-4f40-a4ce-e613f7529141
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sizeof (C# Reference)
Used to obtain the size in bytes for an unmanaged type. Unmanaged types include the built-in types that are listed in the table that follows, and also the following:  
  
-   Enum types  
  
-   Pointer types  
  
-   User-defined structs that do not contain any fields or properties that are reference types  
  
 The following example shows how to retrieve the size of an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Starting with version 2.0 of C#, applying <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to built-in types no longer requires that [unsafe](../vs140/unsafe--csharp-reference-.md) mode be used.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator cannot be overloaded. The values returned by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator are of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The following table shows the constant values that are substituted for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expressions that have certain built-in types as operands.  
  
|Expression|Constant value|  
|----------------|--------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|1|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|1|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|2|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|2|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|4|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|4|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|8|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|8|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|2 (Unicode)|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|4|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|8|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|16|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|1|  
  
 For all other types, including structs, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator can be used only in unsafe code blocks. Although you can use the \<xref:System.Runtime.InteropServices.Marshal.SizeOf*?displayProperty=fullName> method, the value returned by this method is not always the same as the value returned by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. \<xref:System.Runtime.InteropServices.Marshal.SizeOf*?displayProperty=fullName> returns the size after the type has been marshaled, whereas <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns the size as it has been allocated by the common language runtime, including any padding.  
  
## Example  
 [!code[csrefKeywordsOperator#11](../vs140/codesnippet/CSharp/sizeof--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)   
 [enum](../vs140/enum--csharp-reference-.md)   
 [Unsafe Code and Pointers (C# Programming Guide)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md)   
 [Constants (C# Programming Guide)](../vs140/constants--csharp-programming-guide-.md)