---
title: "-vbruntime"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/vbruntime"
f1_keywords: 
  - "vbruntime"
  - "/vbruntime"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "vbruntime compiler option [Visual Basic]"
  - "-vbruntime compiler option [Visual Basic]"
  - "/vbruntime compiler option [Visual Basic]"
ms.assetid: 1aa0239e-511a-4c29-957d-fd72877b350a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -vbruntime
Specifies that the compiler should compile without a reference to the Visual Basic Runtime Library, or with a reference to a specific runtime library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 \-  
 Compile without a reference to the Visual Basic Runtime Library.  
  
 \+  
 Compile with a reference to the default Visual Basic Runtime Library.  
  
 \*  
 Compile without a reference to the Visual Basic Runtime Library, and embed core functionality from the Visual Basic Runtime Library into the assembly.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Compile with a reference to the specified library (DLL).  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> compiler option enables you to specify that the compiler should compile without a reference to the Visual Basic Runtime Library. If you compile without a reference to the Visual Basic Runtime Library, errors or warnings are logged on code or language constructs that generate a call to a Visual Basic runtime helper. (A *Visual Basic runtime helper* is a function defined in Microsoft.VisualBasic.dll that is called at runtime to execute a specific language semantic.)  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option produces the same behavior that occurs if no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> switch is specified. You can use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option to override previous <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> switches.  
  
 Most objects of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type are unavailable when you use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> options.  
  
## Embedding Visual Basic Runtime core functionality  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> option enables you to compile without a reference to a runtime library. Instead, core functionality from the Visual Basic Runtime Library is embedded in the user assembly. You can use this option if your application runs on platforms that do not contain the Visual Basic runtime.  
  
 The following runtime members are embedded:  
  
-   \<xref:Microsoft.VisualBasic.CompilerServices.Conversions> class  
  
-   \<xref:Microsoft.VisualBasic.Strings.AscW(System.Char)> method  
  
-   \<xref:Microsoft.VisualBasic.Strings.AscW(System.String)> method  
  
-   \<xref:Microsoft.VisualBasic.Strings.ChrW(System.Int32)> method  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbBack> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbCr> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbCrLf> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbFormFeed> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbLf> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbNewLine> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbNullChar> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbNullString> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbTab> constant  
  
-   \<xref:Microsoft.VisualBasic.Constants.vbVerticalTab> constant  
  
-   Some objects of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type  
  
 If you compile using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> option and your code references a member from the Visual Basic Runtime Library that is not embedded with the core functionality, the compiler returns an error that indicates that the member is not available.  
  
## Referencing a specified library  
 You can use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to compile with a reference to a custom runtime library instead of the default Visual Basic Runtime Library.  
  
 If the value for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument is a fully qualified path to a DLL, the compiler will use that file as the runtime library. If the value for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument is not a fully qualified path to a DLL, the Visual Basic compiler will search for the identified DLL in the current folder first. It will then search in the path that you have specified by using the [/sdkpath](../vs140/-sdkpath.md) compiler option. If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> compiler option is not used, the compiler will search for the identified DLL in the .NET Framework folder (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> option to compile with a reference to a custom library.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Core – New compilation mode in Visual Studio 2010 SP1](http://blogs.msdn.com/b/vbteam/archive/2011/01/10/vb-core-new-compilation-mode-in-visual-studio-2010-sp1.aspx)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [/sdkpath](../vs140/-sdkpath.md)