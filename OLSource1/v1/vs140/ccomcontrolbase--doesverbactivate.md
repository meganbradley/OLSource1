---
title: "CComControlBase::DoesVerbActivate"
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
  - "DoesVerbActivate"
  - "ATL::CComControlBase::DoesVerbActivate"
  - "CComControlBase::DoesVerbActivate"
  - "CComControlBase.DoesVerbActivate"
  - "ATL.CComControlBase.DoesVerbActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesVerbActivate method"
ms.assetid: 8ee7bfe0-6844-4fce-8e9d-5425b03fcc18
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::DoesVerbActivate
Checks that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter used by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> either activates the control's user interface (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), defines the action taken when the user double-clicks the control (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), displays the control (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), or activates the control (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> equals **OLEIVERB_INPLACEACTIVATE**).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Value indicating the action to be performed by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns **TRUE** if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or **OLEIVERB_INPLACEACTIVATE**; otherwise, returns **FALSE**.  
  
## Remarks  
 You can override this method to define your own activation verb.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IOleObjectImpl::DoVerb](../vs140/ioleobjectimpl--doverb.md)   
 [CComControlBase::DoesVerbUIActivate](../vs140/ccomcontrolbase--doesverbuiactivate.md)