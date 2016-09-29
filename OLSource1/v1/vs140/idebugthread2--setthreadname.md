---
title: "IDebugThread2::SetThreadName"
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
  - "IDebugThread2::SetThreadName"
helpviewer_keywords: 
  - "IDebugThread2::SetThreadName"
ms.assetid: fa934121-3f58-44dc-9c30-d3f752e44c8b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2::SetThreadName
Sets the name of the thread.  
  
## Syntax  
  
```cpp#  
HRESULT SetThreadName (   
   LPCOLESTR pszName  
);  
```  
  
```c#  
int SetThreadName (   
   string pszName  
);  
```  
  
#### Parameters  
 `pszName`  
 [in] The name of the thread.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To get the thread name, call the [IDebugThread2::GetName](../vs140/idebugthread2--getname.md) method.  
  
## See Also  
 [IDebugThread2](../vs140/idebugthread2.md)   
 [IDebugThread2::GetName](../vs140/idebugthread2--getname.md)