---
title: "IAxWinAmbientDispatch::get_BackColor"
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
  - "IAxWinAmbientDispatch.get_BackColor"
  - "IAxWinAmbientDispatch::get_BackColor"
  - "get_BackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BackColor method"
ms.assetid: ef0747da-b123-439d-9aea-35dcd0cbd324
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_BackColor
The `BackColor` property specifies the ambient background color of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_BackColor )(  
   OLE_COLOR* pclrBackground   
);  
```  
  
#### Parameters  
 *pclrBackground*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **COLOR_BTNFACE** or **COLOR_WINDOW** as the default value of this property (depending on whether the parent of the host window is a dialog or not).  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)