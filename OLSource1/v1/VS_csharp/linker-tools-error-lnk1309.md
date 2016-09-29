---
title: "Linker Tools Error LNK1309"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "LNK1309"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1309"
ms.assetid: 10146071-883f-4849-97d1-c7468f90efbb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1309
type1 module detected; invalid with switch /CLRIMAGETYPE:type2  
  
 A CLR image type was requested with **/CLRIMAGETYPE** but the linker could not produce an image of that type because one or more modules were incompatible with that type.  
  
 For example, you will see LNK1309 if you specify **/CLRIMAGETYPE:safe** and you pass a module built with **/clr:pure**.  
  
 You will also see LNK1309 if you attempt to build a partially trusted CLR pure application using ptrustu[d].lib. For information on how to create a partially trusted application, see [How to: Create a Partially Trusted Application by Removing Dependency on msvcm90.dll](../VS_csharp/how-to--create-a-partially-trusted-application-by-removing-dependency-on-the-crt-library-dll.md).  
  
 For more information, see [/clr (Common Language Runtime Compilation)](../VS_csharp/-clr--common-language-runtime-compilation-.md) and [/CLRIMAGETYPE (Specify Type of CLR Image)](../VS_csharp/-clrimagetype--specify-type-of-clr-image-.md).