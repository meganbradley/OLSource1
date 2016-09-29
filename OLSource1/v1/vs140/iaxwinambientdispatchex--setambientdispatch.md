---
title: "IAxWinAmbientDispatchEx::SetAmbientDispatch"
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
  - "SetAmbientDispatch"
  - "ATL.IAxWinAmbientDispatchEx.SetAmbientDispatch"
  - "IAxWinAmbientDispatchEx.SetAmbientDispatch"
  - "IAxWinAmbientDispatchEx::SetAmbientDispatch"
  - "ATL::IAxWinAmbientDispatchEx::SetAmbientDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAmbientDispatch method"
ms.assetid: 8d96810e-1150-4a0d-a810-c68c8daa9923
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatchEx::SetAmbientDispatch
This method is called to supplement the default ambient property interface with a user-defined interface.  
  
## Syntax  
  
```  
  
      virtual HRESULT STDMETHODCALLTYPE SetAmbientDispatch(  
   IDispatch* pDispatch  
) = 0;  
```  
  
#### Parameters  
 *pDispatch*  
 Pointer to the new interface.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 When `SetAmbientDispatch` is called with a pointer to a new interface, this new interface will be used to invoke any properties or methods asked for by the hosted control — if those properties are not already provided by [IAxWinAmbientDispatch](../vs140/iaxwinambientdispatch-interface.md).  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatchEx Interface](../vs140/iaxwinambientdispatchex-interface.md)