---
title: "IDebugField::GetTypeInfo"
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
  - IDebugField::GetTypeInfo
helpviewer_keywords: 
  - IDebugField::GetTypeInfo method
ms.assetid: bb5acfa3-04c3-4088-be84-9ff8926cd16f
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugField::GetTypeInfo
This method gets type-independent information about the symbol or type.  
  
## Syntax  
  
```cpp#  
HRESULT GetTypeInfo(   
   TYPE_INFO* pTypeInfo  
);  
```  
  
```c#  
int GetTypeInfo(  
   TYPE_INFO[] pTypeInfo  
);  
```  
  
#### Parameters  
 `pTypeInfo`  
 [out] Returns type information in the supplied [TYPE_INFO](../vs140/type_info.md) structure.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Type-independent information would include, for example, the AppDomain, the module, and the class that contains the symbol.  
  
## See Also  
 [GetType](../vs140/idebugfield--gettype.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [TYPE_INFO](../vs140/type_info.md)