---
title: "IAxWinAmbientDispatch::get_DisplayAsDefault"
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
  - "IAxWinAmbientDispatch.get_DisplayAsDefault"
  - "IAxWinAmbientDispatch::get_DisplayAsDefault"
  - "get_DisplayAsDefault"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_DisplayAsDefault method"
ms.assetid: 4c418592-8ca5-421a-bb90-45380634a18f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_DisplayAsDefault
**DisplayAsDefault** is an ambient property that allows a control to find out if it is the default control.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_DisplayAsDefault )(  
   VARIANT_BOOL* pbDisplayAsDefault   
);  
```  
  
#### Parameters  
 *pbDisplayAsDefault*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)