---
title: "IAxWinAmbientDispatch::get_DocHostFlags"
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
  - "IAxWinAmbientDispatch.get_DocHostFlags"
  - "get_DocHostFlags"
  - "IAxWinAmbientDispatch::get_DocHostFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_DocHostFlags method"
ms.assetid: 46af1d8e-89e3-4690-a476-ea1e82dc1afb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_DocHostFlags
The **DocHostFlags** property specifies the user interface capabilities of the host object.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_DocHostFlags )(  
   DWORD* pdwDocHostFlags   
);  
```  
  
#### Parameters  
 *pdwDocHostFlags*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **DOCHOSTUIFLAG_NO3DBORDER** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx)