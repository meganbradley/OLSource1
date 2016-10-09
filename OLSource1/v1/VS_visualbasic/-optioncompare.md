---
title: "-optioncompare"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/optioncompare"
f1_keywords: 
  - "/optioncompare"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "optioncompare compiler option [Visual Basic]"
  - "-optioncompare compiler option [Visual Basic]"
  - "/optioncompare compiler option [Visual Basic]"
ms.assetid: 7237b766-b44d-4cc5-9a3c-885348a7d9e4
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
# -optioncompare
Specifies how string comparisons are made.  
  
## Syntax  
  
```  
/optioncompare:{binary | text}  
```  
  
## Remarks  
 You can specify `/optioncompare` in one of two forms: `/optioncompare:binary` to use binary string comparisons, and `/optioncompare:text` to use text string comparisons. By default, the compiler uses `/optioncompare:binary`.  
  
 In Microsoft Windows, the code page being used determines the binary sort order. A typical binary sort order is as follows:  
  
 `A < B < E < Z < a < b < e < z < À < Ê < Ø < à < ê < ø`  
  
 Text-based string comparisons are based on a case-insensitive text sort order determined by your system's locale. A typical text sort order is as follows:  
  
 `(A = a) < (À = à) < (B=b) < (E=e) < (Ê = ê) < (Z=z) < (Ø = ø)`  
  
### To set /optioncompare in the Visual Studio IDE  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Compile** tab.  
  
3.  Modify the value in the **Option Compare** box.  
  
### To set /optioncompare programmatically  
  
-   See [Option Compare Statement](../VS_visualbasic/option-compare-statement.md).  
  
## Example  
 The following code compiles P`rojFile.vb` and uses binary string comparisons.  
  
```  
vbc /optioncompare:binary projFile.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [/optionexplicit](../VS_visualbasic/-optionexplicit.md)   
 [/optionstrict](../VS_visualbasic/-optionstrict.md)   
 [/optioninfer](../VS_visualbasic/-optioninfer.md)   
 [Sample Compilation Command Lines](../VS_visualbasic/sample-compilation-command-lines--visual-basic-.md)   
 [Option Compare Statement](../VS_visualbasic/option-compare-statement.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../Topic/Visual%20Basic%20Defaults,%20Projects,%20Options%20Dialog%20Box.md)