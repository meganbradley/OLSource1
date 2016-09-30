---
title: "extern (C# Reference)"
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
  - "extern_CSharpKeyword"
  - "extern"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "DllImport attribute"
  - "extern keyword [C#]"
ms.assetid: 9c3f02c4-51b8-4d80-9cb2-f2b6e1ae15c7
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extern (C# Reference)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> modifier is used to declare a method that is implemented externally. A common use of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier is with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute when you are using Interop services to call into unmanaged code. In this case, the method must also be declared as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, as shown in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword can also define an external assembly alias, which makes it possible to reference different versions of the same component from within a single assembly. For more information, see [extern alias](../vs140/extern-alias--csharp-reference-.md).  
  
 It is an error to use the [abstract](../vs140/abstract--csharp-reference-.md) and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifiers together to modify the same member. Using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modifier means that the method is implemented outside the C# code, whereas using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> modifier means that the method implementation is not provided in the class.  
  
 The extern keyword has more limited uses in C# than in C++. To compare the C# keyword with the C++ keyword, see Using extern to Specify Linkage in the C++ Language Reference.  
  
## Example  
 **Example 1.** In this example, the program receives a string from the user and displays it inside a message box. The program uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method imported from the User32.dll library.  
  
 [!code[csrefKeywordsModifiers#8](../vs140/codesnippet/CSharp/extern--csharp-reference-_1.cs)]  
  
## Example  
 **Example 2.** This example illustrates a C# program that calls into a C library (a native DLL).  
  
 1. Create the following C file and name it <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 2. Open a Visual Studio x64 (or x32) Native Tools Command Prompt window from the Visual Studio installation directory and compile the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> file by typing **cl /LD cmdll.c** at the command prompt.  
  
 3. In the same directory, create the following C# file and name it <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 3. Open a Visual Studio x64 (or x32) Native Tools Command Prompt window from the Visual Studio installation directory and compile the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> file by typing:  
  
> **csc cm.cs** (for the x64 command prompt)   
>  —or—  
> **csc /platform:x86 cm.cs** (for the x32 command prompt)  
  
 This will create the executable file <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 4. Run <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method passes the value 5 to the DLL file, which returns the value multiplied by 10.  The program produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Runtime.InteropServices.DllImportAttribute*?displayProperty=fullName>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)