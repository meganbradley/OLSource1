---
title: "Linker Tools Error LNK2013"
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
  - "LNK2013"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK2013"
ms.assetid: 21408e2d-3f56-4d1f-a031-00df70785ed4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK2013
fixup type fixup overflow. Target 'symbol name' is out of range  
  
 The linker cannot fit the necessary address or offset into the given instruction because the target symbol is too far away from the instruction's location.  
  
 You can resolve this problem by creating multiple images or by using the [/ORDER](../vs140/-order--put-functions-in-order-.md) option so the instruction and target are closer together.  
  
 When the symbol name is a user-defined symbol (and not a compiler-generated symbol), you can also try the following actions to resolve the error:  
  
-   Change the static function to be non-static.  
  
-   Rename the code section containing the static function to be the same as the caller.  
  
 Use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, to see if a function is static.