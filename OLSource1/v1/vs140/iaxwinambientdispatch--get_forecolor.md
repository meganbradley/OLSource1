---
title: "IAxWinAmbientDispatch::get_ForeColor"
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
  - "IAxWinAmbientDispatch.get_ForeColor"
  - "get_ForeColor"
  - "IAxWinAmbientDispatch::get_ForeColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_ForeColor method"
ms.assetid: 556a6f91-c42f-47b7-a483-69ad5ff0301b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_ForeColor
The `ForeColor` property specifies the ambient foreground color of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_ForeColor )(  
   OLE_COLOR* pclrForeground   
);  
```  
  
#### Parameters  
 *pclrForeground*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses the system window text color as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)