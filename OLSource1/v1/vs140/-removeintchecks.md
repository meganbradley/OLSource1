---
title: "-removeintchecks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/removeintchecks"
f1_keywords: 
  - "removeintchecks"
  - "/removeintchecks"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "removeintchecks compiler option [Visual Basic]"
  - "/removeintchecks compiler option [Visual Basic]"
  - "-removeintchecks compiler option [Visual Basic]"
ms.assetid: c1835bd5-1e38-4fba-bd2f-6984774765d4
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -removeintchecks
Turns overflow-error checking for integer operations on or off.  
  
## Syntax  
  
```  
/removeintchecks[+ | -]  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`+` &#124; `-`|Optional. The `/removeintchecks-` option causes the compiler to check all integer calculations for overflow errors. The default is `/removeintchecks-`.<br /><br /> Specifying `/removeintchecks` or `/removeintchecks+` prevents error checking and can make integer calculations faster. However, without error checking, and if data type capacities are overflowed, incorrect results may be stored without raising an error.|  
  
||  
|-|  
|To set /removeintchecks in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).<br />2.  Click the **Compile** tab.<br />3.  Click the **Advanced** button.<br />4.  Modify the value of the **Remove integer overflow checks** box.|  
  
## Example  
 The following code compiles `Test.vb` and turns off integer overflow-error checking.  
  
```  
vbc /removeintchecks+ test.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)