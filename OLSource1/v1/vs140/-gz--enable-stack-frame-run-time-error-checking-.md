---
title: "-GZ (Enable Stack Frame Run-Time Error Checking)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GZ (Enable Stack Frame Run-Time Error Checking)"
f1_keywords: 
  - "/gz"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-GZ compiler option [C++]"
  - "release-build errors"
  - "/GZ compiler option [C++]"
  - "GZ compiler option [C++]"
  - "debug builds, catch release-build errors"
ms.assetid: b3efeeff-d5e3-4057-91c9-f6fc73d0270c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GZ (Enable Stack Frame Run-Time Error Checking)
Performs the same operations as the [/RTC (Run-Time Error Checks)](../vs140/-rtc--run-time-error-checks-.md) option. Deprecated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 **/GZ** is only for use in a nonoptimized ([/Od (Disable (Debug))](../vs140/-od--disable--debug--.md)) build.  
  
 **/GZ** is deprecated; use [/RTC1](../vs140/-rtc--run-time-error-checks-.md) instead. For more information, see [Deprecated Compiler Options in Visual C++ 2005](assetId:///aa59fce3-50b8-4f66-9aeb-ce09a7a84cce).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)