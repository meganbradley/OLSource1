---
title: "IAxWinAmbientDispatch::get_DocHostDoubleClickFlags"
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
  - "IAxWinAmbientDispatch.get_DocHostDoubleClickFlags"
  - "get_DocHostDoubleClickFlags"
  - "IAxWinAmbientDispatch::get_DocHostDoubleClickFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_DocHostDoubleClickFlags method"
ms.assetid: d7e9a4ac-dec0-4868-8234-f9dbd0874e80
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_DocHostDoubleClickFlags
The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_DocHostDoubleClickFlags )(  
   DWORD* pdwDocHostDoubleClickFlags   
);  
```  
  
#### Parameters  
 *pdwDocHostDoubleClickFlags*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **DOCHOSTUIDBLCLK_DEFAULT** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx)