---
title: "ConcRTEventGuid Constant"
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
  - "concrt/concurrency::ConcRTEventGuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConcRTEventGuid constant"
ms.assetid: 78e621f4-cd16-402f-b4e4-520d56ee3269
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ConcRTEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are not more specifically described by another category.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID ConcRTEventGuid = { 0x72B14A7D, 0x704C, 0x423e, { 0x92, 0xF8, 0x7E, 0x6D, 0x64, 0xBC, 0xB9, 0x2A } };  
```  
  
## Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)