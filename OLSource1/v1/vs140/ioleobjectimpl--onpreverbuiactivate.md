---
title: "IOleObjectImpl::OnPreVerbUIActivate"
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
  - "ATL.IOleObjectImpl.OnPreVerbUIActivate"
  - "IOleObjectImpl::OnPreVerbUIActivate"
  - "ATL::IOleObjectImpl::OnPreVerbUIActivate"
  - "ATL::IOleObjectImpl<T>::OnPreVerbUIActivate"
  - "OnPreVerbUIActivate"
  - "IOleObjectImpl<T>::OnPreVerbUIActivate"
  - "IOleObjectImpl.OnPreVerbUIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreVerbUIActivate method"
ms.assetid: 3cb9755f-9f05-4f7a-9edf-f3601f01d3a5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPreVerbUIActivate
Called by [DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md) before the control's user interface has been activated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 To prevent the control's user interface from being activated, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md)   
 [IOleObjectImpl::OnPostVerbUIActivate](../vs140/ioleobjectimpl--onpostverbuiactivate.md)