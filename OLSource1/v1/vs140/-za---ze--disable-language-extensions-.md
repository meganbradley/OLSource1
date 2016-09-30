---
title: "-Za, -Ze (Disable Language Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Za, /Ze (Disable Language Extensions)"
f1_keywords: 
  - "VC.Project.VCCLWCECompilerTool.DisableLanguageExtensions"
  - "/za"
  - "/ze"
  - "VC.Project.VCCLCompilerTool.DisableLanguageExtensions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Za compiler option [C++]"
  - "Za compiler option [C++]"
  - "language extensions, disabling in compiler"
  - "-Ze compiler option [C++]"
  - "language extensions"
  - "enable language extensions"
  - "/Za compiler option [C++]"
  - "/Ze compiler option [C++]"
  - "Disable Language Extensions compiler option"
  - "Ze compiler option [C++]"
ms.assetid: 65e49258-7161-4289-a176-7c5c0656b1a2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Za, -Ze (Disable Language Extensions)
The **/Za** compiler option emits an error for language constructs that are not compatible with ANSI C89 or ISO C++11. The **/Ze** compiler option, which is on by default, enables Microsoft extensions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  The **/Ze** option is deprecated because its behavior is on by default. We recommend you use the [/Zc (Conformance)](../vs140/-zc--conformance-.md) compiler options to control specific language extension features. For a list of deprecated compiler options, see the **Deprecated and Removed Compiler Options** section in [Compiler Options Listed by Category](../vs140/compiler-options-listed-by-category.md).  
  
 The [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] compiler offers a number of features beyond those specified in either the ANSI C89, ISO C99, or ISO C++ standards. These features are known collectively as Microsoft extensions to C and C++. These extensions are available by default, and not available when the **/Za** option is specified. For more information about specific extensions, see [Microsoft Extensions to C and C++](../vs140/microsoft-extensions-to-c-and-c--.md).  
  
 We recommend that you disable language extensions by specifying the **/Za** option if you plan to port your program to other environments. When **/Za** is specified, the compiler treats Microsoft extended keywords as simple identifiers, disables the other Microsoft extensions, and automatically defines the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> predefined macro for C programs.  
  
 Other compiler options used with **/Za** can affect how the compiler ensures standards conformance. For example, **/Za** and [/fp (Specify Floating-Point Behavior)](../vs140/-fp--specify-floating-point-behavior-.md) may result in floating-point type promotion behavior that does not conform to the ISO C99 or C++11 standards.  
  
 For ways to specify specific standards-conformant behavior settings, see the [/Zc](../vs140/-zc--conformance-.md) compiler option.  
  
 For more information about conformance issues with [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], see [Nonstandard Behavior](../vs140/nonstandard-behavior.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  In the navigation pane, choose **Configuration Properties**, **C/C++**, **Language**.  
  
3.  Modify the **Disable Language Extensions** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.DisableLanguageExtensions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [/Zc (Conformance)](../vs140/-zc--conformance-.md)