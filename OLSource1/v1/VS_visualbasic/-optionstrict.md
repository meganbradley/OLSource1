---
title: "-optionstrict"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 17
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
# -optionstrict
Enforces strict type semantics to restrict implicit type conversions.  
  
## Syntax  
  
```  
/optionstrict[+ | -]  
/optionstrict[:custom]  
```  
  
## Arguments  
 `+` &#124; `-`  
 Optional. The `/optionstrict+` option restricts implicit type conversion. The default for this option is `/optionstrict-`. The `/optionstrict+` option is the same as `/optionstrict`. You can use both for permissive type semantics.  
  
 `custom`  
 Required. Warn when strict language semantics are not respected.  
  
## Remarks  
 When `/optionstrict+` is in effect, only widening type conversions can be made implicitly. Implicit narrowing type conversions, such as assigning a `Decimal` type object to an integer type object, are reported as errors.  
  
 To generate warnings for implicit narrowing type conversions, use `/optionstrict:custom`. Use `/nowarn:numberlist` to ignore particular warnings and `/warnaserror:numberlist` to treat particular warnings as errors.  
  
### To set /optionstrict in the Visual Studio IDE  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties.** For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Modify the value in the **Option Strict** box.  
  
### To set /optionstrict programmatically  
  
-   See [Option Strict Statement](../VS_visualbasic/option-strict-statement.md).  
  
## Example  
 The following code compiles `Test.vb` using strict type semantics.  
  
```  
vbc /optionstrict+ test.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [/optioncompare](../VS_visualbasic/-optioncompare.md)   
 [/optionexplicit](../VS_visualbasic/-optionexplicit.md)   
 [/optioninfer](../VS_visualbasic/-optioninfer.md)   
 [/nowarn](../VS_visualbasic/-nowarn.md)   
 [/warnaserror (Visual Basic)](../VS_visualbasic/-warnaserror--visual-basic-.md)   
 [Sample Compilation Command Lines](../VS_visualbasic/sample-compilation-command-lines--visual-basic-.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../Topic/Visual%20Basic%20Defaults,%20Projects,%20Options%20Dialog%20Box.md)