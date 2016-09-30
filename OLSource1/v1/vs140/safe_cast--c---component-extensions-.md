---
title: "safe_cast (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "safe_cast"
  - "safe_cast_cpp"
  - "stdcli::language::safe_cast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "safe_cast keyword [C++]"
ms.assetid: 4fa688bf-a8ec-49bc-a4c5-f48134efa4f7
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# safe_cast (C++ Component Extensions)
The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operation returns the specified expression as the specified type, if successful; otherwise, throws <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## All Runtimes  
 (There are no remarks for this language feature that apply to all runtimes.)  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> allows you to change the type of a specified expression. In situations where you fully expect a variable or parameter to be convertible to a certain type, you can use safe_cast without a try-catch block to detect programming errors during development. For more information, see [Casting (C++/CX)](http://msdn.microsoft.com/library/windows/apps/hh755802.aspx).  
  
### Syntax  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *type-id*  
 The type to convert *expression* to. A handle to a reference or value type, a value type, or a tracking reference to a reference or value type.  
  
 *expression*  
 An expression that evaluates to a handle to a reference or value type, a value type, or a tracking reference to a reference or value type.  
  
### Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> throws <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if it cannot convert *expression* to the type specified by *type-id*. To catch <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, specify the [/EHsc](../vs140/-eh--exception-handling-model-.md) compiler option, and use a try/catch statement.  
  
### Requirements  
 Compiler option: **/ZW**  
  
### Examples  
 **Example**  
  
 The following code example demonstrates how to use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **Caught expected exception: InvalidCastException**   
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> allows you to change the type of an expression and generate verifiable MSIL code.  
  
### Syntax  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *type-id*  
 A handle to a reference or value type, a value type, or a tracking reference to a reference or value type.  
  
 *expression*  
 An expression that evaluates to a handle to a reference or value type, a value type, or a tracking reference to a reference or value type.  
  
### Remarks  
 The expression <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>*type-id*<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>*expression*<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> converts the operand expression to an object of type type-id.  
  
 The compiler will accept a [static_cast](../vs140/static_cast-operator.md) in most places that it will accept a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  However, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is guaranteed to produce verifiable MSIL, where as a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> could produce unverifiable MSIL.  See [Pure and Verifiable Code](../vs140/pure-and-verifiable-code--c---cli-.md) and [PEVerify Tool (Peverify.exe)](assetId:///f4f46f9e-8d08-4e66-a94b-0c69c9b0bbfa) for more information on verifiable code.  
  
 Like <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> invokes user-defined conversions.  
  
 For more information about casts, see [Casting Operators](../vs140/casting-operators.md).  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does not apply a **const_cast** (cast away **const**).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is in the cli namespace.  See [cli Namespace](../vs140/platform--default--and-cli-namespaces---c---component-extensions-.md) for more information.  
  
 For more information on **safe_cas**t, see:  
  
-   [C-Style Casts with /clr](../vs140/c-style-casts-with--clr--c---cli-.md)  
  
-   [How to: Upcast with safe_cast](../vs140/how-to--use-safe_cast-in-c---cli.md)  
  
-   [How to: Downcast with safe_cast](../vs140/how-to--downcast-with-safe_cast.md)  
  
-   [How to: Using safe_cast and Generic Types](../vs140/how-to--use-safe_cast-and-generic-types.md)  
  
-   [How to: Use safe_cast and User-Defined Conversions](../vs140/how-to--use-safe_cast-and-user-defined-conversions.md)  
  
-   [How to: Use safe_cast and Boxing](../vs140/how-to--use-safe_cast-and-boxing.md)  
  
-   [How to: Use safe_cast and Unboxing](../vs140/how-to--use-safe_cast-and-unboxing.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 One example of where the compiler will not accept a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> but will accept a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is for casts between unrelated interface types.  With <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the compiler will not issue a conversion error and will perform a check at runtime to see if the cast is possible  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **Caught expected exception**   
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)