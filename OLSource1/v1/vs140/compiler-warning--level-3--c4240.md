---
title: "Compiler Warning (level 3) C4240"
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
  - "C4240"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4240"
ms.assetid: a2657cdb-18e1-493f-882b-4e10c0bca71d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4240
nonstandard extension used : access to 'classname' now defined to be 'access specifier', previously it was defined to be 'access specifier'  
  
 Under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)), you cannot change the access to a nested class. Under the default Microsoft extensions (/Ze), you can, with this warning.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>