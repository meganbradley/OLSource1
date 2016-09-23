---
title: "-filealign (C# Compiler Options)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: /filealign (C# Compiler Options)
f1_keywords: 
  - /filealign
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - /alignment compiler option [C#]
  - filealign compiler option [C#]
  - -filealign compiler option [C#]
  - /sections compiler option [C#]
  - alignment compiler option [C#]
  - sections compiler option [C#]
  - -sections compiler option [C#]
  - /filealign compiler option [C#]
  - file sharing [C#]
  - -alignment compiler option [C#]
  - section alignment [C#]
ms.assetid: 15cf1c98-3798-4ced-9f08-60619308a073
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -filealign (C# Compiler Options)
The **/filealign** option lets you specify the size of sections in your output file.  
  
## Syntax  
  
```  
/filealign:number  
```  
  
## Arguments  
 `number`  
 A value that specifies the size of sections in the output file. Valid values are 512, 1024, 2048, 4096, and 8192. These values are in bytes.  
  
## Remarks  
 Each section will be aligned on a boundary that is a multiple of the **/filealign** value. There is no fixed default. If **/filealign** is not specified, the common language runtime picks a default at compile time.  
  
 By specifying the section size, you affect the size of the output file. Modifying section size may be useful for programs that will run on smaller devices.  
  
 Use [DUMPBIN](../vs140/dumpbin-options.md) to see information about sections in your output file.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Build** property page.  
  
3.  Click the **Advanced** button.  
  
4.  Modify the **File Alignment** property.  
  
 For information on how to set this compiler option programmatically, see <xref:VSLangProj80.CSharpProjectConfigurationProperties3.FileAlignment?qualifyHint=False>.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)