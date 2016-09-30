---
title: "Compiler Warning (level 1) C4124"
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
  - "C4124"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4124"
ms.assetid: c08c3a65-9584-47a1-a147-44f00c4b230e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4124
__fastcall with stack checking is inefficient  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword was used with stack checking enabled.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> convention generates faster code, but stack checking causes slower code. When using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, turn off stack checking with the **check_stack** pragma or /Gs.  
  
 This warning is issued only for the first function declared under these conditions.