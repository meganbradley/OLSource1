---
title: "IAxWinAmbientDispatch::get_ShowGrabHandles"
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
  - "get_ShowGrabHandles"
  - "IAxWinAmbientDispatch.get_ShowGrabHandles"
  - "IAxWinAmbientDispatch::get_ShowGrabHandles"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_ShowGrabHandles method"
ms.assetid: fac49ce4-9173-4cf4-98b2-742d89f02b6b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_ShowGrabHandles
The **ShowGrabHandles** ambient property allows the control to find out if it should draw itself with grab handles.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_ShowGrabHandles )(  
   VARIANT_BOOL* pbShowGrabHandles   
);  
```  
  
#### Parameters  
 *pbShowGrabHandles*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation always returns **VARIANT_FALSE** as the value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)