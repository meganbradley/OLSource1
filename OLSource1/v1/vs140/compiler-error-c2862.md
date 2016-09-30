---
title: "Compiler Error C2862"
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
  - "C2862"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2862"
ms.assetid: c04d8499-b799-48a1-9fb4-7902a0b0ac8e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2862
'interface' : an interface can only have public members  
  
 Protected and private members may be accessed only from other member functions. Such members are no use in an interface, since it may not provide implementations for any of its members.  
  
 The following sample will generate C2862:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>