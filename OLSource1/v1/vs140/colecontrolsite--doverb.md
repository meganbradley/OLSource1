---
title: "COleControlSite::DoVerb"
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
  - "COleControlSite.DoVerb"
  - "COleControlSite::DoVerb"
  - "DoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "DoVerb method"
ms.assetid: 21a71d47-5efb-4005-95fc-a2fa832c7ec0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::DoVerb
Executes the specified verb.  
  
## Syntax  
  
```  
  
      virtual HRESULT DoVerb(  
   LONG nVerb,  
   LPMSG lpMsg = NULL   
);  
```  
  
#### Parameters  
 `nVerb`  
 Specifies the verb to execute. It can include one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|0|Primary verb|`OLEIVERB_PRIMARY`|  
|-1|Secondary verb|(None)|  
|1|Displays the object for editing.|`OLEIVERB_SHOW`|  
|-2|Edits the item in a separate window.|`OLEIVERB_OPEN`|  
|-3|Hides the object.|`OLEIVERB_HIDE`|  
|-4|Activates a control in-place.|`OLEIVERB_UIACTIVATE`|  
|-5|Activates a control in-place, without additional user interface elements.|**OLEIVERB_INPLACEACTIVATE**|  
|-7|Display the control's properties.|**OLEIVERB_PROPERTIES**|  
  
 `lpMsg`  
 Pointer to the message that caused the item to be activated.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 This function directly calls through the control's `IOleObject` interface to execute the specified verb. If an exception is thrown as a result of this function call, an `HRESULT` error code is returned.  
  
 For more information, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)