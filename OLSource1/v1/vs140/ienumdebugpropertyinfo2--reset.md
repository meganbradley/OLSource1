---
title: "IEnumDebugPropertyInfo2::Reset"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IEnumDebugPropertyInfo2::Reset
helpviewer_keywords: 
  - IEnumDebugPropertyInfo2::Reset
ms.assetid: fa4201c1-4633-4596-93aa-bd415c4ed71a
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IEnumDebugPropertyInfo2::Reset
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
 After this method is called, the next call to the [IEnumDebugPropertyInfo2::Next](../vs140/ienumdebugpropertyinfo2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md)