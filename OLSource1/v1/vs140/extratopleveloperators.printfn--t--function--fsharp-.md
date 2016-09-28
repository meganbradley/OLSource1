---
title: "ExtraTopLevelOperators.printfn&lt;&#39;T&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.printfn<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatLine``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "printfn function [F#]"
  - "PrintFormatLine function [F#]"
  - "ExtraTopLevelOperators.PrintFormatLine function [F#]"
  - "ExtraTopLevelOperators.printfn function [F#]"
ms.assetid: 3b8e7af1-0931-4d57-9e11-7d7e57c8038c
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.printfn&lt;&#39;T&gt; Function (F#)
The `printfn` function prints to `stdout` using the given format, and adds a newline.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
printfn : TextWriterFormat<'T> -> 'T  
  
// Usage:  
printfn format  
```  
  
#### Parameters  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
## Return Value  
  
## Remarks  
 This function is named `PrintFormatLine` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates the use of `printfn` with various format specifiers. For more information on format specifiers, see [Printf Module](../vs140/core.printf-module--fsharp-.md).  
  
 [!code[FsCoreLib2#9](../vs140/codesnippet/FSharp/extratopleveloperators.printfn--t--function--fsharp-_1.fs)]  
  
 **Printing Boolean values: false true**  
**Printing strings (note literal printing of string with special character): test1C:\test2**  
**Printing an integer in decimal form, with and without a width: -123       1891**  
**Printing an integer in lowercase hexadecimal: ffffff85 or 0x763**  
**Printing as an unsigned integer: 4294967173 1891**  
**Printing an integer as uppercase hexadecimal: FFFFFF85 or 0x763**  
**Printing as an octal integer: 37777777605 3543**  
**Printing in columns.  10099900        15       230       869  -8388114**  
 **10099841        74       289       574  -8388055**  
 **10099782       133       348       429  -8387996**  
 **10099723       192       407       342  -8387937**  
 **10099664       251       466       284  -8387878**  
 **10099605       310       525       243  -8387819**  
 **10099546       369       584       213  -8387760**  
 **10099487       428       643       189  -8387701**  
 **10099428       487       702       170  -8387642**  
 **10099369       546       761       154  -8387583**  
 **10099310       605       820       141  -8387524**  
 **10099251       664       879       130  -8387465**  
 **10099192       723       938       121  -8387406**  
 **10099133       782       997       113  -8387347**  
 **10099074       841      1056       106  -8387288**  
 **10099015       900      1115        99  -8387229**  
**Printing floating point numbers 3.141593e+000 6.022000e+023**  
**Printing floating point numbers 3.141593E+000 6.022000E+023**  
**Printing floating point numbers 3.141593 602200000000000000000000.000000**  
**Printing floating point numbers 3.141593 602200000000000000000000.000000**  
**Printing floating point numbers 3.14159 6.022E+23**  
**Using the width and precision modifiers: 3.14159e+000 6.022e+023**  
**Using the flags:Zero Pad:&#124;0000001001&#124; Plus:&#124;     +1001 &#124;LeftJustify:&#124;1001      &#124; SpacePad:&#124; 1001&#124;**  
**zero pad   &#124; &#124;+- both   &#124; &#124;- and ' ' &#124; &#124;' ' and 0 &#124; &#124; normal**   
**&#124;0000000195&#124; &#124;-30       &#124; &#124;-15       &#124; &#124;-000000869&#124; &#124;      -195&#124;**  
**&#124;0000000178&#124; &#124;-13       &#124; &#124; 2        &#124; &#124;-000001020&#124; &#124;      -178&#124;**  
**&#124;0000000161&#124; &#124;+4        &#124; &#124; 19       &#124; &#124;-000001234&#124; &#124;      -161&#124;**  
**&#124;0000000144&#124; &#124;+21       &#124; &#124; 36       &#124; &#124;-000001562&#124; &#124;      -144&#124;**  
**&#124;0000000127&#124; &#124;+38       &#124; &#124; 53       &#124; &#124;-000002127&#124; &#124;      -127&#124;**  
**&#124;0000000110&#124; &#124;+55       &#124; &#124; 70       &#124; &#124;-000003333&#124; &#124;      -110&#124;**  
**&#124;0000000093&#124; &#124;+72       &#124; &#124; 87       &#124; &#124;-000007691&#124; &#124;       -93&#124;**  
**&#124;0000000076&#124; &#124;+89       &#124; &#124; 104      &#124; &#124; 000024998&#124; &#124;       -76&#124;**  
**&#124;0000000059&#124; &#124;+106      &#124; &#124; 121      &#124; &#124; 000004761&#124; &#124;       -59&#124;**  
**&#124;0000000042&#124; &#124;+123      &#124; &#124; 138      &#124; &#124; 000002631&#124; &#124;       -42&#124;**  
**&#124;0000000025&#124; &#124;+140      &#124; &#124; 155      &#124; &#124; 000001818&#124; &#124;       -25&#124;**  
**&#124;0000000008&#124; &#124;+157      &#124; &#124; 172      &#124; &#124; 000001388&#124; &#124;        -8&#124;**  
**&#124;-000000009&#124; &#124;+174      &#124; &#124; 189      &#124; &#124; 000001123&#124; &#124;         9&#124;**  
**Decimal: 0.124**  
**Print as object: 12 1.1 test FSI_0006+clo@159-44**  
**[&#124;1; 2; 3&#124;]**  
**Printing from a function (no args): X**  
**Printing from a function with arg: Printing 10.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)