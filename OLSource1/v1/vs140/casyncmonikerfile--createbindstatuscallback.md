---
title: "CAsyncMonikerFile::CreateBindStatusCallback"
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
  - "CAsyncMonikerFile::CreateBindStatusCallback"
  - "CAsyncMonikerFile.CreateBindStatusCallback"
  - "CreateBindStatusCallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregation [C++], CAsyncMonikerFile class"
  - "CreateBindStatusCallback method"
ms.assetid: 134f92ce-b130-4931-9f80-a7cb130ef397
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::CreateBindStatusCallback
Creates a COM object that implements `IBindStatusCallback`.  
  
## Syntax  
  
```  
  
      virtual IUnknown* CreateBindStatusCallback(  
   IUnknown* pUnkControlling   
);  
```  
  
#### Parameters  
 `pUnkControlling`  
 A pointer to the controlling unknown (the outer **IUnknown**) or **NULL** if aggregation is not being used.  
  
## Return Value  
 If `pUnkControlling` is not **NULL**, the function returns a pointer to the inner **IUnknown** on a new COM object supporting `IBindStatusCallback`. If `pUnkControlling` is **NULL**, the function returns a pointer to an **IUnknown** on a new COM object supporting `IBindStatusCallback`.  
  
## Remarks  
 `CAsyncMonikerFile` requires a COM object that implements `IBindStatusCallback`. MFC implements such an object, and it is aggregatable. You can override `CreateBindStatusCallback` to return your own COM object. Your COM object can aggregate MFC's implementation by calling `CreateBindStatusCallback` with the controlling unknown of your COM object. COM objects implemented using the `CCmdTarget` COM support can retrieve the controlling unknown using **CCmdTarget::GetControllingUnknown**.  
  
 Alternately, your COM object can delegate to MFC's implementation by calling **CreateBindStatusCallback( NULL )**.  
  
 [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile--open.md) calls `CreateBindStatusCallback`.  
  
 For more information about asynchronous monikers and asynchronous binding, see the [IBindStatusCallback](http://msdn.microsoft.com/library/ie/ms775060) interface and [How Asynchronous Binding and Storage Work](http://msdn.microsoft.com/library/windows/desktop/aa379152). For a discussion of aggregation, see [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558). All three topics are in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)