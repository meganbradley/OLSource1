---
title: "Compiler Error C2778"
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
  - "C2778"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2778"
ms.assetid: b24cb732-2914-42cc-8928-e2d87b393428
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2778
improperly formed GUID in __declspec(uuid())  
  
 An incorrect GUID is supplied to the [uuid](../vs140/uuid--c---.md) extended attribute.  
  
 The GUID must be a string of hexadecimal numbers with the following format:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> extended attribute accepts strings recognized by [CLSIDFromString](http://msdn.microsoft.com/library/windows/desktop/ms680589), with or without brace delimiters.  
  
 The following sample generates C2778:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>