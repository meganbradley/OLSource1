---
title: "-J (Default char Type Is unsigned)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/J (Default char Type Is unsigned)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.DefaultCharIsUnsigned"
  - "VC.Project.VCCLWCECompilerTool.DefaultCharIsUnsigned"
  - "/j"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "defaults, char type"
  - "char data type"
  - "-J compiler option [C++]"
  - "/J compiler option [C++]"
  - "J compiler option [C++]"
  - "default char type is unsigned"
ms.assetid: 50973667-6638-491e-9c41-bff73acae19f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -J (Default char Type Is unsigned)
Changes the default <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type is zero-extended when it is widened to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value is explicitly declared as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the **/J** option does not affect it, and the value is sign-extended when it is widened to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type.  
  
 The **/J** option defines <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which is used with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the LIMITS.h file to define the range of the default <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type.  
  
 ANSI C and C++ do not require a specific implementation of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type. This option is useful when you are working with character data that will eventually be translated into a language other than English.  
  
> [!NOTE]
>  If you use this compiler option with ATL/MFC, an error might be generated. Although you could disable this error by defining <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, this workaround is not supported and may not always work.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.  
  
2.  In the project **Property Pages** dialog box, in the left pane under **Configuration Properties**, expand **C/C++** and then select **Command Line**.  
  
3.  In the **Additional Options** pane, specify the **/J** compiler option.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.DefaultCharIsUnsigned*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md)