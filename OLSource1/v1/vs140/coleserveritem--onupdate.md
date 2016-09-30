---
title: "COleServerItem::OnUpdate"
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
  - "COleServerItem.OnUpdate"
  - "COleServerItem::OnUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnUpdate method"
ms.assetid: 3de50225-5db9-4f3e-843c-fe1c963b54cd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnUpdate
Called by the framework when an item has been modified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the item that modified the document. Can be **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains information about the modification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to an object storing information about the modification.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> enumeration. This parameter can have any one of the following values:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
## Remarks  
 The default implementation calls [NotifyChanged](../vs140/coleserveritem--notifychanged.md), regardless of the hint or sender.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::NotifyChanged](../vs140/coleserveritem--notifychanged.md)