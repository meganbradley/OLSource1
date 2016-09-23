---
title: "CComControlBase::DoesVerbActivate"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DoesVerbActivate
  - ATL::CComControlBase::DoesVerbActivate
  - CComControlBase::DoesVerbActivate
  - CComControlBase.DoesVerbActivate
  - ATL.CComControlBase.DoesVerbActivate
dev_langs: 
  - C++
helpviewer_keywords: 
  - DoesVerbActivate method
ms.assetid: 8ee7bfe0-6844-4fce-8e9d-5425b03fcc18
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::DoesVerbActivate
Checks that the `iVerb` parameter used by `IOleObjectImpl::DoVerb` either activates the control's user interface (`iVerb` equals `OLEIVERB_UIACTIVATE`), defines the action taken when the user double-clicks the control (`iVerb` equals `OLEIVERB_PRIMARY`), displays the control (`iVerb` equals `OLEIVERB_SHOW`), or activates the control (`iVerb` equals **OLEIVERB_INPLACEACTIVATE**).  
  
## Syntax  
  
```  
  
      BOOL DoesVerbActivate(  
   LONG iVerb   
);  
```  
  
#### Parameters  
 `iVerb`  
 Value indicating the action to be performed by `DoVerb`.  
  
## Return Value  
 Returns **TRUE** if `iVerb` equals `OLEIVERB_UIACTIVATE`, `OLEIVERB_PRIMARY`, `OLEIVERB_SHOW`, or **OLEIVERB_INPLACEACTIVATE**; otherwise, returns **FALSE**.  
  
## Remarks  
 You can override this method to define your own activation verb.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IOleObjectImpl::DoVerb](../vs140/ioleobjectimpl--doverb.md)   
 [CComControlBase::DoesVerbUIActivate](../vs140/ccomcontrolbase--doesverbuiactivate.md)