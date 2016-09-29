---
title: "=&gt; Operator (C# Reference)"
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
  - "=>_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "lambda operator [C#]"
  - "=> operator [C#]"
  - "lambda expressions [C#], => operator"
ms.assetid: 8c899251-dafa-4594-bec7-243b39072880
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# =&gt; Operator (C# Reference)
The `=>` token is called the lambda operator. It is used in *lambda expressions* to separate the input variables on the left side from the lambda body on the right side. Lambda expressions are inline expressions similar to anonymous methods but more flexible; they are used extensively in LINQ queries that are expressed in method syntax. For more information, see [Lambda Expressions (C# Programming Guide)](../VS_csharp/lambda-expressions--csharp-programming-guide-.md).  
  
 The following example shows two ways to find and display the length of the shortest string in an array of strings. The first part of the example applies a lambda expression (`w => w.Length`) to each element of the `words` array and then uses the <xref:System.Linq.Enumerable.Min*> method to find the smallest length. For comparison, the second part of the example shows a longer solution that uses query syntax to do the same thing.  
  
```c#  
string[] words = { "cherry", "apple", "blueberry" };  
  
// Use method syntax to apply a lambda expression to each element  
// of the words array.   
int shortestWordLength = words.Min(w => w.Length);  
Console.WriteLine(shortestWordLength);  
  
// Compare the following code that uses query syntax.  
// Get the lengths of each word in the words array.  
var query = from w in words  
            select w.Length;  
// Apply the Min method to execute the query and get the shortest length.  
int shortestWordLength2 = query.Min();  
Console.WriteLine(shortestWordLength2);  
  
// Output:   
// 5  
// 5  
```  
  
## Remarks  
 The `=>` operator has the same precedence as the assignment operator (`=`) and is right-associative.  
  
 You can specify the type of the input variable explicitly or let the compiler infer it; in either case, the variable is strongly typed at compile time. When you specify a type, you must enclose the type name and the variable name in parentheses, as the following example shows.  
  
```  
int shortestWordLength = words.Min((string w) => w.Length);  
```  
  
## Example  
 The following example shows how to write a lambda expression for the overload of the standard query operator <xref:System.Linq.Enumerable.Where*?displayProperty=fullName> that takes two arguments. Because the lambda expression has more than one parameter, the parameters must be enclosed in parentheses. The second parameter, `index`, represents the index of the current element in the collection. The `Where` expression returns all the strings whose lengths are less than their index positions in the array.  
  
```c#  
static void Main(string[] args)  
{  
    string[] digits = { "zero", "one", "two", "three", "four", "five",   
            "six", "seven", "eight", "nine" };  
  
    Console.WriteLine("Example that uses a lambda expression:");  
    var shortDigits = digits.Where((digit, index) => digit.Length < index);  
    foreach (var sD in shortDigits)  
    {  
        Console.WriteLine(sD);  
    }  
  
    // Output:  
    // Example that uses a lambda expression:  
    // five  
    // six  
    // seven  
    // eight  
    // nine  
}  
```  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Lambda Expressions (C# Programming Guide)](../VS_csharp/lambda-expressions--csharp-programming-guide-.md)