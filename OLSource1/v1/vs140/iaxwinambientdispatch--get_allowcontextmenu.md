---
title: "IAxWinAmbientDispatch::get_AllowContextMenu"
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
  - "IAxWinAmbientDispatch::get_AllowContextMenu"
  - "IAxWinAmbientDispatch.get_AllowContextMenu"
  - "get_AllowContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_AllowContextMenu method"
ms.assetid: 8199a09b-d5c8-4d21-885b-6f7ba2676fab
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_AllowContextMenu
The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_AllowContextMenu )(  
   VARIANT_BOOL* pbAllowContextMenu   
);  
```  
  
#### Parameters  
 *pbAllowContextMenu*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses `VARIANT_TRUE` as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx)