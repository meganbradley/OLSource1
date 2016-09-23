---
title: "IAxWinAmbientDispatch::get_Font"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - IAxWinAmbientDispatch::get_Font
  - get_Font
  - IAxWinAmbientDispatch.get_Font
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_Font method
ms.assetid: 50237b10-05b9-460e-ae22-f2d8c6dbbde7
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IAxWinAmbientDispatch::get_Font
The **Font** property specifies the ambient font of the container.  
  
## Syntax  
  
```  
  
      STDMETHOD( get_Font )(  
   IFontDisp** pFont   
);  
```  
  
#### Parameters  
 `pFont`  
 [out] The address of an **IFontDisp** interface pointer used to receive the current value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The ATL host object implementation uses the default GUI font or the system font as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)