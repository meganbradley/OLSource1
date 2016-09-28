---
title: "COleClientItem::DoVerb"
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
  - "COleClientItem.DoVerb"
  - "DoVerb"
  - "COleClientItem::DoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, activation"
  - "DoVerb method"
ms.assetid: 6e55e357-0965-43ee-8908-d64fd51b36c4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::DoVerb
Call `DoVerb` to execute the specified verb.  
  
## Syntax  
  
```  
  
      virtual BOOL DoVerb(  
   LONG nVerb,  
   CView* pView,  
   LPMSG lpMsg = NULL   
);  
```  
  
#### Parameters  
 `nVerb`  
 Specifies the verb to execute. It can include one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|– 0|Primary verb|`OLEIVERB_PRIMARY`|  
|– 1|Secondary verb|(None)|  
|– 1|Display item for editing|`OLEIVERB_SHOW`|  
|– 2|Edit item in separate window|`OLEIVERB_OPEN`|  
|– 3|Hide item|`OLEIVERB_HIDE`|  
  
 The –1 value is typically an alias for another verb. If open editing is not supported, –2 has the same effect as –1. For additional values, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pView`  
 Pointer to the view window; this is used by the server for in-place activation. This parameter should be **NULL** if the container application does not allow in-place activation.  
  
 `lpMsg`  
 Pointer to the message that caused the item to be activated.  
  
## Return Value  
 Nonzero if the verb was successfully executed; otherwise 0.  
  
## Remarks  
 This function calls the [Activate](../vs140/coleclientitem--activate.md) member function to execute the verb. It also catches exceptions and displays a message box to the user if one is thrown.  
  
 If the primary verb is Edit and zero is specified in the `nVerb` parameter, the server application is launched to allow the OLE item to be edited. If the container application supports in-place activation, editing can be done in place. If the container does not support in-place activation (or if the Open verb is specified), the server is launched in a separate window and editing can be done there. Typically, when the user of the container application double-clicks the OLE item, the value for the primary verb in the `nVerb` parameter determines which action the user can take. However, if the server supports only one action, it takes that action, no matter which value is specified in the `nVerb` parameter.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Activate](../vs140/coleclientitem--activate.md)