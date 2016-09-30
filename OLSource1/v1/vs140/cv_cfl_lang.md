---
title: "CV_CFL_LANG"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CV_CFL_LANG enumeration"
ms.assetid: 4e8e0613-ad02-4de9-9f46-e4753c5b0251
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CV_CFL_LANG
Specifies the source code language of the application or linked module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 CV_CFL_C  
 Application language is C.  
  
 CV_CFL_CXX  
 Application language is C++.  
  
 CV_CFL_FORTRAN  
 Application language is FORTRAN.  
  
 CV_CFL_MASM  
 Application language is Microsoft Macro Assembler.  
  
 CV_CFL_PASCAL  
 Application language is Pascal.  
  
 CV_CFL_BASIC  
 Application language is BASIC.  
  
 CV_CFL_COBOL  
 Application language is COBOL.  
  
 CV_CFL_LINK  
 Application is a linker-generated module.  
  
 CV_CFL_CVTRES  
 Application is a resource module converted with CVTRES tool.  
  
 CV_CFL_CVTPGD  
 Application is a POGO optimized module generated with CVTPGD tool.  
  
 CV_CFL_CSHARP  
 Application language is C#.  
  
 CV_CFL_VB  
 Application language is Visual Basic.  
  
 CV_CFL_ILASM  
 Application language is intermediate language assembly (that is, Common Language Runtime (CLR) assembly).  
  
 CV_CFL_JAVA  
 Application language is Java.  
  
 CV_CFL_JSCRIPT  
 Application language is Jscript.  
  
 CV_CFL_MSIL  
 Application language is an unknown Microsoft Intermediate Language (MSIL), possibly a result of using the [/LTCG (Link-time Code Generation)](../vs140/-ltcg--link-time-code-generation-.md) switch.  
  
 CV_CFL_HLSL  
 Application language is High Level Shader Language.  
  
## Remarks  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_language](../vs140/idiasymbol--get_language.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaSymbol::get_language](../vs140/idiasymbol--get_language.md)