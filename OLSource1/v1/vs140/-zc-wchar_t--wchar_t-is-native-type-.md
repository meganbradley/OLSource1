---
title: "-Zc:wchar_t (wchar_t Is Native Type)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zc:wchar_t (wchar_t Is Native Type)"
f1_keywords: 
  - "VC.Project.VCCLWCECompilerTool.TreatWChar_tAsBuiltInType"
  - "VC.Project.VCCLCompilerTool.TreatWChar_tAsBuiltInType"
  - "/Zc:wchar_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Zc compiler options [C++]"
  - "-Zc compiler options [C++]"
  - "wchar_t type"
  - "Conformance compiler options"
  - "Zc compiler options [C++]"
ms.assetid: b0de5a84-da72-4e5a-9a4e-541099f939e0
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zc:wchar_t (wchar_t Is Native Type)
Parse <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> as a built-in type according to the C++ standard. By default, **/Zc:wchar_t** is on.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If **/Zc:wchar_t** is on, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> maps to the Microsoft-specific native type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If **/Zc:wchar_t-** (with a minus sign) is specified, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> maps to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. (In Visual C++ 6.0 and earlier, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> was not implemented as a built-in type, but was declared in wchar.h as a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.) We do not recommend **/Zc:wchar_t-** because the C++ standard requires that <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> be a built-in type. Using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> version can cause portability problems. If you upgrade from earlier versions of Visual C++ and encounter compiler error [C2664](../vs140/compiler-error-c2664.md) because the code is trying to implicitly convert a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, we recommend that you change the code to fix the error, instead of setting **/Zc:wchar_t-**.  
  
 Microsoft implements <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as a two-byte unsigned value. For more information about <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, see [Data Type Ranges](../vs140/data-type-ranges.md) and [Fundamental Types](../vs140/fundamental-types---c---.md).  
  
 If you write new code that has to interoperate with older code that still uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, you can provide overloads for both the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variations of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, so that your code can be linked with code compiled with **/Zc:wchar_t** or code compiled without it. Otherwise, you would have to provide two different builds of the library—one with and one without **/Zc:wchar_t** enabled. Even in this case, we recommend that you build the older code by using the same compiler that you use to compile the new code. Never mix binaries compiled with different compilers.  
  
 When **/Zc:wchar_t** is specified, **_WCHAR_T_DEFINED** and **_NATIVE_WCHAR_T_DEFINED** symbols are defined. For more information, see [Predefined Macros](../vs140/predefined-macros.md).  
  
 If your code uses the compiler COM global functions, because **/Zc:wchar_t** is now on by default, we recommend that you change explicit references to comsupp.lib—from the [comment pragma](../vs140/comment--c-c---.md) or on the command line—to either comsuppw.lib or comsuppwd.lib. (If you must compile with **/Zc:wchar_t-**, use comsupp.lib.) If you include the comdef.h header file, the correct library is specified for you. For information about compiler COM support, see [Compiler COM Support](../vs140/compiler-com-support.md).  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> type is not supported when you compile C code. For more information about conformance issues with Visual C++, see [Nonstandard Behavior](../vs140/nonstandard-behavior.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  In the left pane, expand **Configuration Properties**, **C/C++**, and then select **Language**.  
  
3.  Modify the **Treat wchar_t as Built-in Type** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.TreatWChar_tAsBuiltInType*>.  
  
## See Also  
 [/Zc (Conformance)](../vs140/-zc--conformance-.md)