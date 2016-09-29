---
title: "HandleT::Close Method"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleT::Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
ms.assetid: 1b9d597c-abcf-4028-a068-0344560009f6
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HandleT::Close Method
Closes the current HandleT object.  
  
## Syntax  
  
```  
void Close();  
```  
  
## Remarks  
 The handle that underlies the current HandleT is closed, and the HandleT is set to the invalid state.  
  
 If the handle doesn't close properly, an exception is raised in the calling thread.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HandleT Class](../vs140/handlet-class.md)