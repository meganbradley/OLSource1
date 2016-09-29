---
title: "C# Coding Conventions (C# Programming Guide)"
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
  - "coding conventions, C#"
  - "Visual C#, coding conventions"
  - "C# language, coding conventions"
ms.assetid: f4f60de9-d49b-4fb6-bab1-20e19ea24710
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Coding Conventions (C# Programming Guide)
The [C# Language Specification](http://go.microsoft.com/fwlink/?LinkId=199552) does not define a coding standard. However, the guidelines in this topic are used by Microsoft to develop samples and documentation.  
  
 Coding conventions serve the following purposes:  
  
-   They create a consistent look to the code, so that readers can focus on content, not layout.  
  
-   They enable readers to understand the code more quickly by making assumptions based on previous experience.  
  
-   They facilitate copying, changing, and maintaining the code.  
  
-   They demonstrate C# best practices.  
  
## Naming Conventions  
  
-   In short examples that do not include [using directives](../vs140/using-directive--csharp-reference-.md), use namespace qualifications. If you know that a namespace is imported by default in a project, you do not have to fully qualify the names from that namespace. Qualified names can be broken after a dot (.) if they are too long for a single line, as shown in the following example.  
  
     [!code[csProgGuideCodingConventions#1](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_1.cs)]  
  
-   You do not have to change the names of objects that were created by using the Visual Studio designer tools to make them fit other guidelines.  
  
## Layout Conventions  
 Good layout uses formatting to emphasize the structure of your code and to make the code easier to read. Microsoft examples and samples conform to the following conventions:  
  
-   Use the default Code Editor settings (smart indenting, four-character indents, tabs saved as spaces). For more information, see [Formatting, C#, Text Editor, Options Dialog Box](../vs140/options--text-editor--csharp--formatting.md).  
  
-   Write only one statement per line.  
  
-   Write only one declaration per line.  
  
-   If continuation lines are not indented automatically, indent them one tab stop (four spaces).  
  
-   Add at least one blank line between method definitions and property definitions.  
  
-   Use parentheses to make clauses in an expression apparent, as shown in the following code.  
  
     [!code[csProgGuideCodingConventions#2](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_2.cs)]  
  
## Commenting Conventions  
  
-   Place the comment on a separate line, not at the end of a line of code.  
  
-   Begin comment text with an uppercase letter.  
  
-   End comment text with a period.  
  
-   Insert one space between the comment delimiter (//) and the comment text, as shown in the following example.  
  
     [!code[csProgGuideCodingConventions#3](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_3.cs)]  
  
-   Do not create formatted blocks of asterisks around comments.  
  
## Language Guidelines  
 The following sections describe practices that the C# team follows to prepare code examples and samples.  
  
### String Data Type  
  
-   Use the `+` operator to concatenate short strings, as shown in the following code.  
  
     [!code[csProgGuideCodingConventions#6](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_4.cs)]  
  
-   To append strings in loops, especially when you are working with large amounts of text, use a <xref:System.Text.StringBuilder*> object.  
  
     [!code[csProgGuideCodingConventions#7](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_5.cs)]  
  
### Implicitly Typed Local Variables  
  
-   Use [implicit typing](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md) for local variables when the type of the variable is obvious from the right side of the assignment, or when the precise type is not important.  
  
     [!code[csProgGuideCodingConventions#8](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_6.cs)]  
  
-   Do not use [var](../vs140/var--csharp-reference-.md) when the type is not apparent from the right side of the assignment.  
  
     [!code[csProgGuideCodingConventions#9](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_7.cs)]  
  
-   Do not rely on the variable name to specify the type of the variable. It might not be correct.  
  
     [!code[csProgGuideCodingConventions#10](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_8.cs)]  
  
-   Avoid the use of `var` in place of [dynamic](../vs140/dynamic--csharp-reference-.md).  
  
-   Use implicit typing to determine the type of the loop variable in [for](../vs140/for--csharp-reference-.md) and [foreach](../vs140/foreach--in--csharp-reference-.md) loops.  
  
     The following example uses implicit typing in a `for` statement.  
  
     [!code[csProgGuideCodingConventions#11](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_9.cs)]  
  
     The following example uses implicit typing in a `foreach` statement.  
  
     [!code[csProgGuideCodingConventions#12](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_10.cs)]  
  
### Unsigned Data Type  
  
-   In general, use `int` rather than unsigned types. The use of `int` is common throughout C#, and it is easier to interact with other libraries when you use `int`.  
  
### Arrays  
  
-   Use the concise syntax when you initialize arrays on the declaration line.  
  
     [!code[csProgGuideCodingConventions#13](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_11.cs)]  
  
### Delegates  
  
-   Use the concise syntax to create instances of a delegate type.  
  
     [!code[csProgGuideCodingConventions#14](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_12.cs)]  
  
     [!code[csProgGuideCodingConventions#15](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_13.cs)]  
  
### try-catch and using Statements in Exception Handling  
  
-   Use a [try-catch](../vs140/try-catch--csharp-reference-.md) statement for most exception handling.  
  
     [!code[csProgGuideCodingConventions#16](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_14.cs)]  
  
-   Simplify your code by using the C# [using statement](../vs140/using-statement--csharp-reference-.md). If you have a [try-finally](../vs140/try-finally--csharp-reference-.md) statement in which the only code in the `finally` block is a call to the <xref:System.IDisposable.Dispose*> method, use a `using` statement instead.  
  
     [!code[csProgGuideCodingConventions#17](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_15.cs)]  
  
### && and &#124;&#124; Operators  
  
-   To avoid exceptions and increase performance by skipping unnecessary comparisons, use [&&](../vs140/---operator--csharp-reference-.md) instead of [&](../vs140/--operator--csharp-reference-.md) and [&#124;&#124;](../vs140/---operator--csharp-reference-.md) instead of [&#124;](../vs140/--operator--csharp-reference-.md) when you perform comparisons, as shown in the following example.  
  
     [!code[csProgGuideCodingConventions#18](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_16.cs)]  
  
### New Operator  
  
-   Use the concise form of object instantiation, with implicit typing, as shown in the following declaration.  
  
     [!code[csProgGuideCodingConventions#19](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_17.cs)]  
  
     The previous line is equivalent to the following declaration.  
  
     [!code[csProgGuideCodingConventions#20](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_18.cs)]  
  
-   Use object initializers to simplify object creation.  
  
     [!code[csProgGuideCodingConventions#21](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_19.cs)]  
  
### Event Handling  
  
-   If you are defining an event handler that you do not need to remove later, use a lambda expression.  
  
     [!code[csProgGuideCodingConventions#22](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_20.cs)]  
  
     [!code[csProgGuideCodingConventions#23](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_21.cs)]  
  
### Static Members  
  
-   Call [static](../vs140/static--csharp-reference-.md) members by using the class name: *ClassName.StaticMember*. This practice makes code more readable by making static access clear.  Do not qualify a static member defined in a base class with the name of a derived class.  While that code compiles, the code readability is misleading, and the code may break in the future if you add a static member with the same name to the derived class.  
  
### LINQ Queries  
  
-   Use meaningful names for query variables. The following example uses `seattleCustomers` for customers who are located in Seattle.  
  
     [!code[csProgGuideCodingConventions#25](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_22.cs)]  
  
-   Use aliases to make sure that property names of anonymous types are correctly capitalized, using Pascal casing.  
  
     [!code[csProgGuideCodingConventions#26](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_23.cs)]  
  
-   Rename properties when the property names in the result would be ambiguous. For example, if your query returns a customer name and a distributor ID, instead of leaving them as `Name` and `ID` in the result, rename them to clarify that `Name` is the name of a customer, and `ID` is the ID of a distributor.  
  
     [!code[csProgGuideCodingConventions#27](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_24.cs)]  
  
-   Use implicit typing in the declaration of query variables and range variables.  
  
     [!code[csProgGuideCodingConventions#25](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_22.cs)]  
  
-   Align query clauses under the [from](../vs140/from-clause--csharp-reference-.md) clause, as shown in the previous examples.  
  
-   Use [where](../vs140/where-clause--csharp-reference-.md) clauses before other query clauses to ensure that later query clauses operate on the reduced, filtered set of data.  
  
     [!code[csProgGuideCodingConventions#29](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_25.cs)]  
  
-   Use multiple `from` clauses instead of a [join](../vs140/join-clause--csharp-reference-.md) clause to access inner collections. For example, a collection of `Student` objects might each contain a collection of test scores. When the following query is executed, it returns each score that is over 90, along with the last name of the student who received the score.  
  
     [!code[csProgGuideCodingConventions#30](../vs140/codesnippet/CSharp/csharp-coding-conventions--csharp-programming-guide-_26.cs)]  
  
## Security  
 Follow the guidelines in [Secure Coding Guidelines](assetId:///4f882d94-262b-4494-b0a6-ba9ba1f5f177).  
  
## See Also  
 [Visual Basic Coding Conventions](../vs140/visual-basic-coding-conventions.md)   
 [Secure Coding Guidelines](assetId:///4f882d94-262b-4494-b0a6-ba9ba1f5f177)