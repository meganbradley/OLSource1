---
title: "IEnumDebugCustomAttributes::Reset"
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
  - "IEnumCustomAttributes::Reset"
helpviewer_keywords: 
  - "IEnumDebugCustomAttributes::Reset"
ms.assetid: e0db6518-5a71-4adb-a407-4d2ac7a3e369
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugCustomAttributes::Reset
Resets the enumeration sequence to the beginning.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(void);  
```  
  
```c#  
int Reset();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugCustomAttributes::Next](../vs140/ienumdebugcustomattributes--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md)   
 [IEnumDebugCustomAttributes::Next](../vs140/ienumdebugcustomattributes--next.md)