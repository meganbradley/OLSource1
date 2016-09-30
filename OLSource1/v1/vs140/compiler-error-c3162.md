---
title: "Compiler Error C3162"
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
  - "C3162"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3162"
ms.assetid: 0d4c4a24-1456-4191-b7d8-c38cb7b17c32
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3162
'type' : a reference type which has a destructor cannot be used as the type of static data member 'member'  
  
 The common language runtime cannot know when to run a user-defined destructor when the class also contains static member function.  
  
 A destructor will never be run unless the object is deleted explicitly.  
  
 For more information, see,  
  
-   [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)  
  
-   [Common 64-bit Migration Issues](../vs140/common-visual-c---64-bit-migration-issues.md)  
  
## Example  
 The following sample generates C3162.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>