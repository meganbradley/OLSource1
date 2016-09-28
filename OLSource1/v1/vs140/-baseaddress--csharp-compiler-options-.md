---
title: "-baseaddress (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/baseaddress (C# Compiler Options)"
f1_keywords: 
  - "/dllbase"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "baseaddress compiler option [C#]"
  - "/baseaddress compiler option [C#]"
  - "-baseaddress compiler option [C#]"
ms.assetid: ce13c965-dfe4-4433-94f5-63b476e3a608
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -baseaddress (C# Compiler Options)
The **/baseaddress** option lets you specify the preferred base address at which to load a DLL. For more information about when and why to use this option, see [Improving Application Startup Time](http://go.microsoft.com/fwlink/?LinkId=107043) and [Larry Osterman's WebLog](http://go.microsoft.com/fwlink/?LinkId=107044).  
  
## Syntax  
  
```  
/baseaddress:address  
```  
  
## Arguments  
 `address`  
 The base address for the DLL. This address can be specified as a decimal, hexadecimal, or octal number.  
  
## Remarks  
 The default base address for a DLL is set by the .NET Framework common language runtime.  
  
 Be aware that the lower-order word in this address will be rounded. For example, if you specify 0x11110001, it will be rounded to 0x11110000.  
  
 To complete the signing process for a DLL, use SN.EXE with the -R option.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Build** property page.  
  
3.  Click the **Advanced** button.  
  
4.  Modify the **DLL Base Address** property.  
  
     To set this compiler option programmatically, see <xref:VSLangProj80.CSharpProjectConfigurationProperties3.BaseAddress*>.  
  
## See Also  
 <xref:System.Diagnostics.ProcessModule.BaseAddress*?displayProperty=fullName>   
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)