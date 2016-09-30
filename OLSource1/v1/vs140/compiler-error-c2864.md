---
title: "Compiler Error C2864"
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
  - "C2864"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2864"
ms.assetid: d0ca2ad9-90a6-4aef-8511-98a3b414c102
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2864
'variable' : a static data member with an in-class initializer must have non-volatile const integral type  
  
 To initialize a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data member that is defined as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, non-<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or not an integral type, use a member-definition statement. They cannot be initialized in a declaration.  
  
 This sample generates C2864:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This sample shows how to fix C2864:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>