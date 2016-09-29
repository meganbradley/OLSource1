---
title: "COleClientItem::Activate"
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
  - "OLEIVERB_SHOW"
  - "OLEIVERB_OPEN"
  - "Activate"
  - "COleClientItem.Activate"
  - "OLEIVERB_PRIMARY"
  - "COleClientItem::Activate"
  - "OLEIVERB_HIDE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLEIVERB_PRIMARY"
  - "Activate method"
  - "OLEIVERB_SHOW"
  - "COleClientItem class, activation"
  - "OLEIVERB_HIDE"
  - "OLEIVERB_OPEN"
ms.assetid: 77f04f7d-cdd3-4448-8d6c-4769cefedc1c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Activate
Call this function to execute the specified verb instead of [DoVerb](../vs140/coleclientitem--doverb.md) so that you can do your own processing when an exception is thrown.  
  
## Syntax  
  
```  
  
      void Activate(  
   LONG nVerb,  
   CView* pView,  
   LPMSG lpMsg = NULL   
);  
```  
  
#### Parameters  
 `nVerb`  
 Specifies the verb to execute. It can be one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|– 0|Primary verb|`OLEIVERB_PRIMARY`|  
|– 1|Secondary verb|(None)|  
|– 1|Display item for editing|`OLEIVERB_SHOW`|  
|– 2|Edit item in separate window|`OLEIVERB_OPEN`|  
|– 3|Hide item|`OLEIVERB_HIDE`|  
  
 The –1 value is typically an alias for another verb. If open editing is not supported, –2 has the same effect as –1. For additional values, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pView`  
 Pointer to the container view window that contains the OLE item; this is used by the server application for in-place activation. This parameter should be **NULL** if the container does not support in-place activation.  
  
 `lpMsg`  
 Pointer to the message that caused the item to be activated.  
  
## Remarks  
 If the server application was written using the Microsoft Foundation Class Library, this function causes the [OnDoVerb](../vs140/coleserveritem--ondoverb.md) member function of the corresponding `COleServerItem` object to be executed.  
  
 If the primary verb is Edit and zero is specified in the `nVerb` parameter, the server application is launched to allow the OLE item to be edited. If the container application supports in-place activation, editing can be done in place. If the container does not support in-place activation (or if the Open verb is specified), the server is launched in a separate window and editing can be done there. Typically, when the user of the container application double-clicks the OLE item, the value for the primary verb in the `nVerb` parameter determines which action the user can take. However, if the server supports only one action, it takes that action, no matter which value is specified in the `nVerb` parameter.  
  
 For more information, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::DoVerb](../vs140/coleclientitem--doverb.md)   
 [COleServerItem::OnDoVerb](../vs140/coleserveritem--ondoverb.md)