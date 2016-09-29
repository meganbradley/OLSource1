---
title: "IAxWinAmbientDispatch::put_AllowContextMenu"
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
  - "IAxWinAmbientDispatch.put_AllowContextMenu"
  - "put_AllowContextMenu"
  - "IAxWinAmbientDispatch::put_AllowContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_AllowContextMenu method"
ms.assetid: acb99154-932b-45fd-aa08-dd2837ecaafb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_AllowContextMenu
The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_AllowContextMenu )(  
   VARIANT_BOOL bAllowContextMenu   
);  
```  
  
#### Parameters  
 *bAllowContextMenu*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses `VARIANT_TRUE` as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx)