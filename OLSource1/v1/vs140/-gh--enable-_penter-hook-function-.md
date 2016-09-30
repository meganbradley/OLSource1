---
title: "-Gh (Enable _penter Hook Function)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Gh (Enable _penter Hook Function)"
f1_keywords: 
  - "_penter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Gh compiler option [C++]"
  - "Gh compiler option [C++]"
  - "_penter function"
  - "-Gh compiler option [C++]"
ms.assetid: 1510a082-8a0e-486e-a309-6add814b494f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Gh (Enable _penter Hook Function)
Causes a call to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function at the start of every method or function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is not part of any library and it is up to you to provide a definition for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Unless you plan to explicitly call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you do not need to provide a prototype. The function must appear as if it had the following prototype, and it must push the content of all registers on entry and pop the unchanged content on exit:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This declaration is not available for 64-bit projects.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## Example  
 The following code, when compiled with **/Gh**, shows how <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called twice; once when entering function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and once when entering function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **In a function!**  
**In a function!**   
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)