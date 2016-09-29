---
title: "-optionexplicit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/optionexplicit"
f1_keywords: 
  - "/optionexplicit"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/optionexplicit compiler option [Visual Basic]"
  - "optionexplicit compiler option [Visual Basic]"
  - "-optionexplicit compiler option [Visual Basic]"
ms.assetid: 5d296ab3-bafe-4c4d-9887-78f162ed86c7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -optionexplicit
Causes the compiler to report errors if variables are not declared before they are used.  
  
## Syntax  
  
```  
/optionexplicit[+ | -]  
```  
  
## Arguments  
 `+` &#124; `-`  
 Optional. Specify `/optionexplicit+` to require explicit declaration of variables. The `/optionexplicit+` option is the default and is the same as `/optionexplicit`. The `/optionexplicit-` option enables implicit declaration of variables.  
  
## Remarks  
 If the source code file contains an [Option Explicit Statement (Visual Basic)](../vs140/option-explicit-statement--visual-basic-.md), the statement overrides the `/optionexplicit` command-line compiler setting.  
  
### To set /optionexplicit in the Visual Studio IDE  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Modify the value in the **Option Explicit** box.  
  
## Example  
 The following code compiles when `/optionexplicit-` is used.  
  
 [!code[VbVbalrCompiler#5](../vs140/codesnippet/VisualBasic/-optionexplicit_1.vb)]  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/optioncompare](../vs140/-optioncompare.md)   
 [/optionstrict](../vs140/-optionstrict.md)   
 [/optioninfer](../vs140/-optioninfer.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../vs140/visual-basic-defaults--projects--options-dialog-box.md)