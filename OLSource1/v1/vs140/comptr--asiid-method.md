---
title: "ComPtr::AsIID Method"
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
  - "client/Microsoft::WRL::ComPtr::AsIID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AsIID method"
ms.assetid: d5a3cdb2-796d-4410-966a-847c0e8fb226
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::AsIID Method
Returns a ComPtr object that represents the interface identified by the specified interface ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An interface ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If supported, a doubly-indirect pointer to the interface specified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter; otherwise, a pointer to IUnknown.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)