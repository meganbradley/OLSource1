---
title: "-optionstrict"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/optionstrict"
f1_keywords: 
  - "/optionstrict"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-optionstrict compiler option [Visual Basic]"
  - "optionstrict compiler option [Visual Basic]"
  - "/optionstrict compiler option [Visual Basic]"
ms.assetid: c7b10086-0fa4-49db-b3c8-4ae0db5957da
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -optionstrict
Enforces strict type semantics to restrict implicit type conversions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option restricts implicit type conversion. The default for this option is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You can use both for permissive type semantics.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required. Warn when strict language semantics are not respected.  
  
## Remarks  
 When <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is in effect, only widening type conversions can be made implicitly. Implicit narrowing type conversions, such as assigning a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type object to an integer type object, are reported as errors.  
  
 To generate warnings for implicit narrowing type conversions, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to ignore particular warnings and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to treat particular warnings as errors.  
  
### To set /optionstrict in the Visual Studio IDE  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties.** For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Modify the value in the **Option Strict** box.  
  
### To set /optionstrict programmatically  
  
-   See [Option Strict Statement](../vs140/option-strict-statement.md).  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> using strict type semantics.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/optioncompare](../vs140/-optioncompare.md)   
 [/optionexplicit](../vs140/-optionexplicit.md)   
 [/optioninfer](../vs140/-optioninfer.md)   
 [/nowarn](../vs140/-nowarn.md)   
 [/warnaserror (Visual Basic)](../vs140/-warnaserror--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../vs140/visual-basic-defaults--projects--options-dialog-box.md)