---
title: "IAxWinAmbientDispatch::put_OptionKeyPath"
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
  - IAxWinAmbientDispatch::put_OptionKeyPath
  - put_OptionKeyPath
  - IAxWinAmbientDispatch.put_OptionKeyPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - put_OptionKeyPath method
ms.assetid: 8b29a287-31e4-4572-b10b-2c825020fb0b
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IAxWinAmbientDispatch::put_OptionKeyPath
The **OptionKeyPath** property specifies the registry key path to user settings.  
  
## Syntax  
  
```  
  
      STDMETHOD( put_OptionKeyPath )(  
   BSTR bstrOptionKeyPath   
);  
```  
  
#### Parameters  
 *bstrOptionKeyPath*  
 [in] The new value of this property.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx)