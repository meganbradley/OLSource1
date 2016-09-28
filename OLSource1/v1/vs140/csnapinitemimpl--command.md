---
title: "CSnapInItemImpl::Command"
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
  - "CSnapInItemImpl.Command"
  - "CSnapInItemImpl::Command"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Command method"
ms.assetid: e57706a1-1118-43c8-98a9-2348756edbca
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::Command
This method implements the Win32 function [IExtendContextMenu::Command](http://msdn.microsoft.com/library/aa814842).  
  
## Syntax  
  
```  
  
      Command(  
   long lCommandID,  
   DATA_OBJECT_TYPES type   
);  
```  
  
#### Parameters  
 *lCommandID*  
 [in] Specifies the command identifier of the menu item.  
  
 `type`  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)