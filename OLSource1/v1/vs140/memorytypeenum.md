---
title: "MemoryTypeEnum"
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
  - "MemoryTypeEnum enumeration"
ms.assetid: 8778c047-edeb-4495-8f9f-3f8bbb297099
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MemoryTypeEnum
Specifies the type of memory to access.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Accesses only code memory.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Accesses data or stack memory.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Accesses only stack memory.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Accesses any kind of memory.  
  
## Remarks  
 The values in this enumeration are passed to the [IDiaStackWalkHelper::readMemory](../vs140/idiastackwalkhelper--readmemory.md) method to limit access to different types of memory.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaStackWalkHelper::readMemory Method](../vs140/idiastackwalkhelper--readmemory.md)