---
title: "Compiler Error C2030"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
H1: "Compiler Error C2030"
f1_keywords: 
  - "C2030"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2030"
ms.assetid: 5806cead-64df-4eff-92de-52c9a3f5ee62
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2030
a destructor with 'protected private' accessibility cannot be a member of a class declared 'sealed'  
  
 A Windows Runtime class declared as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> cannot have a protected private destructor. Only public virtual and private non-virtual destructors are allowed on sealed types. For more information, see [Ref classes and structs (C++/CX)](assetId:///3d736b82-0bf0-48cf-bac1-cc9d110b70d1).  
  
 To fix this error, change the accessibility of the destructor.