---
title: "BoolStruct Structure"
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
  - "internal/Microsoft::WRL::Details::BoolStruct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BoolStruct structure"
ms.assetid: 666eae78-e81d-4fb7-a9e4-1ba617d6d4cd
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BoolStruct Structure
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
struct BoolStruct;  
```  
  
## Remarks  
 The BoolStruct structure defines whether a ComPtr is managing the object lifetime of an interface. BoolStruct is used internally by the [BoolType()](../vs140/comptr--operator-microsoft--wrl--details--booltype-operator.md) operator.  
  
## Members  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[BoolStruct::Member Data Member](../vs140/boolstruct--member-data-member.md)|Specifies that a [ComPtr](../vs140/comptr-class.md) is, or is not, managing the object lifetime of an interface.|  
  
## Inheritance Hierarchy  
 `BoolStruct`  
  
## Requirements  
 **Header:** internal.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)   
 [ComPtr::operator Microsoft::WRL::Details::BoolType Operator](../vs140/comptr--operator-microsoft--wrl--details--booltype-operator.md)