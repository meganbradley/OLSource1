---
title: "-optioninfer"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -optioninfer
Enables the use of local type inference in variable declarations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional. Specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to enable local type inference, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to block it. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option, with no value specified, is the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The default value when the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> switch is not present is also <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The default value is set in the Vbc.rsp response file.|  
  
> [!NOTE]
>  You can use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> option to retain the compiler's internal defaults instead of those specified in vbc.rsp. The compiler default for this option is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the source code file contains an [Option Infer Statement](../vs140/option-infer-statement.md), the statement overrides the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> command-line compiler setting.  
  
### To set /optioninfer in the Visual Studio IDE  
  
1.  Select a project in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [NIB: Managing Project Properties with the Project Designer](assetId:///983f3c18-832f-4666-afec-74b716ff3e0e).  
  
2.  On the **Compile** tab, modify the value in the **Option infer** box.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with local type inference enabled.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/optioncompare](../vs140/-optioncompare.md)   
 [/optionexplicit](../vs140/-optionexplicit.md)   
 [/optionstrict](../vs140/-optionstrict.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../vs140/visual-basic-defaults--projects--options-dialog-box.md)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)   
 [/noconfig](../vs140/-noconfig.md)   
 [Building from the Command Line (Visual Basic)](../vs140/building-from-the-command-line--visual-basic-.md)