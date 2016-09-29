---
title: "IProvideClassInfo2Impl::GetGUID"
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
  - "IProvideClassInfo2Impl::GetGUID"
  - "ATL.IProvideClassInfo2Impl.GetGUID"
  - "GetGUID"
  - "ATL::IProvideClassInfo2Impl::GetGUID"
  - "IProvideClassInfo2Impl.GetGUID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGUID method"
ms.assetid: 881e468a-9182-4c4e-83fb-a70f5a403774
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IProvideClassInfo2Impl::GetGUID
Retrieves the GUID for the object's outgoing dispinterface.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetGUID)(  
   DWORD dwGuidKind,  
   GUID* pGUID   
);  
```  
  
## Remarks  
 See [IProvideClassInfo2::GetGUID](http://msdn.microsoft.com/library/windows/desktop/ms679721) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IProvideClassInfo2Impl Class](../vs140/iprovideclassinfo2impl-class.md)