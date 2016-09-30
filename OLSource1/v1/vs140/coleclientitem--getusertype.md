---
title: "COleClientItem::GetUserType"
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
  - "USERCLASSTYPE_SHORT"
  - "USERCLASSTYPE_FULL"
  - "GetUserType"
  - "COleClientItem.GetUserType"
  - "COleClientItem::GetUserType"
  - "USERCLASSTYPE_APPNAME"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "USERCLASSTYPE_APPNAME"
  - "COleClientItem class, status"
  - "USERCLASSTYPE_SHORT"
  - "USERCLASSTYPE_FULL"
  - "GetUserType method"
ms.assetid: 145c4819-7e00-400f-b382-18d75e2a4c1c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetUserType
Call this function to get the user-visible string describing the OLE item's type, such as "Word document."  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nUserClassType*  
 A value indicating the desired variant of the string describing the OLE item's type. This can have one of the following values:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> The full type name displayed to the user.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> A short name (15 characters maximum) for use in pop-up menus and the Edit Links dialog box.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Name of the application servicing the class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object to which the string describing the OLE item's type is to be returned.  
  
## Remarks  
 This is often the entry in the system registration database.  
  
 If the full type name is requested but not available, the short name is used instead. If no entry for the type of OLE item is found in the registration database, or if there are no user types registered for the type of OLE item, then the user type currently stored in the OLE item is used. If that user type name is an empty string, "Unknown Object" is used.  
  
 For more information, see [IOleObject::GetUserType](http://msdn.microsoft.com/library/windows/desktop/ms688643) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetType](../vs140/coleclientitem--gettype.md)