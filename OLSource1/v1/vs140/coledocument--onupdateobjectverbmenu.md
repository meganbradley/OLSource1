---
title: "COleDocument::OnUpdateObjectVerbMenu"
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
  - "OnUpdateObjectVerbMenu"
  - "COleDocument::OnUpdateObjectVerbMenu"
  - "COleDocument.OnUpdateObjectVerbMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDocument class, message handlers"
  - "OnUpdateObjectVerbMenu method"
ms.assetid: 17c539e6-6ea6-48c0-846a-9e35707782d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnUpdateObjectVerbMenu
Called by the framework to update the *ObjectName* command on the Edit menu and the Verb submenu accessed from the *ObjectName* command, where *ObjectName* is the name of the OLE object embedded in the document.  
  
## Syntax  
  
```  
  
      afx_msg void OnUpdateObjectVerbMenu(  
   CCmdUI* pCmdUI   
);  
```  
  
#### Parameters  
 `pCmdUI`  
 A pointer to a `CCmdUI` structure that represents the menu that generated the update command. The update handler calls the **Enable** member function of the `CCmdUI` structure through `pCmdUI` to update the user interface.  
  
## Remarks  
 `OnUpdateObjectVerbMenu` updates the *ObjectName* command's user interface depending on whether or not a valid object exists in the document. If an object exists, the *ObjectName* command on the Edit menu is enabled. When this menu command is selected, the Verb submenu is displayed. The Verb submenu contains all the verb commands available for the object, such as Edit, Properties, and so on. Override this function to change the behavior.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnEditConvert](../vs140/coledocument--oneditconvert.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)