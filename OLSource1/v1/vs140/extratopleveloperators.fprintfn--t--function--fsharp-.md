---
title: "ExtraTopLevelOperators.fprintfn&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "ExtraTopLevelOperators.fprintfn<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatLineToTextWriter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ExtraTopLevelOperators.fprintfn function [F#]"
  - "ExtraTopLevelOperators.PrintFormatLineToTextWriter function [F#]"
  - "PrintFormatLineToTextWriter function [F#]"
  - "fprintfn function [F#]"
ms.assetid: 2a1edd66-53b8-460d-a71b-616c54dca561
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.fprintfn&lt;&#39;T&gt; Function (F#)
The fprintfn prints to a file using the given format, and add a newline.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.IO.TextWriter*>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Return Value  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to print a listing of the contents of a directory to a specified file, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[FsCoreLib2#5](../vs140/codesnippet/FSharp/extratopleveloperators.fprintfn--t--function--fsharp-_1.fs)]  
  
## Example  
 The following example is similar to the previous except that it also demonstrates the use of specifiers to customize the output in the format string. For more information on format specifiers, see [Printf Module](../vs140/core.printf-module--fsharp-.md).  
  
 [!code[FsCoreLib2#6](../vs140/codesnippet/FSharp/extratopleveloperators.fprintfn--t--function--fsharp-_2.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)