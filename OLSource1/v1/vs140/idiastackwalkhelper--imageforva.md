---
title: "IDiaStackWalkHelper::imageForVA"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalkHelper::imageForVA method"
ms.assetid: 8d4edabf-3c01-4fef-8b61-4779f3371067
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::imageForVA
Returns the start of an executable's image in memory given a virtual address somewhere in the executable's memory space.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The virtual address that lies somewhere in the executable's space.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the starting virtual address of the executable's image.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)