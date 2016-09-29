---
title: "-GH (Enable _pexit Hook Function)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GH (Enable _pexit Hook Function)"
f1_keywords: 
  - "_pexit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Gh compiler option [C++]"
  - "Gh compiler option [C++]"
  - "_pexit function"
  - "-Gh compiler option [C++]"
ms.assetid: 93181453-2676-42e5-bf63-3b19e07299b6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GH (Enable _pexit Hook Function)
Calls the `_pexit` function at the end of every method or function.  
  
## Syntax  
  
```  
/GH  
```  
  
## Remarks  
 The `_pexit` function is not part of any library and it is up to you to provide a definition for `_pexit`.  
  
 Unless you plan to explicitly call `_pexit`, you do not need to provide a prototype. The function must appear as if it had the following prototype, and it must push the content of all registers on entry and pop the unchanged content on exit:  
  
```  
void __declspec(naked) _cdecl _pexit( void );  
```  
  
 `_pexit` is similar to `_penter`; see [/Gh (Enable _penter Hook Function)](../vs140/-gh--enable-_penter-hook-function-.md) for an example of how to write a `_pexit` function.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)