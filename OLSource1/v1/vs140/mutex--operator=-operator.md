---
title: "Mutex::operator= Operator"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Mutex::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 9b0ee206-a930-4fea-8dc0-1f79839e9d13
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mutex::operator= Operator
Assigns (moves) the specified Mutex object to the current Mutex object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An rvalue-reference to a Mutex object.  
  
## Return Value  
 A reference to the current Mutex object.  
  
## Remarks  
 For more information, see the **Move Semantics** section of [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Mutex Class](../vs140/mutex-class.md)