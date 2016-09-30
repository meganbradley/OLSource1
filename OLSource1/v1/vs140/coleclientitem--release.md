---
title: "COleClientItem::Release"
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
  - "COleClientItem.Release"
  - "COleClientItem::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
  - "COleClientItem class, general operations"
ms.assetid: 5e895c84-b4af-4cef-a307-b82e0f523ad3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Release
Call this function to clean up resources used by the OLE item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flag specifying under what circumstances the OLE item is saved when it returns to the loaded state. For a list of possible values, see [COleClientItem::Close](../vs140/coleclientitem--close.md).  
  
## Remarks  
 **Release** is called by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> destructor.  
  
 For more information, see [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Close](../vs140/coleclientitem--close.md)   
 [COleClientItem::Delete](../vs140/coleclientitem--delete.md)