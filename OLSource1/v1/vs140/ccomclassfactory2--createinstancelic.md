---
title: "CComClassFactory2::CreateInstanceLic"
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
  - "ATL::CComClassFactory2<license>::CreateInstanceLic"
  - "CComClassFactory2.CreateInstanceLic"
  - "ATL::CComClassFactory2::CreateInstanceLic"
  - "CComClassFactory2::CreateInstanceLic"
  - "ATL.CComClassFactory2.CreateInstanceLic"
  - "CreateInstanceLic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstanceLic method"
ms.assetid: ceccacf8-bf06-49fa-be71-fe8addb2256c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2::CreateInstanceLic
Similar to [CreateInstance](../vs140/ccomclassfactory2--createinstance.md), except that <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> requires a license key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be **NULL**.  
  
 *pUnkReserved*  
 [in] Not used. Must be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is non-**NULL**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The run-time license key previously obtained from a call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This key is required to create the object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value.  
  
## Remarks  
 You can obtain a license key using [RequestLicKey](../vs140/ccomclassfactory2--requestlickey.md). In order to create an object on an unlicensed machine, you must call <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)