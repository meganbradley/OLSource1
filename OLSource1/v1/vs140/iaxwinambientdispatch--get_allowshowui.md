---
title: "IAxWinAmbientDispatch::get_AllowShowUI"
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
  - "IAxWinAmbientDispatch.get_AllowShowUI"
  - "IAxWinAmbientDispatch::get_AllowShowUI"
  - "get_AllowShowUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_AllowShowUI method"
ms.assetid: 311e83f9-2f98-4017-ad56-52dce0685e96
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch::get_AllowShowUI
The **AllowShowUI** property specifies whether the hosted control is allowed to display its own user interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pbAllowShowUI*  
 [out] The address of a variable to receive the current value of this property.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)   
 [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx)