---
title: "IDebugProcessSecurity::QueryCanSafelyAttach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugProcessSecurity::QueryCanSafelyAttach"
ms.assetid: 63ec1ae8-27da-4574-aa15-1c986fe9fe58
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcessSecurity::QueryCanSafelyAttach
This method allows the port supplier to display a warning before the user attaches to an unsafe process.  
  
## Syntax  
  
```cpp#  
HRESULT QueryCanSafelyAttach();  
```  
  
```c#  
int QueryCanSafelyAttach();  
```  
  
## Return Value  
 The return values are as follows:  
  
-   `S_OK`: Attaching to process is safe and no warning dialog box is shown.  
  
-   `S_FALSE`: Attaching could be a security problem and a dialog box with a warning is shown.  
  
-   `FAILURE`: Attaching to process fails.  
  
## See Also  
 [IDebugProcessSecurity](../vs140/idebugprocesssecurity.md)