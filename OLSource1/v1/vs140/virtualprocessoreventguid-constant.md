---
title: "VirtualProcessorEventGuid Constant"
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
  - "concrt/concurrency::VirtualProcessorEventGuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VirtualProcessorEventGuid constant"
ms.assetid: ab73a4da-a44d-43de-bb34-193062afc334
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VirtualProcessorEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to virtual processors.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID VirtualProcessorEventGuid = { 0x2f27805f, 0x1676, 0x4ecc, { 0x96, 0xfa, 0x7e, 0xb0, 0x9d, 0x44, 0x30, 0x2f } };  
```  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)