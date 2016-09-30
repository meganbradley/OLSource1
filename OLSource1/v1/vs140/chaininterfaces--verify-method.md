---
title: "ChainInterfaces::Verify Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "implements/Microsoft::WRL::ChainInterfaces::Verify"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Verify method"
ms.assetid: c591e130-8686-4130-ba69-1aaedc250038
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ChainInterfaces::Verify Method
Verifies that each interface defined by template parameters <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> inherits from IUnknown and/or IInspectable, and that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the verification operation fails, a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> emits an error message describing the failure.  
  
## Remarks  
 Template parameters <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are required, and parameters <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are optional.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ChainInterfaces Structure](../vs140/chaininterfaces-structure.md)