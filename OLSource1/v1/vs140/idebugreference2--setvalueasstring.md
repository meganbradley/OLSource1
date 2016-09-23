---
title: "IDebugReference2::SetValueAsString"
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
  - IDebugReference2::SetValueAsString
helpviewer_keywords: 
  - IDebugReference2::SetValueAsString
ms.assetid: 9a508ced-fd54-44f5-bb42-ec15c80384d7
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugReference2::SetValueAsString
Sets the value of a reference from a string. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT SetValueAsString (   
   LPCOLESTR pszValue,  
   DWORD     dwRadix,  
   DWORD     dwTimeout  
);  
```  
  
```c#  
int SetValueAsString (   
   string pszValue,  
   uint   dwRadix,  
   uint   dwTimeout  
);  
```  
  
#### Parameters  
 `pszValue`  
 [in] The value as a string.  
  
 `dwRadix`  
 [in] The radix to be used in formatting any numerical information.  
  
 `dwTimeout`  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)