---
title: "Linker Tools Warning LNK4022"
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
  - "LNK4022"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4022"
ms.assetid: 890f487e-db98-45dd-a226-c7ccead82b1e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4022
cannot find unique match for symbol 'symbol'  
  
 LINK or LIB found multiple matches for the given undecorated symbol and it could not resolve the ambiguity. No output file (.exe, .dll, .exp, or .lib) is produced. This warning is followed by one warning [LNK4002](../VS_csharp/linker-tools-warning-lnk4002.md) for each duplicate symbol and is finally followed by fatal error [LNK1152](../VS_csharp/linker-tools-error-lnk1152.md).  
  
 To prevent this warning, specify the symbol in its decorated form. Run [DUMPBIN](../VS_csharp/dumpbin-options.md) on the object to see decorated names.