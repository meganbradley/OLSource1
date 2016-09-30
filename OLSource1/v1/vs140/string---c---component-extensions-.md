---
title: "String  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string support with /clr"
  - "/clr compiler option [C++], string support"
ms.assetid: c695f965-9be0-4e20-9661-373bfee6557e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String  (C++ Component Extensions)
The Visual C++ compiler supports *strings*, which are objects that represent text as a sequence of characters. Visual C++ supports string variables, whose value is implicit, and literals, whose value is an explicit quoted string.  
  
## All Runtimes  
 The Windows Runtime and common language runtime represent strings as objects whose allocated memory is managed automatically. That is, you are not required to explicitly discard the memory for a string when the string variable goes out of scope or your application ends. To indicate that the lifetime of a string object is to be managed automatically, declare the string type with the [handle-to-object (^)](../vs140/handle-to-object-operator--^----c---component-extensions-.md) modifier.  
  
## Windows Runtime  
 The Windows Runtime architecture requires Visual C++ to implement the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data type in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespace. For your convenience, Visual C++ also provides the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type, which is a synonym for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> namespace.  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 For more information and examples about strings, see [Platform::String, std::wstring, and Literals (Platform)](assetId:///ec92fbc6-edf3-4137-a85e-8e29bdb857a8)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 This topic discusses how the Visual C++ compiler processes string literals when you run it by using the **/clr** compiler option. To use **/clr**, you must also use the common language runtime (CLR), C++/CLI syntax and managed objects. For more information about **/clr**, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
 When compiling with **/clr**, the compiler will convert string literals to strings of type \<xref:System.String*>. To preserve backward compatibility with existing code there are two exceptions to this:  
  
-   Exception handling. When a string literal is thrown, the compiler will catch it as a string literal.  
  
-   Template deduction. When a string literal is passed as a template argument, the compiler will not convert it to a \<xref:System.String*>. Note, string literals passed as a generic argument will be promoted to \<xref:System.String*>.  
  
 The compiler also has built-in support for three operators, which you can override to customize their behavior:  
  
-   System::String ^ operator +( System::String, System::String);  
  
-   System::String ^ operator +( System::Object, System::String);  
  
-   System::String ^ operator +( System::String, System::Object);  
  
 When passed a \<xref:System.String*>, the compiler will box, if necessary, and then concatenate the object (with ToString) with the string.  
  
 When compiling with **/clr:oldSyntax**, string literals will not be converted to \<xref:System.String*>.  
  
> [!NOTE]
>  The caret ("^") indicates that the declared variable is a handle to a C++/CLI managed object.  
  
 For more information see [C++ String Literals](../vs140/string-and-character-literals---c---.md).  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example demonstrates concatenating and comparing strings.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **abcdef**   
 **abcghi**   
 **ghiabc**   
 **c**   
 **abcdefghi**   
 **abczzz**   
 **abc1**   
 **abc97**   
 **abc3.1**   
 **abcdef**   
 **a and b are equal**   
 **a and b are not equal**   
 **abc**   
 **n is empty** **Example**  
  
 The following sample shows that you can overload the compiler-provided operators, and that the compiler will find a function overload based on the \<xref:System.String*> type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **overloaded +(String ^ a, String ^ b)**   
 **overloaded +(String ^ a, Object ^ b)**   
 **overloaded +(Object ^ a, String ^ b)**   
 **String ^ a**   
 **const char \* a** **Example**  
  
 The following sample shows that the compiler distinguishes between native strings and \<xref:System.String*> strings.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **char \***   
 **String^ str**   
 **System.SByte\***   
 **System.String**   
## See Also  
 [Language Features for Targeting the CLR](../vs140/component-extensions-for-runtime-platforms.md)   
 [C++ String Literals](../vs140/string-and-character-literals---c---.md)   
 [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)