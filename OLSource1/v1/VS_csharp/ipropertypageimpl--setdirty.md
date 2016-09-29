---
title: "IPropertyPageImpl::SetDirty"
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
  - "ATL::IPropertyPageImpl::SetDirty"
  - "ATL.IPropertyPageImpl<T>.SetDirty"
  - "ATL::IPropertyPageImpl<T>::SetDirty"
  - "ATL.IPropertyPageImpl.SetDirty"
  - "IPropertyPageImpl::SetDirty"
  - "IPropertyPageImpl.SetDirty"
  - "SetDirty"
  - "IPropertyPageImpl<T>::SetDirty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDirty method"
ms.assetid: a7510487-5db6-4940-be4e-e07b2ef4da8b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPropertyPageImpl::SetDirty
Flags the property page's state as changed or unchanged, depending on the value of `bDirty`.  
  
## Syntax  
  
```  
  
      void SetDirty(  
   BOOL bDirty   
);  
```  
  
#### Parameters  
 `bDirty`  
 [in] If **TRUE**, the property page's state is marked as changed. Otherwise, it is marked as unchanged.  
  
## Remarks  
 If necessary, `SetDirty` informs the frame that the property page has changed.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IPropertyPageImpl Class](../VS_csharp/ipropertypageimpl-class.md)   
 [IPropertyPageImpl::IsPageDirty](../VS_csharp/ipropertypageimpl--ispagedirty.md)   
 [IPropertyPageImpl::SetPageSite](../VS_csharp/ipropertypageimpl--setpagesite.md)   
 [IPropertyPageImpl::m_bDirty](../VS_csharp/ipropertypageimpl--m_bdirty.md)