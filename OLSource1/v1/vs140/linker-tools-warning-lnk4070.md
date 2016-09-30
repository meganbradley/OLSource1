---
title: "Linker Tools Warning LNK4070"
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
  - "LNK4070"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4070"
ms.assetid: f95f179a-fff9-427e-bd51-466b3934517f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4070
/OUT:filename directive in .EXP differs from output filename 'filename'; ignoring directive  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> specified in the [NAME](../vs140/name--c-c---.md) or [LIBRARY](../vs140/library.md) statement when the .exp file was created differs from the output <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that was either assumed by default or specified with the [/OUT](../vs140/-out--output-file-name-.md) option.  
  
 You will see this warning if you change the name of an output file in the development environment and where the project's .def file was not updated. Manually update the .def file to resolve this warning.  
  
 A client program that uses the resulting DLL might encounter problems.