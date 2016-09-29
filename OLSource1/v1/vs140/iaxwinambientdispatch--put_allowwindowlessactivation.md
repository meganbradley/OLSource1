---
title: "IAxWinAmbientDispatch::put_AllowWindowlessActivation"
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
  - "put_AllowWindowlessActivation"
  - "IAxWinAmbientDispatch.put_AllowWindowlessActivation"
  - "IAxWinAmbientDispatch::put_AllowWindowlessActivation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_AllowWindowlessActivation method"
ms.assetid: 849a7d11-8476-44df-a568-fb4ee106ee19
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_AllowWindowlessActivation
The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_AllowWindowlessActivation )(  
   VARIANT_BOOL bAllowWindowless   
);  
```  
  
#### Parameters  
 *bAllowWindowless*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses `VARIANT_TRUE` as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)