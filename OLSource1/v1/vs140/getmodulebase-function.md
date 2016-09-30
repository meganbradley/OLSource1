---
title: "GetModuleBase Function"
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
  - "implements/Microsoft::WRL::GetModuleBase"
dev_langs: 
  - "C++"
ms.assetid: 123d3b14-2eaf-4e02-8dcd-b6567917c6a6
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetModuleBase Function
Retrieves a [ModuleBase](../vs140/modulebase-class.md) pointer that allows for incrementing and decrementing the reference count of a [RuntimeClass](../vs140/runtimeclass-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 This function is used internally to increment and decrement object reference counts.  
  
 You can use this function to control reference counts by calling [ModuleBase::IncrementObjectCount](../vs140/modulebase--incrementobjectcount-method.md) and [ModuleBase::DecrementObjectCount](../vs140/modulebase--decrementobjectcount-method.md).  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Microsoft::WRL Namespace](../vs140/microsoft--wrl-namespace.md)