---
title: "CComControlBase::DoesVerbUIActivate"
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
  - "CComControlBase.DoesVerbUIActivate"
  - "ATL.CComControlBase.DoesVerbUIActivate"
  - "CComControlBase::DoesVerbUIActivate"
  - "ATL::CComControlBase::DoesVerbUIActivate"
  - "DoesVerbUIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesVerbUIActivate method"
ms.assetid: 32fc50d6-27b0-4ee5-b083-5c8cac04a76f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::DoesVerbUIActivate
Checks that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter used by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> causes the control's user interface to activate and returns **TRUE**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Value indicating the action to be performed by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns **TRUE** if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or **OLEIVERB_INPLACEACTIVATE**. Otherwise, the method returns **FALSE**.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IOleObjectImpl::DoVerb](../vs140/ioleobjectimpl--doverb.md)   
 [CComControlBase::DoesVerbActivate](../vs140/ccomcontrolbase--doesverbactivate.md)