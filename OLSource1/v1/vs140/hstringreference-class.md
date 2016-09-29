---
title: "HStringReference Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HStringReference"
dev_langs: 
  - "C++"
ms.assetid: 9bf823b1-17eb-4ac4-8c5d-27d27c7a4150
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HStringReference Class
Represents an HSTRING that is created from an existing string.  
  
## Syntax  
  
```cpp  
class HStringReference;  
```  
  
## Remarks  
 The lifetime of the backing buffer in the new HSTRING is not managed by the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. The caller allocates a source string on the stack frame to avoid a heap allocation and to eliminate the risk of a memory leak. Also, the caller must ensure that source string remains unchanged during the lifetime of the attached HSTRING. For more information, see [WindowsCreateStringReference function](assetId:///0361bb7e-da49-4289-a93e-de7aab8712ac).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[HStringReference::HStringReference Constructor](../vs140/hstringreference--hstringreference-constructor.md)|Initializes a new instance of the HStringReference class.|  
  
### Members  
  
|Member|Description|  
|------------|-----------------|  
|[HStringReference::CopyTo Method](../vs140/hstringreference--copyto-method.md)|Copies the current HStringReference object to an HSTRING object.|  
|[HStringReference::Get Method](../vs140/hstringreference--get-method.md)|Retrieves the value of the underlying HSTRING handle.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator=](../vs140/hstringreference--operator=-operator.md)|Moves the value of another HStringReference object to the current HStringReference object.|  
|[operator==](../vs140/hstringreference--operator==-operator.md)|Indicates whether the two parameters are equal.|  
|[operator!=](../vs140/hstringreference--operator!=-operator.md)|Indicates whether the two parameters are not equal.|  
  
## Inheritance Hierarchy  
 `HStringReference`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)