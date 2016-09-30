---
title: "Compiler Error C3387"
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
  - "C3387"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3387"
ms.assetid: c54d9925-ed14-4976-b8db-e8d4dc84e536
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3387
'member' : __declspec(dllexport)/\__declspec(dllimport) cannot be applied to a member of a managed or WinRT type  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and [dllexport](../vs140/dllexport--dllimport.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifiers are not valid on members of a managed or Windows Runtime type.  
  
 The following sample generates C3387 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>