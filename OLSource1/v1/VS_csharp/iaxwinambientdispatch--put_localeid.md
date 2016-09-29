---
title: "IAxWinAmbientDispatch::put_LocaleID"
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
  - "IAxWinAmbientDispatch.put_LocaleID"
  - "IAxWinAmbientDispatch::put_LocaleID"
  - "put_LocaleID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_LocaleID method"
ms.assetid: a99e8d2c-c5e0-47f8-a761-98641f8c4845
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_LocaleID
The **LocaleID** property specifies the ambient locale ID of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_LocaleID )(  
   LCID lcidLocaleID   
);  
```  
  
#### Parameters  
 *lcidLocaleID*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses the user's default locale as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)