---
title: "IAxWinAmbientDispatch::put_BackColor"
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
  - "IAxWinAmbientDispatch.put_BackColor"
  - "IAxWinAmbientDispatch::put_BackColor"
  - "put_BackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_BackColor method"
ms.assetid: 6cb79016-ac68-4144-89e4-c5f59320d766
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_BackColor
The `BackColor` property specifies the ambient background color of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_BackColor )(  
   OLE_COLOR clrBackground   
);  
```  
  
#### Parameters  
 *clrBackground*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **COLOR_BTNFACE** or **COLOR_WINDOW** as the default value of this property (depending on whether the parent of the host window is a dialog or not).  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)