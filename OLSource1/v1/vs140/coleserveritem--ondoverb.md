---
title: "COleServerItem::OnDoVerb"
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
  - "COleServerItem.OnDoVerb"
  - "OnDoVerb"
  - "COleServerItem::OnDoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnDoVerb method"
ms.assetid: 27f6a26c-2927-4c88-81a9-4ca830f6c068
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnDoVerb
Called by the framework to execute the specified verb.  
  
## Syntax  
  
```  
  
      virtual void OnDoVerb(  
   LONG iVerb   
);  
```  
  
#### Parameters  
 `iVerb`  
 Specifies the verb to execute. It can be any one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|0|Primary verb|`OLEIVERB_PRIMARY`|  
|1|Secondary verb|(None)|  
|– 1|Display item for editing|`OLEIVERB_SHOW`|  
|– 2|Edit item in separate window|`OLEIVERB_OPEN`|  
|– 3|Hide item|`OLEIVERB_HIDE`|  
  
 The –1 value is typically an alias for another verb. If open editing is not supported, –2 has the same effect as –1. For additional values, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If the container application was written with the Microsoft Foundation Class Library, this function is called when the [COleClientItem::Activate](../vs140/coleclientitem--activate.md) member function of the corresponding `COleClientItem` object is called. The default implementation calls the [OnShow](../vs140/coleserveritem--onshow.md) member function if the primary verb or `OLEIVERB_SHOW` is specified, [OnOpen](../vs140/coleserveritem--onopen.md) if the secondary verb or `OLEIVERB_OPEN` is specified, and [OnHide](../vs140/coleserveritem--onhide.md) if `OLEIVERB_HIDE` is specified. The default implementation calls `OnShow` if `iVerb` is not one of the verbs listed above.  
  
 Override this function if your primary verb does not show the item. For example, if the item is a sound recording and its primary verb is Play, you would not have to display the server application to play the item.  
  
 For more information, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Activate](../vs140/coleclientitem--activate.md)   
 [COleServerItem::OnShow](../vs140/coleserveritem--onshow.md)   
 [COleServerItem::OnOpen](../vs140/coleserveritem--onopen.md)   
 [COleServerItem::OnHide](../vs140/coleserveritem--onhide.md)