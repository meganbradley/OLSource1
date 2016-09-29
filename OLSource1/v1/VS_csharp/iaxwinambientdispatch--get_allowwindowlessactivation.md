---
title: "IAxWinAmbientDispatch::get_AllowWindowlessActivation"
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
  - "get_AllowWindowlessActivation"
  - "IAxWinAmbientDispatch::get_AllowWindowlessActivation"
  - "IAxWinAmbientDispatch.get_AllowWindowlessActivation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_AllowWindowlessActivation method"
ms.assetid: 7fd0a047-b4f3-4973-9583-467540c0332a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_AllowWindowlessActivation
The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_AllowWindowlessActivation )(  
   VARIANT_BOOL* pbAllowWindowless   
);  
```  
  
#### Parameters  
 *pbAllowWindowless*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses `VARIANT_TRUE` as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)   
 [IOleInPlaceSiteWindowless::CanWindowlessActivate](http://msdn.microsoft.com/library/windows/desktop/ms688584)