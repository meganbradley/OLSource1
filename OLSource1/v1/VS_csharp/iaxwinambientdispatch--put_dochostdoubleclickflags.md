---
title: "IAxWinAmbientDispatch::put_DocHostDoubleClickFlags"
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
  - "IAxWinAmbientDispatch::put_DocHostDoubleClickFlags"
  - "put_DocHostDoubleClickFlags"
  - "IAxWinAmbientDispatch.put_DocHostDoubleClickFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_DocHostDoubleClickFlags method"
ms.assetid: f6246053-45c9-47f2-b56c-dadee749fb5f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_DocHostDoubleClickFlags
The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_DocHostDoubleClickFlags )(  
   DWORD dwDocHostDoubleClickFlags   
);  
```  
  
#### Parameters  
 *dwDocHostDoubleClickFlags*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **DOCHOSTUIDBLCLK_DEFAULT** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx)