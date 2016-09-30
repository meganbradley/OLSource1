---
title: "Compiler Error C3537"
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
  - "C3537"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3537"
ms.assetid: f537ebd1-4fb0-4e09-a453-4f38db2c6881
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3537
'type': you cannot cast to a type that contains 'auto'  
  
 You cannot cast a variable to the indicated type because the type contains the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword and the default [/Zc:auto](../vs140/-zc-auto--deduce-variable-type-.md) compiler option is in effect.  
  
## Example  
 The following code yields C3537 because the variables are cast to a type that contains the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)