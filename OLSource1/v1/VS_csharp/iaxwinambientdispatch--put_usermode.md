---
title: "IAxWinAmbientDispatch::put_UserMode"
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
  - "IAxWinAmbientDispatch.put_UserMode"
  - "put_UserMode"
  - "IAxWinAmbientDispatch::put_UserMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_UserMode method"
ms.assetid: 4fcc2c96-9252-430e-8f10-eb8581ce6283
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_UserMode
The **UserMode** property specifies the ambient user mode of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_UserMode )(  
   VARIANT_BOOL bUserMode   
);  
```  
  
#### Parameters  
 `bUserMode`  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses `VARIANT_TRUE` as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)