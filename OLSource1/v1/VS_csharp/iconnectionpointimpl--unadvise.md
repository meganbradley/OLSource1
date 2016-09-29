---
title: "IConnectionPointImpl::Unadvise"
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
  - "ATL::IConnectionPointImpl::Unadvise"
  - "ATL.IConnectionPointImpl.Unadvise"
  - "IConnectionPointImpl.Unadvise"
  - "Unadvise"
  - "IConnectionPointImpl::Unadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unadvise method"
ms.assetid: 1de63791-3c56-40ab-9721-9d0221131713
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IConnectionPointImpl::Unadvise
Terminates a connection previously established through [Advise](../VS_csharp/iconnectionpointimpl--advise.md).  
  
## Syntax  
  
```  
  
      STDMETHOD(Unadvise)(  
   DWORD dwCookie   
);  
```  
  
## Remarks  
 See [IConnectionPoint::Unadvise](http://msdn.microsoft.com/library/windows/desktop/ms686608) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IConnectionPointImpl Class](../VS_csharp/iconnectionpointimpl-class.md)