---
title: "IDebugProcessSecurity::GetUserName"
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
  - "IDebugProcessSecurity::GetUserName"
ms.assetid: c73c60ac-da6e-45ae-8f04-95353a24ca3e
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcessSecurity::GetUserName
Gets the user name from the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetUserName(  
    BSTR *pbstrUserName  
);  
```  
  
```c#  
int GetUserName (  
    string pbstrUserName  
);  
```  
  
#### Parameters  
 `pbstrUserName`  
 [out] A string containing the user name.  
  
## Return Value  
 If the method succeeds, it returns `S_OK`. Otherwise it returns an error code.  
  
## Remarks  
 `GetUserName` returns the user name that is displayed in the **User Name** column of the **Attach to Process** dialog box. To view the **Attach to Process** dialog box, click **Attach to Process** on the **Tools** menu in the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] integrated development environment (IDE).  
  
## See Also  
 [IDebugProcessSecurity](../VS_csharp/idebugprocesssecurity.md)