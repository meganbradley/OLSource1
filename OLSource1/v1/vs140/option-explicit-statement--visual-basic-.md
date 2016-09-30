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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. Enables <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> checking. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not specified, the default is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Disables <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> checking.  
  
## Remarks  
 When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> appears in a file, you must explicitly declare all variables by using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statements. If you try to use an undeclared variable name, an error occurs at compile time. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement allows implicit declaration of variables.  
  
 If used, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement must appear in a file before any other source code statements.  
  
> [!NOTE]
>  Setting <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is generally not a good practice. You could misspell a variable name in one or more locations, which would cause unexpected results when the program is run.  
  
## When an Option Explicit Statement Is Not Present  
 If the source code does not contain an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement, the **Option Explicit** setting on the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md) is used. If the command-line compiler is used, the [/optionexplicit](../vs140/-optionexplicit.md) compiler option is used.  
  
#### To set Option Explicit in the IDE  
  
1.  In **Solution Explorer**, select a project. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Set the value in the **Option Explicit** box.  
  
 When you create a new project, the **Option Explicit** setting on the **Compile** tab is set to the **Option Explicit** setting in the **VB Defaults** dialog box. To access the **VB Defaults** dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting in **VB Defaults** is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
#### To set Option Explicit on the command line  
  
-   Include the [/optionexplicit](../vs140/-optionexplicit.md) compiler option in the **vbc** command.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement to force explicit declaration of all variables. Attempting to use an undeclared variable causes an error at compile time.  
  
 [!code[VbVbalrStatements#47](../vs140/codesnippet/VisualBasic/option-explicit-statement--visual-basic-_1.vb)]  
  
 [!code[VbVbalrStatements#48](../vs140/codesnippet/VisualBasic/option-explicit-statement--visual-basic-_2.vb)]  
  
## See Also  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [Option Compare Statement](../vs140/option-compare-statement.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [/optioncompare](../vs140/-optioncompare.md)   
 [/optionexplicit](../vs140/-optionexplicit.md)   
 [/optionstrict](../vs140/-optionstrict.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../vs140/visual-basic-defaults--projects--options-dialog-box.md)