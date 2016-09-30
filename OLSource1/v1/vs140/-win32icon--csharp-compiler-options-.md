---
title: "-win32icon (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/win32icon (C# Compiler Options)"
f1_keywords: 
  - "/win32icon"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "win32icon compiler option [C#]"
  - "/win32icon compiler option [C#]"
  - "-win32icon compiler option [C#]"
ms.assetid: 756d9b6d-ab07-41b7-ba58-5bd88f711138
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -win32icon (C# Compiler Options)
The **/win32icon** option inserts an .ico file in the output file, which gives the output file the desired appearance in the File Explorer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The .ico file that you want to add to your output file.  
  
## Remarks  
 An .ico file can be created with the [Resource Compiler](http://go.microsoft.com/fwlink/?LinkId=148370). The Resource Compiler is invoked when you compile a Visual C++ program; an .ico file is created from the .rc file.  
  
 See [/linkresource](../vs140/-linkresource--csharp-compiler-options-.md) (to reference) or [/resource](../vs140/-resource--csharp-compiler-options-.md) (to attach) a .NET Framework resource file. See [/win32res](../vs140/-win32res--csharp-compiler-options-.md) to import a .res file.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** pages.  
  
2.  Click the **Application** property page.  
  
3.  Modify the **Application icon** property.  
  
 For information on how to set this compiler option programmatically, see \<xref:VSLangProj80.ProjectProperties3.ApplicationIcon*>.  
  
## Example  
 Compile <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and attach an .ico file <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to produce <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)