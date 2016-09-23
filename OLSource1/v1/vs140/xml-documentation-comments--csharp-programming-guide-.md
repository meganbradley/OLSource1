---
title: "XML Documentation Comments (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - cs.xml
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - XML [C#], code comments
  - comments [C#], XML
  - documentation comments [C#]
  - C# source code files
  - C# language, XML code comments
  - XML documentation comments [C#]
ms.assetid: 803b7f7b-7428-4725-b5db-9a6cff273199
caps.latest.revision: 30
translation.priority.ht: 
  - de-de
  - ja-jp
---
# XML Documentation Comments (C# Programming Guide)
In Visual C# you can create documentation for your code by including XML elements in special comment fields (indicated by triple slashes) in the source code directly before the code block to which the comments refer, for example:  
  
```  
/// <summary>  
///  This class performs an important function.  
/// </summary>  
public class MyClass{}  
```  
  
 When you compile with the [/doc](../vs140/-doc--csharp-compiler-options-.md) option, the compiler will search for all XML tags in the source code and create an XML documentation file. To create the final documentation based on the compiler-generated file, you can create a custom tool or use a tool such as [Sandcastle](http://go.microsoft.com/fwlink/?LinkId=124061).  
  
 To refer to XML elements (for example, your function processes specific XML elements that you want to describe in an XML documentation comment), you can use the standard quoting mechanism (`<` and `>`).  To refer to generic identifiers in code reference (`cref`) elements, you can use either the escape characters (for example, `cref=”List<T>”`) or braces (`cref=”List{T}”`).  As a special case, the compiler parses the braces as angle brackets to make the documentation comment less cumbersome to author when referring to generic identifiers.  
  
> [!NOTE]
>  The XML documentation comments are not metadata; they are not included in the compiled assembly and therefore they are not accessible through reflection.  
  
## In This Section  
  
-   [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)  
  
-   [Processing the XML File](../vs140/processing-the-xml-file--csharp-programming-guide-.md)  
  
-   [Delimiters for Documentation Tags](../vs140/delimiters-for-documentation-tags--csharp-programming-guide-.md)  
  
-   [How to: Use the XML Documentation Features](../vs140/how-to--use-the-xml-documentation-features--csharp-programming-guide-.md)  
  
## Related Sections  
 For more information, see:  
  
-   [/doc (Process Documentation Comments)](../vs140/-doc--csharp-compiler-options-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)