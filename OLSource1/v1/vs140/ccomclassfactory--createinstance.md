---
title: "CComClassFactory::CreateInstance"
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
  - "CComClassFactory.CreateInstance"
  - "CComClassFactory::CreateInstance"
  - "ATL::CComClassFactory::CreateInstance"
  - "ATL.CComClassFactory.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 47f13494-d395-4e3e-8493-b67da6829c4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory::CreateInstance
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
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory Class](../vs140/ccomclassfactory-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)