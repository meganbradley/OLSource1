---
title: "IAxWinAmbientDispatch::put_DocHostFlags"
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
  - "put_DocHostFlags"
  - "IAxWinAmbientDispatch::put_DocHostFlags"
  - "IAxWinAmbientDispatch.put_DocHostFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_DocHostFlags method"
ms.assetid: 4cdb30d5-1b34-4f1a-baca-fbcca0d32945
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::put_DocHostFlags
The **DocHostFlags** property specifies the user interface capabilities of the host object.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_DocHostFlags )(  
   DWORD dwDocHostFlags   
);  
```  
  
#### Parameters  
 *dwDocHostFlags*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses **DOCHOSTUIFLAG_NO3DBORDER** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx)