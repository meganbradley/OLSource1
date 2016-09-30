---
title: "auto_handle::reset"
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
  - "auto_handle.reset"
  - "msclr::auto_handle::reset"
  - "auto_handle::reset"
  - "msclr.auto_handle.reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_handle::reset"
ms.assetid: 32dc3a83-80fd-45c9-8f79-8c4096c30f57
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_handle::reset
Destroy the current owned object and optionally take possession of a new object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 (Optional) The new object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **ClassA constructor: first**  
**Hello from first A!**  
**ClassA constructor: second**  
**ClassA destructor: first**  
**Hello from second A!**  
**ClassA destructor: second**  
**done**   
## Requirements  
 **Header file** \<msclr\auto_handle.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_handle Members](../vs140/auto_handle-members.md)   
 [auto_handle::release](../vs140/auto_handle--release.md)