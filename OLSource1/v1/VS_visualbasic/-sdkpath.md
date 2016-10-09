---
title: "-sdkpath"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/sdkpath"
f1_keywords: 
  - "sdkpath"
  - "/sdkpath"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-sdkpath compiler option [Visual Basic]"
  - "/sdkpath compiler option [Visual Basic]"
  - "sdkpath compiler option [Visual Basic]"
ms.assetid: fec8a3f1-b791-4a37-8af7-344859f8212d
caps.latest.revision: 15
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
# -sdkpath
Specifies the location of Mscorlib.dll and Microsoft.VisualBasic.dll.  
  
## Syntax  
  
```  
/sdkpath:path  
```  
  
## Arguments  
 `path`  
 The directory containing the versions of Mscorlib.dll and Microsoft.VisualBasic.dll to use for compilation. This path is not verified until it is loaded. Enclose the directory name in quotation marks (" ") if it contains a space.  
  
## Remarks  
 This option tells the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler to load the Mscorlib.dll and Microsoft.VisualBasic.dll files from a non-default location. The `/sdkpath` option was designed to be used with [/netcf](../VS_visualbasic/-netcf.md). The [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)] uses different versions of these support libraries to avoid the use of types and language features not found on the devices.  
  
> [!NOTE]
>  The `/sdkpath` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line. The `/sdkpath` option is set when a [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] device project is loaded.  
  
 You can specify that the compiler should compile without a reference to the Visual Basic Runtime Library by using the `/vbruntime` compiler option. For more information, see [/vbruntime](../VS_visualbasic/-vbruntime.md).  
  
## Example  
 The following code compiles `Myfile.vb` with the [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)], using the versions of Mscorlib.dll and Microsoft.VisualBasic.dll found in the default installation directory of the [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)] on the C drive. Typically, you would use the most recent version of the [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)].  
  
```  
vbc /netcf /sdkpath:"c:\Program Files\Microsoft Visual Studio .NET 2003\CompactFrameworkSDK\v1.0.5000\Windows CE " myfile.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../VS_visualbasic/sample-compilation-command-lines--visual-basic-.md)   
 [/netcf](../VS_visualbasic/-netcf.md)   
 [/vbruntime](../VS_visualbasic/-vbruntime.md)