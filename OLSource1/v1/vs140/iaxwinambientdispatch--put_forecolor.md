---
title: "IAxWinAmbientDispatch::put_ForeColor"
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
  - "IAxWinAmbientDispatch::put_ForeColor"
  - "put_ForeColor"
  - "IAxWinAmbientDispatch.put_ForeColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_ForeColor method"
ms.assetid: b83372a7-8320-4cd7-ae63-71515140b4c0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_ForeColor
The `ForeColor` property specifies the ambient foreground color of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_ForeColor )(  
   OLE_COLOR clrForeground   
);  
```  
  
#### Parameters  
 *clrForeground*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses the system window text color as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)