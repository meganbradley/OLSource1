---
title: "Compiler Error C2834"
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
  - "C2834"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2834"
ms.assetid: 28f9f6eb-ab2a-4e64-aaaa-9d14f955de41
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2834
'operator operator' must be globally qualified  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operators are tied to the class where they reside. Scope resolution cannot be used to select a version of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> from a different class. To implement multiple forms of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator, create a version of the operator with extra formal parameters.