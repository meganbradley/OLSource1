---
title: "COleClientItem::GetLinkUpdateOptions"
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
  - "OLEUPDATE_ALWAYS"
  - "COleClientItem.GetLinkUpdateOptions"
  - "COleClientItem::GetLinkUpdateOptions"
  - "GetLinkUpdateOptions"
  - "OLEUPDATE_ONCALL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLinkUpdateOptions method"
  - "OLEUPDATE_ALWAYS"
  - "COleClientItem class, linked object operations and status"
  - "OLEUPDATE_ONCALL"
ms.assetid: 66087ed6-4ded-49e5-a583-afbd23aa2a9f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetLinkUpdateOptions
Call this function to get the current value of the link-update option for the OLE item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 One of the following values:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> Update the linked item whenever possible. This option supports the Automatic link-update radio button in the Links dialog box.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Update the linked item only on request from the container application (when the [UpdateLink](../vs140/coleclientitem--updatelink.md) member function is called). This option supports the Manual link-update radio button in the Links dialog box.  
  
## Remarks  
 This is an advanced operation.  
  
 This function is called automatically by the [COleLinksDialog](../vs140/colelinksdialog-class.md) class.  
  
 For more information, see [IOleLink::GetUpdateOptions](http://msdn.microsoft.com/library/windows/desktop/ms680100) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetLinkUpdateOptions](../vs140/coleclientitem--setlinkupdateoptions.md)   
 [COleLinksDialog Class](../vs140/colelinksdialog-class.md)