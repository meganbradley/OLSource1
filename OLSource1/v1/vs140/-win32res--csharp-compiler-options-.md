---
title: "-win32res (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/win32res (C# Compiler Options)"
f1_keywords: 
  - "/win32res"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "win32res compiler option"
  - "/win32res compiler option [C#]"
  - "-win32res compiler option [C#]"
  - "win32res compiler option [C#]"
ms.assetid: 3c33f750-6948-4c7e-a27e-bef98f77255b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -win32res (C# Compiler Options)
The **/win32res** option inserts a Win32 resource in the output file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource file that you want to add to your output file.  
  
## Remarks  
 A Win32 resource file can be created with the [Resource Compiler](http://go.microsoft.com/fwlink/?LinkId=148370). The Resource Compiler is invoked when you compile a Visual C++ program; a .res file is created from the .rc file.  
  
 A Win32 resource can contain version or bitmap (icon) information that would help identify your application in the File Explorer. If you do not specify **/win32res**, the compiler will generate version information based on the assembly version.  
  
 See [/linkresource](../vs140/-linkresource--csharp-compiler-options-.md) (to reference) or [/resource](../vs140/-resource--csharp-compiler-options-.md) (to attach) a .NET Framework resource file.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Application** property page.  
  
3.  Click on the **Resource File** button and choose a file by using the combo box.  
  
## Example  
 Compile <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and attach a Win32 resource file <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to produce <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)