---
title: "IPersistStreamInitImpl::GetSizeMax"
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
  - "IPersistStreamInitImpl.GetSizeMax"
  - "GetSizeMax"
  - "IPersistStreamInitImpl::GetSizeMax"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSizeMax method"
ms.assetid: a1b9dbb0-ad2d-4b9c-a095-9763d2b905f6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistStreamInitImpl::GetSizeMax
Retrieves the size of the stream needed to save the object's data.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetSizeMax)(  
   ULARGE_INTEGER FAR* pcbSize   
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IPersistStreamInit::GetSizeMax](http://msdn.microsoft.com/library/windows/desktop/ms687287) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistStreamInitImpl Class](../vs140/ipersiststreaminitimpl-class.md)