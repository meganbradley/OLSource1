---
title: "ComPtr::operator&amp; Operator"
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
  - "client/Microsoft::WRL::ComPtr::operator&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator& operator"
ms.assetid: 2d77fda6-f4b2-45c1-8a0e-fbc355013531
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::operator&amp; Operator
Releases the interface associated with this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and then retrieves the address of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A weak reference to the current <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method differs from [ComPtr::GetAddressOf](../vs140/comptr--getaddressof-method.md) in that this method releases a reference to the interface pointer. Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when you require the address of the interface pointer but do not want to release that interface.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)