---
title: "-optioninfer"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/optioninfer"
f1_keywords: 
  - "/optioninfer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-optioninfer compiler option [Visual Basic]"
  - "/optioninfer compiler option [Visual Basic]"
  - "optioninfer compiler option [Visual Basic]"
ms.assetid: f6c09db1-0553-464a-abe3-d4510c61d6ed
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# -optioninfer
Enables the use of local type inference in variable declarations.  
  
## Syntax  
  
```  
/optioninfer[+ | -]  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`+` &#124; `-`|Optional. Specify `/optioninfer+` to enable local type inference, or `/optioninfer-` to block it. The `/optioninfer` option, with no value specified, is the same as `/optioninfer+`. The default value when the `/optioninfer` switch is not present is also `/optioninfer+`. The default value is set in the Vbc.rsp response file.|  
  
> [!NOTE]
>  You can use the `/noconfig` option to retain the compiler's internal defaults instead of those specified in vbc.rsp. The compiler default for this option is `/optioninfer-`.  
  
## Remarks  
 If the source code file contains an [Option Infer Statement](../VS_visualbasic/option-infer-statement.md), the statement overrides the `/optioninfer` command-line compiler setting.  
  
### To set /optioninfer in the Visual Studio IDE  
  
1.  Select a project in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [NIB: Managing Project Properties with the Project Designer](assetId:///983f3c18-832f-4666-afec-74b716ff3e0e).  
  
2.  On the **Compile** tab, modify the value in the **Option infer** box.  
  
## Example  
 The following code compiles `test.vb` with local type inference enabled.  
  
```  
vbc /optioninfer+ test.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [/optioncompare](../VS_visualbasic/-optioncompare.md)   
 [/optionexplicit](../VS_visualbasic/-optionexplicit.md)   
 [/optionstrict](../VS_visualbasic/-optionstrict.md)   
 [Sample Compilation Command Lines](../VS_visualbasic/sample-compilation-command-lines--visual-basic-.md)   
 [Option Infer Statement](../VS_visualbasic/option-infer-statement.md)   
 [Local Type Inference](../VS_visualbasic/local-type-inference--visual-basic-.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../Topic/Visual%20Basic%20Defaults,%20Projects,%20Options%20Dialog%20Box.md)   
 [Compile Page, Project Designer (Visual Basic)](../Topic/Compile%20Page,%20Project%20Designer%20\(Visual%20Basic\).md)   
 [/noconfig](../VS_visualbasic/-noconfig.md)   
 [Building from the Command Line](../VS_visualbasic/building-from-the-command-line--visual-basic-.md)