---
title: "How to: Concatenate Multiple Strings (C# Programming Guide)"
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
  - "joining strings [C#]"
  - "concatenating strings [C#]"
  - "strings [C#], concatenation"
ms.assetid: 8e16736f-4096-4f3f-be0f-9d4c3ff63520
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Concatenate Multiple Strings (C# Programming Guide)
*Concatenation* is the process of appending one string to the end of another string. When you concatenate string literals or string constants by using the `+` operator, the compiler creates a single string. No run time concatenation occurs. However, string variables can be concatenated only at run time. In this case, you should understand the performance implications of the various approaches.  
  
## Example  
 The following example shows how to split a long string literal into smaller strings in order to improve readability in the source code. These parts will be concatenated into a single string at compile time. There is no run time performance cost regardless of the number of strings involved.  
  
 [!code[csProgGuideStrings#30](../vs140/codesnippet/CSharp/how-to--concatenate-multiple-strings--csharp-programming-guide-_1.cs)]  
  
## Example  
 To concatenate string variables, you can use the `+` or `+=` operators, or the <xref:System.String.Concat*?displayProperty=fullName>, <xref:System.String.Format*?displayProperty=fullName> or <xref:System.Text.StringBuilder.Append*?displayProperty=fullName> methods. The `+` operator is easy to use and makes for intuitive code. Even if you use several + operators in one statement, the string content is copied only once. But if you repeat this operation multiple times, for example in a loop, it might cause efficiency problems. For example, note the following code:  
  
 [!code[csProgGuideStrings#23](../vs140/codesnippet/CSharp/how-to--concatenate-multiple-strings--csharp-programming-guide-_2.cs)]  
  
> [!NOTE]
>  In string concatenation operations, the C# compiler treats a null string the same as an empty string, but it does not convert the value of the original null string.  
  
 If you are not concatenating large numbers of strings (for example, in a loop), the performance cost of this code is probably not significant. The same is true for the <xref:System.String.Concat*?displayProperty=fullName> and <xref:System.String.Format*?displayProperty=fullName> methods.  
  
 However, when performance is important, you should always use the <xref:System.Text.StringBuilder*> class to concatenate strings. The following code uses the <xref:System.Text.StringBuilder.Append*> method of the <xref:System.Text.StringBuilder*> class to concatenate strings without the chaining effect of the `+` operator.  
  
 [!code[csProgGuideStrings#22](../vs140/codesnippet/CSharp/how-to--concatenate-multiple-strings--csharp-programming-guide-_3.cs)]  
  
## See Also  
 <xref:System.String*>   
 <xref:System.Text.StringBuilder*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Strings Overview (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md)