---
title: "COleClientItem::SetLinkUpdateOptions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleClientItem.SetLinkUpdateOptions
  - OLEUPDATE_ALWAYS
  - SetLinkUpdateOptions
  - COleClientItem::SetLinkUpdateOptions
  - OLEUPDATE_ONCALL
dev_langs: 
  - C++
helpviewer_keywords: 
  - OLEUPDATE_ALWAYS
  - COleClientItem class, linked object operations and status
  - SetLinkUpdateOptions method
  - OLEUPDATE_ONCALL
ms.assetid: c2512d62-8a37-4579-95d6-027b57552e72
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::SetLinkUpdateOptions
Call this function to set the link-update option for the presentation of the specified linked item.  
  
## Syntax  
  
```  
  
      void SetLinkUpdateOptions(  
   OLEUPDATE dwUpdateOpt   
);  
```  
  
#### Parameters  
 *dwUpdateOpt*  
 The value of the link-update option for this item. This value must be one of the following:  
  
-   `OLEUPDATE_ALWAYS` Update the linked item whenever possible. This option supports the Automatic link-update radio button in the Links dialog box.  
  
-   `OLEUPDATE_ONCALL` Update the linked item only on request from the container application (when the [UpdateLink](../vs140/coleclientitem--updatelink.md) member function is called). This option supports the Manual link-update radio button in the Links dialog box.  
  
## Remarks  
 Typically, you should not change the update options chosen by the user in the Links dialog box.  
  
 For more information, see [IOleLink::SetUpdateOptions](http://msdn.microsoft.com/library/windows/desktop/ms680120) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetLinkUpdateOptions](../vs140/coleclientitem--getlinkupdateoptions.md)   
 [COleLinksDialog Class](../vs140/colelinksdialog-class.md)