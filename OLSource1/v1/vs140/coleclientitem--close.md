---
title: "COleClientItem::Close"
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
  - "OLECLOSE_NOSAVE"
  - "COleClientItem::Close"
  - "OLECLOSE_SAVEIFDIRTY"
  - "OLECLOSE_PROMPTSAVE"
  - "COleClientItem.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLECLOSE_NOSAVE"
  - "Close method"
  - "OLECLOSE_SAVEIFDIRTY"
  - "OLECLOSE_PROMPTSAVE"
  - "COleClientItem class, general operations"
ms.assetid: 33e205aa-d72f-428a-b597-9433cf4f8c2a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Close
Call this function to change the state of an OLE item from the running state to the loaded state, that is, loaded with its handler in memory but with the server not running.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flag specifying under what circumstances the OLE item is saved when it returns to the loaded state. It can have one of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Save the OLE item.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Do not save the OLE item.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Prompt the user on whether to save the OLE item.  
  
## Remarks  
 This function has no effect when the OLE item is not running.  
  
 For more information, see [IOleObject::Close](http://msdn.microsoft.com/library/windows/desktop/ms683922) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::UpdateLink](../vs140/coleclientitem--updatelink.md)