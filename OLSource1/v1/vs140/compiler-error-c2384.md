---
title: "Compiler Error C2384"
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
  - "C2384"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2384"
ms.assetid: 8145f7ad-31b1-406d-ac43-0d557feab635
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2384
'member' : cannot apply __declspec(thread) to a member of a managed or WinRT class  
  
 The [thread](../vs140/thread.md) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier cannot be used on a member of a managed or Windows Runtime class.  
  
 Static thread local storage in managed code can only be used for statically loaded DLLs—the DLL must be statically loaded when the process starts. Windows Runtime does not support thread local storage.  
  
 The following line generates C2384 and shows how to fix it in C++/CLI code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>