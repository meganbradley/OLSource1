---
title: "IEnumDebugThreads2::Reset"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugThreads2::Reset"
helpviewer_keywords: 
  - "IEnumDebugThreads2::Reset"
ms.assetid: 88980d9a-c4d6-4de4-a9ab-fb56fa71394a
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugThreads2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(  
   void  
);  
```  
  
```c#  
int Reset();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugThreads2::Next](../vs140/ienumdebugthreads2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugThreads2](../vs140/ienumdebugthreads2.md)