---
title: "LockEventGuid Constant"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrt/concurrency::LockEventGuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockEventGuid constant"
ms.assetid: f771e726-9ac6-4732-a96a-fccbe32001dd
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LockEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to locks.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID LockEventGuid = { 0x79A60DC6, 0x5FC8, 0x4952, { 0xA4, 0x1C, 0x11, 0x63, 0xAE, 0xEC, 0x5E, 0xB8 } };  
```  
  
## Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [critical_section Class](../vs140/critical_section-class.md)   
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)