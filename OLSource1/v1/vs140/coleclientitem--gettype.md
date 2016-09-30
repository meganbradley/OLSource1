---
title: "COleClientItem::GetType"
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
  - "COleClientItem::GetType"
  - "OT_LINK"
  - "OT_EMBEDDED"
  - "OT_STATIC"
  - "GetType"
  - "COleClientItem.GetType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, status"
  - "OT_STATIC"
  - "GetType method"
  - "OT_EMBEDDED"
  - "OT_LINK"
ms.assetid: 3490e459-2f06-4b0f-9595-47184705f48c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetType
Call this function to determine whether the OLE item is embedded or linked, or static.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An unsigned integer with one of the following values:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> The OLE item is a link.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> The OLE item is embedded.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> The OLE item is static, that is, it contains only presentation data, not native data, and thus cannot be edited.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetUserType](../vs140/coleclientitem--getusertype.md)