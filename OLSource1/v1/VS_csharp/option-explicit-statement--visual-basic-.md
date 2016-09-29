---
title: "Option Explicit Statement (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Explicit"
  - "vb.OptionExplicit"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "declaring variables, explicit"
  - "forced variable declaration in Option Explicit statement"
  - "Explicit keyword"
  - "explicit variable declaration"
  - "Option Explicit statement"
ms.assetid: e82ac1ad-2cd3-49b2-b985-8bcf016f3fcc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Explicit Statement (Visual Basic)
Forces explicit declaration of all variables in a file, or allows implicit declarations of variables.  
  
## Syntax  
  
```  
Option Explicit { On | Off }  
```  
  
## Parts  
 `On`  
 Optional. Enables `Option Explicit` checking. If `On` or `Off` is not specified, the default is `On`.  
  
 `Off`  
 Optional. Disables `Option Explicit` checking.  
  
## Remarks  
 When `Option Explicit On` or `Option Explicit` appears in a file, you must explicitly declare all variables by using the `Dim` or `ReDim` statements. If you try to use an undeclared variable name, an error occurs at compile time. The `Option Explicit Off` statement allows implicit declaration of variables.  
  
 If used, the `Option Explicit` statement must appear in a file before any other source code statements.  
  
> [!NOTE]
>  Setting `Option Explicit` to `Off` is generally not a good practice. You could misspell a variable name in one or more locations, which would cause unexpected results when the program is run.  
  
## When an Option Explicit Statement Is Not Present  
 If the source code does not contain an `Option Explicit` statement, the **Option Explicit** setting on the [Compile Page, Project Designer (Visual Basic)](../VS_csharp/compile-page--project-designer--visual-basic-.md) is used. If the command-line compiler is used, the [/optionexplicit](../VS_csharp/-optionexplicit.md) compiler option is used.  
  
#### To set Option Explicit in the IDE  
  
1.  In **Solution Explorer**, select a project. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Set the value in the **Option Explicit** box.  
  
 When you create a new project, the **Option Explicit** setting on the **Compile** tab is set to the **Option Explicit** setting in the **VB Defaults** dialog box. To access the **VB Defaults** dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting in **VB Defaults** is `On`.  
  
#### To set Option Explicit on the command line  
  
-   Include the [/optionexplicit](../VS_csharp/-optionexplicit.md) compiler option in the **vbc** command.  
  
## Example  
 The following example uses the `Option Explicit` statement to force explicit declaration of all variables. Attempting to use an undeclared variable causes an error at compile time.  
  
 [!code[VbVbalrStatements#47](../VS_csharp/codesnippet/VisualBasic/option-explicit-statement--visual-basic-_1.vb)]  
  
 [!code[VbVbalrStatements#48](../VS_csharp/codesnippet/VisualBasic/option-explicit-statement--visual-basic-_2.vb)]  
  
## See Also  
 [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)   
 [ReDim Statement](../VS_csharp/redim-statement--visual-basic-.md)   
 [Option Compare Statement](../VS_csharp/option-compare-statement.md)   
 [Option Strict Statement](../VS_csharp/option-strict-statement.md)   
 [/optioncompare](../VS_csharp/-optioncompare.md)   
 [/optionexplicit](../VS_csharp/-optionexplicit.md)   
 [/optionstrict](../VS_csharp/-optionstrict.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../VS_csharp/visual-basic-defaults--projects--options-dialog-box.md)