---
title: "CComClassFactoryAutoThread::CreateInstance"
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
  - "ATL.CComClassFactoryAutoThread.CreateInstance"
  - "CComClassFactoryAutoThread.CreateInstance"
  - "ATL::CComClassFactoryAutoThread::CreateInstance"
  - "CComClassFactoryAutoThread::CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 4a42c68e-163e-4186-872b-d6835ec03ad3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactoryAutoThread::CreateInstance
Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be **NULL**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is non-**NULL**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value.  
  
## Remarks  
 If your module derives from [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md), <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> first selects a thread to create the object in the associated apartment.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactoryAutoThread Class](../vs140/ccomclassfactoryautothread-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)