---
title: "Fatal Error C1902"
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
  - "C1902"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1902"
ms.assetid: 2dc066cc-fcb1-4725-8bcb-9f44dd0905b7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1902
program database manager mismatch; please check your installation  
  
 A program database file (.pdb) was created using a newer version of mspdb*XX*.dll than the one the compiler found on your system. This error usually indicates that mspdbsrv.exe or mspdbcore.dll are missing or have different versions than mspdb*XX*.dll. (The *XX* placeholder in the mspdb*XX*.dll file name changes with each product release. For example, in [!INCLUDE[vsprvslong](../VS_csharp/includes/vsprvslong_md.md)] the file name is mspdb80.dll.)  
  
 Ensure matching versions of mspdbsrv.exe, mspdbcore.dll, and mspdb*XX*.dll are installed on your system. Ensure that mismatched versions have not been copied to the directory that contains the compiler and link tools for your target platform. For example, you might have copied the files so you could invoke the compiler or link tool from the command prompt without setting the **PATH** environment variable accordingly.